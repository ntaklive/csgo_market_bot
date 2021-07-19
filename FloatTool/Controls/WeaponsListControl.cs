using System;
using System.Windows.Forms;
using FloatTool.Models;

namespace FloatTool.Controls
{
    public partial class WeaponsListControl : UserControl
    {
        public WeaponsListControl()
        {
            InitializeComponent();
        }

        public void Append(Weapon weapon)
        {
            var control = new WeaponsListItemControl(weapon) { Dock = DockStyle.Top };
            Controls.Add(control);
        }

        public WeaponsListItemControl GetItemControl(Weapon weapon)
        {
            foreach (var control in Controls)
            {
                if (control is WeaponsListItemControl weaponControl && weaponControl.Weapon == weapon)
                {
                    return weaponControl;
                }
            }

            throw new ArgumentException("Weapon not found");
        }
    }
}

