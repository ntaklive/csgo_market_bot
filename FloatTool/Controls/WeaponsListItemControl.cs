using System;
using System.Globalization;
using System.Windows.Forms;
using FloatTool.Models;
using FloatTool.Tools;
using MaterialSkin.Controls;

namespace FloatTool.Controls
{
    public partial class WeaponsListItemControl : UserControl
    {
        public Weapon Weapon { get; }

        public WeaponsListItemControl(Weapon weapon)
        {
            Weapon = weapon;

            InitializeComponent();
        }

        private void WeaponsListItemControl_Load(object sender, EventArgs e)
        {
            // Control settings
            Panel.BackColor = Weapon.RarityColor;
            ItemLabel.Text = Weapon.Label;
            FloatTextBox.Text = Weapon.Float.ToString(CultureInfo.InvariantCulture);
            PriceTextBox.Text = Weapon.Price.ToString(CultureInfo.InvariantCulture);
            Image.Image = GlobalImagesCache.Get(Weapon.Label);
            // *

            // Events subscribe
            void DeleteButtonOnClick(object o, EventArgs eventArgs)
            {
                DeleteButton.Click -= DeleteButtonOnClick;
                PriceTextBox.TextChanged -= PriceTextBoxOnTextChanged;
                FloatTextBox.TextChanged -= FloatTextBoxOnTextChanged;

                Parent.Controls.Remove(this);
                Dispose(true);

                GlobalWeaponsList.Weapons.Remove(Weapon);
                GlobalWeaponsList.Save();
            }
            DeleteButton.Click +=
                DeleteButtonOnClick;

            void FloatTextBoxOnTextChanged(object o, EventArgs eventArgs)
            {
                try
                {
                    Weapon.Float = ParseTool.ParseFloat(FloatTextBox.Text);
                }
                catch (Exception exception)
                {
                    MaterialMessageBox.Show($"Possible reason:\n\n{exception.Message}\n\n{exception}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                GlobalWeaponsList.Save();
            }
            FloatTextBox.TextChanged += FloatTextBoxOnTextChanged;

            void PriceTextBoxOnTextChanged(object o, EventArgs eventArgs)
            {
                try
                {
                    Weapon.Price = ParseTool.ParsePrice(PriceTextBox.Text);
                }
                catch (Exception exception)
                {
                    MaterialMessageBox.Show($"Possible reason:\n\n{exception.Message}\n\n{exception}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                GlobalWeaponsList.Save();
            }
            PriceTextBox.TextChanged += PriceTextBoxOnTextChanged;
            // *
        }
    }
}
