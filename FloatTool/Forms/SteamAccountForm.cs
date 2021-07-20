using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using MaterialSkin.Controls;

namespace FloatTool.Forms
{
    public partial class SteamAccountForm : MaterialForm
    {
        private readonly ChromiumWebBrowser Browser;

        public SteamAccountForm()
        {
            InitializeComponent();

            const string url = "https://steamcommunity.com/login";
            Browser = new ChromiumWebBrowser(url)
            {
                BrowserSettings =
                {
                    ApplicationCache = CefState.Enabled
                },
                Margin = Padding.Empty
            };
            
            Controls.Add(Browser);
        }
    }
}
