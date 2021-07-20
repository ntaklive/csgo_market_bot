
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
            this.MaxDelayLabel = new System.Windows.Forms.Label();
            this.MinDelayLabel = new System.Windows.Forms.Label();
            this.MaxDelayTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.StopButton = new MaterialSkin.Controls.MaterialButton();
            this.ManualButton = new MaterialSkin.Controls.MaterialButton();
            this.MinDelayTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.BrowserPanel = new System.Windows.Forms.Panel();
            this.DataLabel = new MaterialSkin.Controls.MaterialLabel();
            this.LoadingPanel = new System.Windows.Forms.Panel();
            this.ThrobberPictureBox = new System.Windows.Forms.PictureBox();
            this.CurrentIpLabel = new MaterialSkin.Controls.MaterialLabel();
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
            this.AutoBuyCheckbox.Location = new System.Drawing.Point(334, 3);
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
            this.MenuPanel.Controls.Add(this.MaxDelayLabel);
            this.MenuPanel.Controls.Add(this.MinDelayLabel);
            this.MenuPanel.Controls.Add(this.MaxDelayTextBox);
            this.MenuPanel.Controls.Add(this.StopButton);
            this.MenuPanel.Controls.Add(this.ManualButton);
            this.MenuPanel.Controls.Add(this.MinDelayTextBox);
            this.MenuPanel.Controls.Add(this.AutoButton);
            this.MenuPanel.Controls.Add(this.AutoBuyCheckbox);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuPanel.Location = new System.Drawing.Point(0, 64);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(468, 44);
            this.MenuPanel.TabIndex = 2;
            // 
            // MaxDelayLabel
            // 
            this.MaxDelayLabel.AutoSize = true;
            this.MaxDelayLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaxDelayLabel.Location = new System.Drawing.Point(248, 27);
            this.MaxDelayLabel.Name = "MaxDelayLabel";
            this.MaxDelayLabel.Size = new System.Drawing.Size(30, 13);
            this.MaxDelayLabel.TabIndex = 16;
            this.MaxDelayLabel.Text = "max:";
            // 
            // MinDelayLabel
            // 
            this.MinDelayLabel.AutoSize = true;
            this.MinDelayLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinDelayLabel.Location = new System.Drawing.Point(165, 26);
            this.MinDelayLabel.Name = "MinDelayLabel";
            this.MinDelayLabel.Size = new System.Drawing.Size(29, 13);
            this.MinDelayLabel.TabIndex = 15;
            this.MinDelayLabel.Text = "min:";
            // 
            // MaxDelayTextBox
            // 
            this.MaxDelayTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MaxDelayTextBox.Depth = 0;
            this.MaxDelayTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MaxDelayTextBox.Hint = "ms";
            this.MaxDelayTextBox.LeadingIcon = null;
            this.MaxDelayTextBox.Location = new System.Drawing.Point(255, 4);
            this.MaxDelayTextBox.MaxLength = 50;
            this.MaxDelayTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.MaxDelayTextBox.Multiline = false;
            this.MaxDelayTextBox.Name = "MaxDelayTextBox";
            this.MaxDelayTextBox.Size = new System.Drawing.Size(74, 36);
            this.MaxDelayTextBox.TabIndex = 17;
            this.MaxDelayTextBox.Text = "";
            this.MaxDelayTextBox.TrailingIcon = null;
            this.MaxDelayTextBox.UseTallSize = false;
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
            // MinDelayTextBox
            // 
            this.MinDelayTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MinDelayTextBox.Depth = 0;
            this.MinDelayTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MinDelayTextBox.Hint = "ms";
            this.MinDelayTextBox.LeadingIcon = null;
            this.MinDelayTextBox.Location = new System.Drawing.Point(171, 4);
            this.MinDelayTextBox.MaxLength = 50;
            this.MinDelayTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.MinDelayTextBox.Multiline = false;
            this.MinDelayTextBox.Name = "MinDelayTextBox";
            this.MinDelayTextBox.Size = new System.Drawing.Size(74, 36);
            this.MinDelayTextBox.TabIndex = 14;
            this.MinDelayTextBox.Text = "";
            this.MinDelayTextBox.TrailingIcon = null;
            this.MinDelayTextBox.UseTallSize = false;
            // 
            // BrowserPanel
            // 
            this.BrowserPanel.Controls.Add(this.DataLabel);
            this.BrowserPanel.Controls.Add(this.LoadingPanel);
            this.BrowserPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
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
            // LoadingPanel
            // 
            this.LoadingPanel.Controls.Add(this.ThrobberPictureBox);
            this.LoadingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoadingPanel.Location = new System.Drawing.Point(0, 0);
            this.LoadingPanel.Margin = new System.Windows.Forms.Padding(0);
            this.LoadingPanel.Name = "LoadingPanel";
            this.LoadingPanel.Size = new System.Drawing.Size(468, 441);
            this.LoadingPanel.TabIndex = 5;
            // 
            // ThrobberPictureBox
            // 
            this.ThrobberPictureBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.ThrobberPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ThrobberPictureBox.Image = global::FloatTool.Properties.Resources.throbber;
            this.ThrobberPictureBox.Location = new System.Drawing.Point(0, 0);
            this.ThrobberPictureBox.Name = "ThrobberPictureBox";
            this.ThrobberPictureBox.Size = new System.Drawing.Size(468, 441);
            this.ThrobberPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ThrobberPictureBox.TabIndex = 0;
            this.ThrobberPictureBox.TabStop = false;
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
        private MaterialSkin.Controls.MaterialButton StopButton;
        private MaterialSkin.Controls.MaterialLabel CurrentIpLabel;
        private System.Windows.Forms.Panel LoadingPanel;
        private System.Windows.Forms.PictureBox ThrobberPictureBox;
        private MaterialSkin.Controls.MaterialLabel DataLabel;
        private System.Windows.Forms.PictureBox ProxyCheckThrobberImageBox;
        private MaterialSkin.Controls.MaterialTextBox MaxDelayTextBox;
        private System.Windows.Forms.Label MaxDelayLabel;
        private MaterialSkin.Controls.MaterialTextBox MinDelayTextBox;
        private System.Windows.Forms.Label MinDelayLabel;
    }
}