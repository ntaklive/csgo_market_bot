
namespace FloatTool.Forms
{
    partial class MainWindowForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindowForm));
            this.AddItemButton = new MaterialSkin.Controls.MaterialButton();
            this.FloatTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.LinkTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.WeaponsListPanel = new System.Windows.Forms.Panel();
            this.PriceTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.SettingsButton = new MaterialSkin.Controls.MaterialButton();
            this.StartButton = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // AddItemButton
            // 
            this.AddItemButton.AutoSize = false;
            this.AddItemButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddItemButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.AddItemButton.Depth = 0;
            this.AddItemButton.FlatAppearance.BorderSize = 0;
            this.AddItemButton.HighEmphasis = true;
            this.AddItemButton.Icon = null;
            this.AddItemButton.Location = new System.Drawing.Point(7, 356);
            this.AddItemButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AddItemButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(58, 47);
            this.AddItemButton.TabIndex = 1;
            this.AddItemButton.Text = "Add";
            this.AddItemButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AddItemButton.UseAccentColor = false;
            this.AddItemButton.UseVisualStyleBackColor = true;
            this.AddItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // FloatTextBox
            // 
            this.FloatTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FloatTextBox.Depth = 0;
            this.FloatTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FloatTextBox.Hint = "Max Float";
            this.FloatTextBox.LeadingIcon = null;
            this.FloatTextBox.Location = new System.Drawing.Point(72, 356);
            this.FloatTextBox.MaxLength = 50;
            this.FloatTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.FloatTextBox.Multiline = false;
            this.FloatTextBox.Name = "FloatTextBox";
            this.FloatTextBox.Size = new System.Drawing.Size(114, 50);
            this.FloatTextBox.TabIndex = 2;
            this.FloatTextBox.Text = "";
            this.FloatTextBox.TrailingIcon = null;
            // 
            // LinkTextBox
            // 
            this.LinkTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LinkTextBox.Depth = 0;
            this.LinkTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LinkTextBox.Hint = "Link";
            this.LinkTextBox.LeadingIcon = null;
            this.LinkTextBox.Location = new System.Drawing.Point(321, 356);
            this.LinkTextBox.MaxLength = 500;
            this.LinkTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.LinkTextBox.Multiline = false;
            this.LinkTextBox.Name = "LinkTextBox";
            this.LinkTextBox.Size = new System.Drawing.Size(223, 50);
            this.LinkTextBox.TabIndex = 3;
            this.LinkTextBox.Text = "";
            this.LinkTextBox.TrailingIcon = null;
            // 
            // WeaponsListPanel
            // 
            this.WeaponsListPanel.AutoScroll = true;
            this.WeaponsListPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.WeaponsListPanel.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.WeaponsListPanel.Location = new System.Drawing.Point(7, 70);
            this.WeaponsListPanel.Name = "WeaponsListPanel";
            this.WeaponsListPanel.Size = new System.Drawing.Size(537, 280);
            this.WeaponsListPanel.TabIndex = 4;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PriceTextBox.Depth = 0;
            this.PriceTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PriceTextBox.Hint = "Max Price";
            this.PriceTextBox.LeadingIcon = null;
            this.PriceTextBox.Location = new System.Drawing.Point(192, 356);
            this.PriceTextBox.MaxLength = 50;
            this.PriceTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.PriceTextBox.Multiline = false;
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(123, 50);
            this.PriceTextBox.TabIndex = 7;
            this.PriceTextBox.Text = "";
            this.PriceTextBox.TrailingIcon = null;
            // 
            // SettingsButton
            // 
            this.SettingsButton.AutoSize = false;
            this.SettingsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SettingsButton.BackColor = System.Drawing.SystemColors.Control;
            this.SettingsButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.SettingsButton.Depth = 0;
            this.SettingsButton.DrawShadows = false;
            this.SettingsButton.FlatAppearance.BorderSize = 0;
            this.SettingsButton.HighEmphasis = false;
            this.SettingsButton.Icon = null;
            this.SettingsButton.Location = new System.Drawing.Point(345, 34);
            this.SettingsButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SettingsButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(84, 21);
            this.SettingsButton.TabIndex = 12;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.SettingsButton.UseAccentColor = false;
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.AutoSize = false;
            this.StartButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.StartButton.BackColor = System.Drawing.SystemColors.Control;
            this.StartButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.StartButton.Depth = 0;
            this.StartButton.DrawShadows = false;
            this.StartButton.FlatAppearance.BorderSize = 0;
            this.StartButton.HighEmphasis = false;
            this.StartButton.Icon = null;
            this.StartButton.Location = new System.Drawing.Point(183, 34);
            this.StartButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.StartButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(157, 21);
            this.StartButton.TabIndex = 11;
            this.StartButton.Text = "Create Workers";
            this.StartButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.StartButton.UseAccentColor = false;
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // MainWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 412);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.WeaponsListPanel);
            this.Controls.Add(this.LinkTextBox);
            this.Controls.Add(this.FloatTextBox);
            this.Controls.Add(this.AddItemButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindowForm";
            this.Sizable = false;
            this.Text = "CS:GO Float Tool";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindowForm_FormClosed);
            this.Load += new System.EventHandler(this.MainWindowForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton AddItemButton;
        private MaterialSkin.Controls.MaterialTextBox FloatTextBox;
        private MaterialSkin.Controls.MaterialTextBox LinkTextBox;
        private System.Windows.Forms.Panel WeaponsListPanel;
        private MaterialSkin.Controls.MaterialTextBox PriceTextBox;
        private MaterialSkin.Controls.MaterialButton SettingsButton;
        private MaterialSkin.Controls.MaterialButton StartButton;
    }
}