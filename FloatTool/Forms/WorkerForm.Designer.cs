
namespace FloatTool.Forms
{
    partial class WorkerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkerForm));
            this.AutoButton = new MaterialSkin.Controls.MaterialButton();
            this.AutoBuyCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.StopButton = new MaterialSkin.Controls.MaterialButton();
            this.DelayTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.ManualButton = new MaterialSkin.Controls.MaterialButton();
            this.BrowserPanel = new System.Windows.Forms.Panel();
            this.DataLabel = new MaterialSkin.Controls.MaterialLabel();
            this.CurrentIpLabel = new MaterialSkin.Controls.MaterialLabel();
            this.LoadingPanel = new System.Windows.Forms.Panel();
            this.ThrobberPictureBox = new System.Windows.Forms.PictureBox();
            this.ProxyCheckThrobberImageBox = new System.Windows.Forms.PictureBox();
            this.MenuPanel.SuspendLayout();
            this.BrowserPanel.SuspendLayout();
            this.LoadingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ThrobberPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProxyCheckThrobberImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // AutoButton
            // 
            this.AutoButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.AutoButton.Depth = 0;
            this.AutoButton.HighEmphasis = true;
            this.AutoButton.Icon = null;
            this.AutoButton.Location = new System.Drawing.Point(94, 3);
            this.AutoButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AutoButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AutoButton.Name = "AutoButton";
            this.AutoButton.Size = new System.Drawing.Size(64, 36);
            this.AutoButton.TabIndex = 0;
            this.AutoButton.Text = "Auto";
            this.AutoButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AutoButton.UseAccentColor = false;
            this.AutoButton.UseVisualStyleBackColor = true;
            this.AutoButton.Click += new System.EventHandler(this.AutoButton_Click);
            // 
            // AutoBuyCheckbox
            // 
            this.AutoBuyCheckbox.AutoSize = true;
            this.AutoBuyCheckbox.Depth = 0;
            this.AutoBuyCheckbox.Location = new System.Drawing.Point(268, 3);
            this.AutoBuyCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.AutoBuyCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.AutoBuyCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.AutoBuyCheckbox.Name = "AutoBuyCheckbox";
            this.AutoBuyCheckbox.Ripple = true;
            this.AutoBuyCheckbox.Size = new System.Drawing.Size(103, 37);
            this.AutoBuyCheckbox.TabIndex = 1;
            this.AutoBuyCheckbox.Text = "Auto Buy ";
            this.AutoBuyCheckbox.UseVisualStyleBackColor = true;
            this.AutoBuyCheckbox.CheckedChanged += new System.EventHandler(this.AutoBuyCheckbox_CheckedChanged);
            // 
            // MenuPanel
            // 
            this.MenuPanel.Controls.Add(this.StopButton);
            this.MenuPanel.Controls.Add(this.DelayTextBox);
            this.MenuPanel.Controls.Add(this.ManualButton);
            this.MenuPanel.Controls.Add(this.AutoButton);
            this.MenuPanel.Controls.Add(this.AutoBuyCheckbox);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuPanel.Location = new System.Drawing.Point(0, 64);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(468, 44);
            this.MenuPanel.TabIndex = 2;
            // 
            // StopButton
            // 
            this.StopButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.StopButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.StopButton.Depth = 0;
            this.StopButton.HighEmphasis = true;
            this.StopButton.Icon = null;
            this.StopButton.Location = new System.Drawing.Point(94, 3);
            this.StopButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.StopButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(64, 36);
            this.StopButton.TabIndex = 5;
            this.StopButton.Text = "Stop";
            this.StopButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.StopButton.UseAccentColor = false;
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Visible = false;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // DelayTextBox
            // 
            this.DelayTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DelayTextBox.Depth = 0;
            this.DelayTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DelayTextBox.Hint = "Delay";
            this.DelayTextBox.LeadingIcon = null;
            this.DelayTextBox.Location = new System.Drawing.Point(165, 3);
            this.DelayTextBox.MaxLength = 50;
            this.DelayTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.DelayTextBox.Multiline = false;
            this.DelayTextBox.Name = "DelayTextBox";
            this.DelayTextBox.Size = new System.Drawing.Size(100, 36);
            this.DelayTextBox.TabIndex = 4;
            this.DelayTextBox.Text = "";
            this.DelayTextBox.TrailingIcon = null;
            this.DelayTextBox.UseTallSize = false;
            this.DelayTextBox.TextChanged += new System.EventHandler(this.DelayTextBox_TextChanged);
            // 
            // ManualButton
            // 
            this.ManualButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ManualButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ManualButton.Depth = 0;
            this.ManualButton.HighEmphasis = true;
            this.ManualButton.Icon = null;
            this.ManualButton.Location = new System.Drawing.Point(4, 3);
            this.ManualButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ManualButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ManualButton.Name = "ManualButton";
            this.ManualButton.Size = new System.Drawing.Size(82, 36);
            this.ManualButton.TabIndex = 3;
            this.ManualButton.Text = "Manual";
            this.ManualButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ManualButton.UseAccentColor = false;
            this.ManualButton.UseVisualStyleBackColor = true;
            this.ManualButton.Click += new System.EventHandler(this.ManualButton_Click);
            // 
            // BrowserPanel
            // 
            this.BrowserPanel.Controls.Add(this.DataLabel);
            this.BrowserPanel.Location = new System.Drawing.Point(0, 107);
            this.BrowserPanel.Name = "BrowserPanel";
            this.BrowserPanel.Size = new System.Drawing.Size(468, 441);
            this.BrowserPanel.TabIndex = 3;
            // 
            // DataLabel
            // 
            this.DataLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.DataLabel.Depth = 0;
            this.DataLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DataLabel.Location = new System.Drawing.Point(0, 464);
            this.DataLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.DataLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.DataLabel.Name = "DataLabel";
            this.DataLabel.Size = new System.Drawing.Size(175, 20);
            this.DataLabel.TabIndex = 7;
            this.DataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CurrentIpLabel
            // 
            this.CurrentIpLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CurrentIpLabel.Depth = 0;
            this.CurrentIpLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CurrentIpLabel.Location = new System.Drawing.Point(23, 0);
            this.CurrentIpLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CurrentIpLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.CurrentIpLabel.Name = "CurrentIpLabel";
            this.CurrentIpLabel.Size = new System.Drawing.Size(208, 23);
            this.CurrentIpLabel.TabIndex = 4;
            this.CurrentIpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CurrentIpLabel.Visible = false;
            // 
            // LoadingPanel
            // 
            this.LoadingPanel.Controls.Add(this.ThrobberPictureBox);
            this.LoadingPanel.Location = new System.Drawing.Point(0, 64);
            this.LoadingPanel.Margin = new System.Windows.Forms.Padding(0);
            this.LoadingPanel.Name = "LoadingPanel";
            this.LoadingPanel.Size = new System.Drawing.Size(468, 484);
            this.LoadingPanel.TabIndex = 5;
            // 
            // ThrobberPictureBox
            // 
            this.ThrobberPictureBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.ThrobberPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ThrobberPictureBox.Image = global::FloatTool.Properties.Resources.throbber;
            this.ThrobberPictureBox.Location = new System.Drawing.Point(0, 0);
            this.ThrobberPictureBox.Name = "ThrobberPictureBox";
            this.ThrobberPictureBox.Size = new System.Drawing.Size(468, 484);
            this.ThrobberPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ThrobberPictureBox.TabIndex = 0;
            this.ThrobberPictureBox.TabStop = false;
            // 
            // ProxyCheckThrobberImageBox
            // 
            this.ProxyCheckThrobberImageBox.Image = global::FloatTool.Properties.Resources.throbber;
            this.ProxyCheckThrobberImageBox.Location = new System.Drawing.Point(0, 0);
            this.ProxyCheckThrobberImageBox.Name = "ProxyCheckThrobberImageBox";
            this.ProxyCheckThrobberImageBox.Size = new System.Drawing.Size(23, 23);
            this.ProxyCheckThrobberImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProxyCheckThrobberImageBox.TabIndex = 6;
            this.ProxyCheckThrobberImageBox.TabStop = false;
            this.ProxyCheckThrobberImageBox.Visible = false;
            // 
            // WorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 548);
            this.Controls.Add(this.ProxyCheckThrobberImageBox);
            this.Controls.Add(this.LoadingPanel);
            this.Controls.Add(this.CurrentIpLabel);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.BrowserPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WorkerForm";
            this.Padding = new System.Windows.Forms.Padding(0, 64, 0, 0);
            this.Sizable = false;
            this.Text = "Worker";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WorkerForm_FormClosed);
            this.Load += new System.EventHandler(this.WorkerForm_Load);
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            this.BrowserPanel.ResumeLayout(false);
            this.LoadingPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ThrobberPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProxyCheckThrobberImageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton AutoButton;
        private MaterialSkin.Controls.MaterialCheckbox AutoBuyCheckbox;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Panel BrowserPanel;
        private MaterialSkin.Controls.MaterialButton ManualButton;
        private MaterialSkin.Controls.MaterialTextBox DelayTextBox;
        private MaterialSkin.Controls.MaterialButton StopButton;
        private MaterialSkin.Controls.MaterialLabel CurrentIpLabel;
        private System.Windows.Forms.Panel LoadingPanel;
        private System.Windows.Forms.PictureBox ThrobberPictureBox;
        private MaterialSkin.Controls.MaterialLabel DataLabel;
        private System.Windows.Forms.PictureBox ProxyCheckThrobberImageBox;
    }
}