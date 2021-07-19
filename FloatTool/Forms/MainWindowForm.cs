using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using FloatTool.Controls;
using FloatTool.Models;
using FloatTool.Models.Parameters;
using FloatTool.Models.Settings.Worker;
using FloatTool.Tools;
using MaterialSkin.Controls;
using Newtonsoft.Json;

namespace FloatTool.Forms
{
    public partial class MainWindowForm : MaterialForm
    {
        private static readonly HttpClient HttpClient = new ();
        private readonly FloatApi _csGoFloatApi = new ();
        private readonly WeaponsListControl _weaponListControl = new() {Dock = DockStyle.Top};
        private readonly IDictionary<string, WorkerForm> _workersDictionary = new Dictionary<string, WorkerForm>();

        public MainWindowForm()
        {
            InitializeComponent();
            
        // Adding control to MainWindowForm
        Controls["WeaponsListPanel"].Controls.Add(_weaponListControl);
        }

        static MainWindowForm()
        {
            HttpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/41.0.2228.0 Safari/537.36");
            HttpClient.DefaultRequestHeaders.Add("Connection", "keep-alive");
            HttpClient.DefaultRequestHeaders.Add("Keep-alive", "3600");
        }

        private WorkerForm CreateWorker(Weapon item)
        {
            var url = "https://steamcommunity.com/market/listings/730/" + item.Label;
            var workerParams = new WorkerParams
            {
                Url = url,
                Float = item.Float,
                Price = item.Price,
            };

            // Proxy settings
            if (GlobalSettings.WorkerSettings.ProxySettings.IsEnabled)
            {
                if (GlobalSettings.WorkerSettings.ProxySettings
                    .ProxyList.Items.Find(proxy => proxy.IsUsed == false) != null)
                {
                    workerParams.Proxy = GlobalSettings.WorkerSettings.ProxySettings
                        .ProxyList.Items.First(proxy => proxy.IsUsed == false);
                    workerParams.Proxy.IsUsed = true;
                }
                else
                {
                    throw new ArgumentException("Could not find an unused proxy from the proxy list");
                }
            }

            var workerLabel = $"{item.Label} Worker";
            var worker = new WorkerForm(GlobalSettings.WorkerSettings, workerParams)
            {
                Text = workerLabel
            };

            // OnFormClosed Event subscribe
            void OnWorkerClosed(object o, FormClosedEventArgs args)
            {
                worker.FormClosed -= OnWorkerClosed;
                _workersDictionary.Remove(item.Label);
            }
            worker.FormClosed += OnWorkerClosed;

            return worker;
        }

        private async Task<Weapon> CreateWeapon(double floatValue, double price, string link)
        {
            try
            {
                var listingInfo = await _csGoFloatApi.ParseInfo(link);
                var label = listingInfo.FullItemName;
                var color = FloatApi.GetColor(listingInfo.Rarity);

                // ReSharper disable once InvertIf
                if (!GlobalImagesCache.Contains(listingInfo.FullItemName))
                {
                    // Downloading
                    using var stream = await HttpClient.GetStreamAsync(listingInfo.ImageUrl);
                    GlobalImagesCache.Add(listingInfo.FullItemName, Image.FromStream(stream));
                }

                return new Weapon
                {
                    Label = label,
                    Float = floatValue,
                    Price = price,
                    RarityColor = color
                };
            }
            catch (Exception exception)
            {
                throw new ArgumentOutOfRangeException("Invalid link", exception);
            }
        }

        private async void AddItemButton_Click(object sender, EventArgs e)
        {
            try
            {
                var link = ParseTool.ParseLink(LinkTextBox.Text);
                var floatValue = ParseTool.ParseFloat(FloatTextBox.Text);
                var priceValue = ParseTool.ParsePrice(PriceTextBox.Text);

                var weapon = await CreateWeapon(floatValue, priceValue, link);

                if (GlobalWeaponsList.Weapons.Contains(weapon, Weapon.EqualityComparer))
                {
                    throw new ArgumentException($"Weapon '{weapon.Label}' already exists");
                }

                GlobalWeaponsList.Weapons.Add(weapon);
                GlobalWeaponsList.Save();

                _weaponListControl.Append(weapon);
            }
            catch (Exception exception)
            {
                MaterialMessageBox.Show($"Possible reason:\n\n{exception.Message}\n\n{exception}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MainWindowForm_Load(object sender, EventArgs e)
        {
            // <-- Weapons list config loading
            // If the configuration file does not exist, create a new one 
            if (!GlobalWeaponsList.IsCreated)
            {
                GlobalWeaponsList.Save();
            }

            // Reading
            var weaponsJson = File.ReadAllText(GlobalWeaponsList.WeaponsListConfigPath);

            // Deserialization
            var weaponsList = JsonConvert.DeserializeObject<List<Weapon>>(weaponsJson);

            // Setup
            GlobalWeaponsList.Weapons = weaponsList;
            foreach (var weapon in GlobalWeaponsList.Weapons!.ToArray())
            {
                _weaponListControl.Append(weapon);
            }
            // --> *

            // <-- Worker settings config loading
            // If the configuration file does not exist, create a new one 
            if (!GlobalSettings.IsCreated)
            {
                GlobalSettings.Save();
            }

            // Reading
            var workerSettingsJson = File.ReadAllText(GlobalSettings.WorkerSettingsConfigPath);

            // Deserialization
            var workerSettings = JsonConvert.DeserializeObject<WorkerSettings>(workerSettingsJson);

            // Setup
            GlobalSettings.WorkerSettings = workerSettings;

            // Proxy status 
            // --> *

            // TODO Test Items. DELETE IN RELEASE
            try
            {
                //_weaponListControl.Append(await CreateWeapon(1.0, 0.05, "steam://rungame/730/76561202255233023/+csgo_econ_action_preview%20M3392883409794140126A17691028751D153863890392345026"));
                //_weaponListControl.Append(await CreateWeapon(0.20, 0.04, "steam://rungame/730/76561202255233023/+csgo_econ_action_preview%20M4421956023422947223A22915843709D10089908198510185755"));
                //_weaponListControl.Append(await CreateWeapon(0.20, 0.04, "steam://rungame/730/76561202255233023/+csgo_econ_action_preview%20M3391757509892630345A22911757775D622278252943194349"));
                //_weaponListControl.Append(await CreateWeapon(0.20, 0.04, "steam://rungame/730/76561202255233023/+csgo_econ_action_preview%20M3396260657094544509A22898203058D9533775475576218754"));
                //_weaponListControl.Append(await CreateWeapon(0.20, 0.04, "steam://rungame/730/76561202255233023/+csgo_econ_action_preview%20M4425333723144999045A22917249003D14700987699944750468"));
                //_weaponListControl.Append(await CreateWeapon(0.20, 0.04, "steam://rungame/730/76561202255233023/+csgo_econ_action_preview%20M3388379810177071642A22913063945D4783388403712633444"));
                //_weaponListControl.Append(await CreateWeapon(0.20, 0.04, "steam://rungame/730/76561202255233023/+csgo_econ_action_preview%20M3405265773955603400A17963082759D3170620588417471182"));
                //_weaponListControl.Append(await CreateWeapon(0.20, 0.04, "steam://rungame/730/76561202255233023/+csgo_econ_action_preview%20M4096570949107167291A22784928635D7497629181254235143"));
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            new SettingsForm().Show();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            foreach (var weapon in GlobalWeaponsList.Weapons)
            {
                try
                {
                    if (_workersDictionary.ContainsKey(weapon.Label)) continue;
    
                    var worker = CreateWorker(weapon);
                    _workersDictionary.Add(weapon.Label, worker);
                    worker.Show(this);

                    var itemControl = _weaponListControl.GetItemControl(weapon);

                    void WorkerOnFormClosed(object o, FormClosedEventArgs args)
                    {
                        worker.FormClosed -= WorkerOnFormClosed;
                        itemControl.Invoke((MethodInvoker) delegate
                        {
                            itemControl.Enabled = true;
                        });
                    }
                    worker.FormClosed += WorkerOnFormClosed;

                    itemControl.Enabled = false;
                }
                catch (ArgumentException exception)
                {
                    MaterialMessageBox.Show($"Possible reason:\n\n{exception.Message}\n\n{exception}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void MainWindowForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            GlobalWeaponsList.Save();
        }
    }
}
