using System;
using System.IO;
using System.Windows.Forms;
using FloatTool.Controls;
using FloatTool.Models;
using FloatTool.Models.Settings.Worker;
using MaterialSkin.Controls;

namespace FloatTool.Forms
{
    public partial class SettingsForm : MaterialForm
    {
        // ReSharper disable once InconsistentNaming
        private readonly ProxyListControl ProxyListControl;

        public SettingsForm()
        {
            InitializeComponent();

            ProxyListControl = new ProxyListControl {Dock = DockStyle.Fill};
            ProxySettingsProxyListPanel.Controls.Add(ProxyListControl);
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            // <-- Previous values loading
            var currentSettings = GlobalSettings.WorkerSettings;

            // Parser Script Settings
            ParserScriptCountTextBox.Text = currentSettings.ParserScriptSettings.Count.ToString();
            ParserScriptCountryTextBox.Text = currentSettings.ParserScriptSettings.Country;
            ParserScriptLanguageTextBox.Text = currentSettings.ParserScriptSettings.Language;
            ParserScriptCurrencyTextBox.Text = currentSettings.ParserScriptSettings.Currency.ToString();
            ParserScriptSettingsFilterTextBox.Text = currentSettings.ParserScriptSettings.Filter;

            // Buy Script Settings
            BuyScriptBuyNowTextBox.Text = currentSettings.BuyScriptSettings.BuyNowDelay.ToString();
            BuyScriptAgreeTextBox.Text = currentSettings.BuyScriptSettings.AgreeDelay.ToString();
            BuyScriptPurchaseTextBox.Text = currentSettings.BuyScriptSettings.PurchaseDelay.ToString();
            BuyScriptCloseWindowTextBox.Text = currentSettings.BuyScriptSettings.CloseWindowDelay.ToString();

            // Junk Remover Script Settings
            JunkRemoverScriptSettingsEnabledCheckBox.Checked = currentSettings.JunkRemoverSettings.IsEnabled;

            // Proxy Settings
            ProxyEnabledCheckBox.Checked = currentSettings.ProxySettings.IsEnabled;
            if (currentSettings.ProxySettings.ProxyList != null)
                foreach (var proxy in currentSettings.ProxySettings.ProxyList.Items)
                {
                    ProxyListControl.AddItem(proxy);
                }

            // Worker Default Settings
            WorkerDefaultSettingsDelayTextBox.Text = currentSettings.Delay.ToString();
            WorkerDefaultSettingsAutoBuyCheckbox.Checked = currentSettings.AutoBuy;

            // --> *
        }

        private void ApplyOperationButton_Click(object sender, EventArgs e)
        {
            var restartIsNeeded = false;
            try
            {
                // Creating new settings objects and saving
                var parserScriptSettings = new ParserScriptSettings()
                {
                    Count = int.Parse(ParserScriptCountTextBox.Text),
                    Currency = int.Parse(ParserScriptCurrencyTextBox.Text),
                    Language = ParserScriptLanguageTextBox.Text,
                    Country = ParserScriptCountryTextBox.Text,
                    Filter = ParserScriptSettingsFilterTextBox.Text,
                };

                var buyScriptSettings = new BuyScriptSettings
                {
                    BuyNowDelay = int.Parse(BuyScriptBuyNowTextBox.Text),
                    AgreeDelay = int.Parse(BuyScriptAgreeTextBox.Text),
                    PurchaseDelay = int.Parse(BuyScriptPurchaseTextBox.Text),
                    CloseWindowDelay = int.Parse(BuyScriptCloseWindowTextBox.Text),
                };

                var junkRemoverSettings = new JunkRemoverSettings
                {
                    IsEnabled = JunkRemoverScriptSettingsEnabledCheckBox.Checked,
                };

                var proxyList = ProxyListControl.Items;
                var proxySettings = new ProxySettings
                {
                    IsEnabled = ProxyEnabledCheckBox.Checked,
                    ProxyList = new ProxyList {Items = proxyList},
                };

                var workerSettings = new WorkerSettings
                {
                    AutoBuy = WorkerDefaultSettingsAutoBuyCheckbox.Checked,
                    Delay = int.Parse(WorkerDefaultSettingsDelayTextBox.Text),
                    ParserScriptSettings = parserScriptSettings,
                    BuyScriptSettings = buyScriptSettings,
                    JunkRemoverSettings = junkRemoverSettings,
                    ProxySettings = proxySettings,
                };

                var previousWorkerSettings = GlobalSettings.WorkerSettings;

                if (previousWorkerSettings.ProxySettings.IsEnabled == true && workerSettings.ProxySettings.IsEnabled == false)
                {
                    var dialogResult = MaterialMessageBox.Show(
                        "Disabling the proxy while the program is running is impossible.\nWant to restart the program to shut it down? ",
                        "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        // Updating proxy settings
                        proxySettings.IsEnabled = false;
                        workerSettings.ProxySettings = proxySettings;

                        // Requesting application restart
                        restartIsNeeded = true;
                    }
                }

                GlobalSettings.WorkerSettings = workerSettings;
                GlobalSettings.Save();

                if (restartIsNeeded)
                {
                    Application.Restart();
                }
            }
            catch (Exception exception)
            {
                MaterialMessageBox.Show($"One or more parameters are specified incorrectly.\n\n Full Stack Trace: {exception}");
                return; // Try again
            }


            this.Close();
        }

        private void CancelOperationButton_Click(object sender, EventArgs e)
        {
            // Just window closing
            this.Close();
        }

        private void ProxySettingsProxyListFromFileButton_Click(object sender, EventArgs e)
        {
            var openFileDialog = ProxySettingsProxyListFileOpenDialog;
            openFileDialog.Filter = "TXT files (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;

            if (openFileDialog.ShowDialog() != DialogResult.OK) return;

            var content = File.ReadAllLines(openFileDialog.FileName);

            ProxyListControl.Controls.Clear();
            ProxyListControl.Clear();
            foreach (var line in content)
            {
                try
                {
                    var proxy = new Proxy
                    {
                        Ip = line.Split(':')[0],
                        Port = int.Parse(line.Split(':')[1])
                    };
                    ProxyListControl.AddItem(proxy);
                }
                catch (Exception exception)
                {
                    MaterialMessageBox.Show($"Possible reason:\n\nInvalid proxy format\n\n{exception}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void AccountButton_Click(object sender, EventArgs e)
        {
            new SteamAccountForm().Show();
        }
    }
}
