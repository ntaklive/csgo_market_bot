using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FloatTool.Models;
using MaterialSkin.Controls;

namespace FloatTool.Controls
{
    public partial class ProxyListControl : UserControl
    {
        public ProxyListControl()
        {
            InitializeComponent();
        }

        private readonly IDictionary<string, Proxy> _proxyDictionary = new Dictionary<string, Proxy>();

        public void AddItem(Proxy proxy)
        {
            var control = new ProxyListItemControl { Dock = DockStyle.Top };
            var ipTextLabel = (MaterialLabel)control.Controls["IpTextLabel"];
            var deleteButton = (MaterialButton)control.Controls["DeleteButton"];

            // <-- Control settings
            ipTextLabel.Text = proxy.ToString();
            // --> *

            // <-- Event subscribe
            void DeleteButtonOnClick(object o, EventArgs eventArgs)
            {
                _proxyDictionary.Remove(proxy.ToString());
                Controls.Remove(control);

                deleteButton.Click -= DeleteButtonOnClick;
            }

            deleteButton.Click +=
                DeleteButtonOnClick;
            // --> *

            _proxyDictionary.Add(proxy.ToString(), proxy);
            Controls.Add(control);
        }

        public List<Proxy> Items => _proxyDictionary.Values.ToList();

        public void Clear()
        {
            _proxyDictionary.Clear();
        }
    }
}
