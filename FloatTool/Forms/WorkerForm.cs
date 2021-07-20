using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using FloatTool.Models;
using FloatTool.Models.Parameters;
using FloatTool.Models.Responses;
using FloatTool.Models.Settings.Worker;
using FloatTool.Tools;
using MaterialSkin.Controls;
using Newtonsoft.Json;
using Serilog;

namespace FloatTool.Forms
{
    public partial class WorkerForm : MaterialForm
    {
        private static readonly BrowserLifeSpanHandler BrowserLifeSpanHandler = new();
        private static readonly HttpClient HttpClient = new ();
        private static readonly Random Random = new ();

        private readonly RequestContextSettings _requestContextSettings = new() { CachePath = GlobalFolders.CacheFolderPath };
        private readonly WorkerParams _parameters;
        private FloatApi _floatApi;
        private ChromiumWebBrowser _browser;
        private string _parserScript;

        private bool _isWorking;
        private bool _isAutoProcessing;

        private WorkerSettings _settings;

        public WorkerForm(WorkerSettings settings, WorkerParams parameters)
        {
            InitializeComponent();

            _settings = settings;
            _parameters = parameters;
        }

        private async void WorkerForm_Load(object sender, EventArgs e)
        {
            _parserScript = ScriptsBuilder.BuildParserScript(new ParserScriptParams
            {
                Url = _parameters.Url,
                Count = _settings.ParserScriptSettings.Count.ToString(),
                Country = _settings.ParserScriptSettings.Country,
                Language = _settings.ParserScriptSettings.Language,
                Currency = _settings.ParserScriptSettings.Currency.ToString(),
                Filter = _settings.ParserScriptSettings.Filter
            });

            _floatApi = new FloatApi();

            // Proxy enabled check
            var requestContext = new RequestContext(_requestContextSettings);
            if (_settings.ProxySettings.IsEnabled)
            {
                // Show throbber
                ProxyCheckThrobberImageBox.Visible = true;
                CurrentIpLabel.Text = _parameters.Proxy.ToString();
                CurrentIpLabel.Visible = true;
                try
                {
                    // <-- RequestContext settings
                    var host = _parameters.Proxy.Ip;
                    var port = _parameters.Proxy.Port;
                    await Cef.UIThreadTaskFactory.StartNew(async () =>
                    {
                        await requestContext.SetProxyAsync(host, port);
                    });
                    // --> *

                    // Proxy ping check
                    const string ipTestUrl = "http://icanhazip.com/";
                    _ = Task.Factory.StartNew(async () =>
                    {
                        var ip = (await HttpClient.GetStringAsync(ipTestUrl)).TrimEnd(' ');
                        if (ip == _parameters.Proxy.ToString())
                        {
                            ProxyCheckThrobberImageBox.Invoke((MethodInvoker) delegate
                            {
                                ProxyCheckThrobberImageBox.Image = Properties.Resources.yes;
                            });
                        }
                        else
                        {
                            ProxyCheckThrobberImageBox.Invoke((MethodInvoker)delegate
                            {
                                ProxyCheckThrobberImageBox.Image = Properties.Resources.no;
                            });
                        }
                    });
                }
                catch (Exception exception)
                {
                    MaterialMessageBox.Show(
                        $"Possible reason:\n\nProxy '{_parameters.Proxy}' is invalid\n\n{exception}",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            _browser = new ChromiumWebBrowser(_parameters.Url, requestContext)
            {
                Name = "Browser",
                Dock = DockStyle.Fill,
                LifeSpanHandler = BrowserLifeSpanHandler,
                Margin = Padding.Empty
            };

            // UI settings
            AutoBuyCheckbox.Checked = _settings.AutoBuy;
            MinDelayTextBox.Text = _settings.MinDelay.ToString();
            MaxDelayTextBox.Text = _settings.MaxDelay.ToString();
            BrowserPanel.Controls.Add(_browser);
            DataLabel.Text = $"P:{_parameters.Price}|F:{_parameters.Float}";

            // Junk remover
            if (_settings.JunkRemoverSettings.IsEnabled)
            {
                _browser.ExecuteScriptAsyncWhenPageLoaded(ScriptsBuilder.BuildJunkRemoverScript());
            }
            // --> *

            _browser.LoadingStateChanged += (_, _) =>
            {
                if (_browser.IsLoading == false)
                {
                    LoadingPanel.Invoke((MethodInvoker)delegate {
                        // Running on the UI thread
                        Controls.Remove(LoadingPanel);
                    });

                    Log.Debug("[{0}]: Page '{1}' successfully loaded", Text, _browser.GetMainFrame().Url);
                }
            };
        }

        private void AutoBuyCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            _settings.AutoBuy = AutoBuyCheckbox.Checked;
        }

        private void DelayTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _settings.MinDelay = int.Parse(MinDelayTextBox.Text);
                _settings.MaxDelay = int.Parse(MaxDelayTextBox.Text);
            }
            catch
            {
                MaterialMessageBox.Show("Invalid delay value");
            }
        }

        private async void ManualButton_Click(object sender, EventArgs e)
        {
            try
            {
                Log.Debug("[{0}]: Manual update", Text);
                await ProcessAsync();
            }
            catch (Exception exception)
            {
                Log.Warning(exception.ToString());
            }
        }

        private async void AutoButton_Click(object sender, EventArgs e)
        {
            try
            {
                _isAutoProcessing = true;

                AutoButton.Hide();
                StopButton.Show();

                int GetRandomDelay()
                {
                    // ReSharper disable once ConvertIfStatementToReturnStatement
                    if (_settings.MinDelay == _settings.MaxDelay)
                    {
                        return _settings.MinDelay;
                    }

                    return Random.Next(_settings.MinDelay, _settings.MaxDelay);
                }

                while (_isAutoProcessing)
                {
                    await ProcessAsync();
                    var delay = GetRandomDelay();
                    Log.Debug("[{0}]: Waiting for {1} milliseconds ", Text, delay);
                    await Task.Delay(delay);
                    Log.Debug("[{0}]: The wait is over. Trying to send a new request.", Text);
                }
                Log.Debug("[{0}]: Auto-update stopped successfully", Text);

                AutoButton.Show();
                StopButton.Hide();
            }
            catch (Exception exception)
            {
                Log.Warning(exception.ToString());
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            _isAutoProcessing = false;
            Log.Debug("[{0}]: Stopping... This may take some time", Text);
        }

        private void WorkerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_settings.ProxySettings.IsEnabled)
            {
                _parameters.Proxy.IsUsed = false;
            }

            Log.Debug("[{0}]: Closed", Text);
        }

        public async Task ProcessAsync(CancellationToken token = default)
        {
            _browser.JavascriptMessageReceived += JavascriptMessageReceivedHandler;
            async void JavascriptMessageReceivedHandler(object o, JavascriptMessageReceivedEventArgs eventArgs)
            {
                try
                {
                    var parseScriptResponse = JsonConvert.DeserializeObject<ParserScriptResponse>((string)eventArgs.Message);

                    var itemsBuyData = new List<ListingData>();
                    for (var i = 0; i < parseScriptResponse!.Links.Count; i++)
                    {
                        var link = parseScriptResponse!.Links[i];
                        var listingInfo = await _floatApi.ParseInfo(link);

                        itemsBuyData.Add(new ListingData
                        {
                            ListingId = parseScriptResponse.IdList[i],
                            FloatValue = listingInfo.FloatValue,
                            Price = parseScriptResponse.Prices[i]
                        });
                    }

                    foreach (var data in itemsBuyData)
                    {
                        if (data.ListingId == 0 || data.Price == null) continue;

                        var isValid = false;
                        if (data.FloatValue <= _parameters.Float && data.Price <= _parameters.Price)
                        {
                            isValid = true;

                            if (_isWorking == false) return;

                            // Auto Buy
                            if (AutoBuyCheckbox.Checked)
                            {
                                var buyListingScript = ScriptsBuilder.BuildBuyListingScript(new BuyListingScriptParams
                                {
                                    ListingId = data.ListingId,
                                    BuyNowDelay = _settings.BuyScriptSettings.BuyNowDelay,
                                    AgreeDelay = _settings.BuyScriptSettings.AgreeDelay,
                                    PurchaseDelay = _settings.BuyScriptSettings.PurchaseDelay,
                                    CloseWindowDelay = _settings.BuyScriptSettings.CloseWindowDelay
                                });
                                _browser.GetMainFrame().ExecuteJavaScriptAsync(buyListingScript);
                                Log.Information("[{0}]: Notification ='{1}' Data='{2}'", Text, "Successfully purchased", data);
                                continue;
                            }

                            // Notificator
                            var notificatorScriptParams = new NotificatorScriptParams
                            {
                                ListingId = data.ListingId
                            };
                            var notificatorScript = ScriptsBuilder.BuildNotificatorScript(notificatorScriptParams);
                            _browser.GetMainFrame().ExecuteJavaScriptAsync(notificatorScript);
                        }
                        Log.Debug("[{0}]: IsValid='{1}' Data='{2}'", Text, isValid, data);
                    }
                    _browser.JavascriptMessageReceived -= JavascriptMessageReceivedHandler;
                    _isWorking = false;
                }
                catch (Exception exception)
                {
                    Log.Warning(exception.ToString());
                }
            }

            _browser.GetMainFrame().ExecuteJavaScriptAsync(_parserScript);
            Log.Debug("[{0}]: Receiving data from Steam servers", Text);
            _isWorking = true;

            while (_isWorking)
            {
                await Task.Delay(100, token);
            }
            Log.Debug("[{0}]: Listings have been successfully updated", Text);
        }
    }
}
