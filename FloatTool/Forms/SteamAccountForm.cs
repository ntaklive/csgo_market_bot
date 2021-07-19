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

            Browser = new ChromiumWebBrowser("https://steamcommunity.com/login")
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
