
namespace FloatTool.Forms
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.ParserSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.ParserScriptSettingsFilterLabel = new MaterialSkin.Controls.MaterialLabel();
            this.ParserScriptSettingsFilterTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.ParserScriptCountryLabel = new MaterialSkin.Controls.MaterialLabel();
            this.ParserScriptCountryTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.ParserScriptLanguageLabel = new MaterialSkin.Controls.MaterialLabel();
            this.ParserScriptCurrencyTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.ParserScriptCurrencyLabel = new MaterialSkin.Controls.MaterialLabel();
            this.ParserScriptLanguageTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.ParserScriptSettingsCountLabel = new MaterialSkin.Controls.MaterialLabel();
            this.ParserScriptCountTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.ApplyOperationButton = new MaterialSkin.Controls.MaterialButton();
            this.CancelOperationButton = new MaterialSkin.Controls.MaterialButton();
            this.BuyScriptSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.BuyScriptCloseWindowLabel = new MaterialSkin.Controls.MaterialLabel();
            this.BuyScriptCloseWindowTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.BuyScriptSettingsDelayBeforeLabel = new MaterialSkin.Controls.MaterialLabel();
            this.BuyScriptPurchaseLabel = new MaterialSkin.Controls.MaterialLabel();
            this.BuyScriptAgreeTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.BuyScriptAgreeLabel = new MaterialSkin.Controls.MaterialLabel();
            this.BuyScriptPurchaseTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.BuyScriptBuyNowLabel = new MaterialSkin.Controls.MaterialLabel();
            this.BuyScriptBuyNowTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.JunkRemoverScriptSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.JunkRemoverScriptSettingsEnabledCheckBox = new MaterialSkin.Controls.MaterialCheckbox();
            this.ProxySettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.ProxySettingsProxyListPanel = new System.Windows.Forms.Panel();
            this.ProxySettingsProxyListFromFileButton = new MaterialSkin.Controls.MaterialButton();
            this.ProxyEnabledCheckBox = new MaterialSkin.Controls.MaterialCheckbox();
            this.WorkerDefaultSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.WorkerDefaultSettingsDelayLabel = new MaterialSkin.Controls.MaterialLabel();
            this.WorkerDefaultSettingsDelayTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.WorkerDefaultSettingsAutoBuyCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.ProxySettingsProxyListFileOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.LoginButton = new MaterialSkin.Controls.MaterialButton();
            this.ParserSettingsGroupBox.SuspendLayout();
            this.BuyScriptSettingsGroupBox.SuspendLayout();
            this.JunkRemoverScriptSettingsGroupBox.SuspendLayout();
            this.ProxySettingsGroupBox.SuspendLayout();
            this.WorkerDefaultSettingsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ParserSettingsGroupBox
            // 
            this.ParserSettingsGroupBox.Controls.Add(this.ParserScriptSettingsFilterLabel);
            this.ParserSettingsGroupBox.Controls.Add(this.ParserScriptSettingsFilterTextBox);
            this.ParserSettingsGroupBox.Controls.Add(this.ParserScriptCountryLabel);
            this.ParserSettingsGroupBox.Controls.Add(this.ParserScriptCountryTextBox);
            this.ParserSettingsGroupBox.Controls.Add(this.ParserScriptLanguageLabel);
            this.ParserSettingsGroupBox.Controls.Add(this.ParserScriptCurrencyTextBox);
            this.ParserSettingsGroupBox.Controls.Add(this.ParserScriptCurrencyLabel);
            this.ParserSettingsGroupBox.Controls.Add(this.ParserScriptLanguageTextBox);
            this.ParserSettingsGroupBox.Controls.Add(this.ParserScriptSettingsCountLabel);
            this.ParserSettingsGroupBox.Controls.Add(this.ParserScriptCountTextBox);
            this.ParserSettingsGroupBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParserSettingsGroupBox.Location = new System.Drawing.Point(6, 67);
            this.ParserSettingsGroupBox.Name = "ParserSettingsGroupBox";
            this.ParserSettingsGroupBox.Size = new System.Drawing.Size(223, 238);
            this.ParserSettingsGroupBox.TabIndex = 0;
            this.ParserSettingsGroupBox.TabStop = false;
            this.ParserSettingsGroupBox.Text = "Parser Script Settings";
            // 
            // ParserScriptSettingsFilterLabel
            // 
            this.ParserScriptSettingsFilterLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ParserScriptSettingsFilterLabel.BackColor = System.Drawing.SystemColors.Control;
            this.ParserScriptSettingsFilterLabel.Depth = 0;
            this.ParserScriptSettingsFilterLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ParserScriptSettingsFilterLabel.HighEmphasis = true;
            this.ParserScriptSettingsFilterLabel.Location = new System.Drawing.Point(5, 192);
            this.ParserScriptSettingsFilterLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.ParserScriptSettingsFilterLabel.Name = "ParserScriptSettingsFilterLabel";
            this.ParserScriptSettingsFilterLabel.Size = new System.Drawing.Size(106, 36);
            this.ParserScriptSettingsFilterLabel.TabIndex = 9;
            this.ParserScriptSettingsFilterLabel.Text = "Filter:";
            this.ParserScriptSettingsFilterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ParserScriptSettingsFilterTextBox
            // 
            this.ParserScriptSettingsFilterTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ParserScriptSettingsFilterTextBox.Depth = 0;
            this.ParserScriptSettingsFilterTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ParserScriptSettingsFilterTextBox.Hint = "sticker";
            this.ParserScriptSettingsFilterTextBox.LeadingIcon = null;
            this.ParserScriptSettingsFilterTextBox.Location = new System.Drawing.Point(117, 192);
            this.ParserScriptSettingsFilterTextBox.MaxLength = 50;
            this.ParserScriptSettingsFilterTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.ParserScriptSettingsFilterTextBox.Multiline = false;
            this.ParserScriptSettingsFilterTextBox.Name = "ParserScriptSettingsFilterTextBox";
            this.ParserScriptSettingsFilterTextBox.Size = new System.Drawing.Size(100, 36);
            this.ParserScriptSettingsFilterTextBox.TabIndex = 8;
            this.ParserScriptSettingsFilterTextBox.Text = "";
            this.ParserScriptSettingsFilterTextBox.TrailingIcon = null;
            this.ParserScriptSettingsFilterTextBox.UseTallSize = false;
            // 
            // ParserScriptCountryLabel
            // 
            this.ParserScriptCountryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ParserScriptCountryLabel.BackColor = System.Drawing.SystemColors.Control;
            this.ParserScriptCountryLabel.Depth = 0;
            this.ParserScriptCountryLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ParserScriptCountryLabel.HighEmphasis = true;
            this.ParserScriptCountryLabel.Location = new System.Drawing.Point(5, 150);
            this.ParserScriptCountryLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.ParserScriptCountryLabel.Name = "ParserScriptCountryLabel";
            this.ParserScriptCountryLabel.Size = new System.Drawing.Size(106, 36);
            this.ParserScriptCountryLabel.TabIndex = 7;
            this.ParserScriptCountryLabel.Text = "Country:";
            this.ParserScriptCountryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ParserScriptCountryTextBox
            // 
            this.ParserScriptCountryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ParserScriptCountryTextBox.Depth = 0;
            this.ParserScriptCountryTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ParserScriptCountryTextBox.Hint = "BY";
            this.ParserScriptCountryTextBox.LeadingIcon = null;
            this.ParserScriptCountryTextBox.Location = new System.Drawing.Point(117, 150);
            this.ParserScriptCountryTextBox.MaxLength = 50;
            this.ParserScriptCountryTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.ParserScriptCountryTextBox.Multiline = false;
            this.ParserScriptCountryTextBox.Name = "ParserScriptCountryTextBox";
            this.ParserScriptCountryTextBox.Size = new System.Drawing.Size(100, 36);
            this.ParserScriptCountryTextBox.TabIndex = 6;
            this.ParserScriptCountryTextBox.Text = "";
            this.ParserScriptCountryTextBox.TrailingIcon = null;
            this.ParserScriptCountryTextBox.UseTallSize = false;
            // 
            // ParserScriptLanguageLabel
            // 
            this.ParserScriptLanguageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ParserScriptLanguageLabel.BackColor = System.Drawing.SystemColors.Control;
            this.ParserScriptLanguageLabel.Depth = 0;
            this.ParserScriptLanguageLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ParserScriptLanguageLabel.HighEmphasis = true;
            this.ParserScriptLanguageLabel.Location = new System.Drawing.Point(5, 108);
            this.ParserScriptLanguageLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.ParserScriptLanguageLabel.Name = "ParserScriptLanguageLabel";
            this.ParserScriptLanguageLabel.Size = new System.Drawing.Size(106, 36);
            this.ParserScriptLanguageLabel.TabIndex = 5;
            this.ParserScriptLanguageLabel.Text = "Language:";
            this.ParserScriptLanguageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ParserScriptCurrencyTextBox
            // 
            this.ParserScriptCurrencyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ParserScriptCurrencyTextBox.Depth = 0;
            this.ParserScriptCurrencyTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ParserScriptCurrencyTextBox.Hint = "0 - 20+";
            this.ParserScriptCurrencyTextBox.LeadingIcon = null;
            this.ParserScriptCurrencyTextBox.Location = new System.Drawing.Point(117, 66);
            this.ParserScriptCurrencyTextBox.MaxLength = 50;
            this.ParserScriptCurrencyTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.ParserScriptCurrencyTextBox.Multiline = false;
            this.ParserScriptCurrencyTextBox.Name = "ParserScriptCurrencyTextBox";
            this.ParserScriptCurrencyTextBox.Size = new System.Drawing.Size(100, 36);
            this.ParserScriptCurrencyTextBox.TabIndex = 4;
            this.ParserScriptCurrencyTextBox.Text = "";
            this.ParserScriptCurrencyTextBox.TrailingIcon = null;
            this.ParserScriptCurrencyTextBox.UseTallSize = false;
            // 
            // ParserScriptCurrencyLabel
            // 
            this.ParserScriptCurrencyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ParserScriptCurrencyLabel.BackColor = System.Drawing.SystemColors.Control;
            this.ParserScriptCurrencyLabel.Depth = 0;
            this.ParserScriptCurrencyLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ParserScriptCurrencyLabel.HighEmphasis = true;
            this.ParserScriptCurrencyLabel.Location = new System.Drawing.Point(5, 66);
            this.ParserScriptCurrencyLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.ParserScriptCurrencyLabel.Name = "ParserScriptCurrencyLabel";
            this.ParserScriptCurrencyLabel.Size = new System.Drawing.Size(106, 36);
            this.ParserScriptCurrencyLabel.TabIndex = 3;
            this.ParserScriptCurrencyLabel.Text = "Currency:";
            this.ParserScriptCurrencyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ParserScriptLanguageTextBox
            // 
            this.ParserScriptLanguageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ParserScriptLanguageTextBox.Depth = 0;
            this.ParserScriptLanguageTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ParserScriptLanguageTextBox.Hint = "russian";
            this.ParserScriptLanguageTextBox.LeadingIcon = null;
            this.ParserScriptLanguageTextBox.Location = new System.Drawing.Point(117, 108);
            this.ParserScriptLanguageTextBox.MaxLength = 50;
            this.ParserScriptLanguageTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.ParserScriptLanguageTextBox.Multiline = false;
            this.ParserScriptLanguageTextBox.Name = "ParserScriptLanguageTextBox";
            this.ParserScriptLanguageTextBox.Size = new System.Drawing.Size(100, 36);
            this.ParserScriptLanguageTextBox.TabIndex = 2;
            this.ParserScriptLanguageTextBox.Text = "";
            this.ParserScriptLanguageTextBox.TrailingIcon = null;
            this.ParserScriptLanguageTextBox.UseTallSize = false;
            // 
            // ParserScriptSettingsCountLabel
            // 
            this.ParserScriptSettingsCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ParserScriptSettingsCountLabel.BackColor = System.Drawing.SystemColors.Control;
            this.ParserScriptSettingsCountLabel.Depth = 0;
            this.ParserScriptSettingsCountLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ParserScriptSettingsCountLabel.HighEmphasis = true;
            this.ParserScriptSettingsCountLabel.Location = new System.Drawing.Point(5, 24);
            this.ParserScriptSettingsCountLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.ParserScriptSettingsCountLabel.Name = "ParserScriptSettingsCountLabel";
            this.ParserScriptSettingsCountLabel.Size = new System.Drawing.Size(106, 36);
            this.ParserScriptSettingsCountLabel.TabIndex = 1;
            this.ParserScriptSettingsCountLabel.Text = "Count:";
            this.ParserScriptSettingsCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ParserScriptCountTextBox
            // 
            this.ParserScriptCountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ParserScriptCountTextBox.Depth = 0;
            this.ParserScriptCountTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ParserScriptCountTextBox.Hint = "10 - 100";
            this.ParserScriptCountTextBox.LeadingIcon = null;
            this.ParserScriptCountTextBox.Location = new System.Drawing.Point(117, 24);
            this.ParserScriptCountTextBox.MaxLength = 50;
            this.ParserScriptCountTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.ParserScriptCountTextBox.Multiline = false;
            this.ParserScriptCountTextBox.Name = "ParserScriptCountTextBox";
            this.ParserScriptCountTextBox.Size = new System.Drawing.Size(100, 36);
            this.ParserScriptCountTextBox.TabIndex = 0;
            this.ParserScriptCountTextBox.Text = "";
            this.ParserScriptCountTextBox.TrailingIcon = null;
            this.ParserScriptCountTextBox.UseTallSize = false;
            // 
            // ApplyOperationButton
            // 
            this.ApplyOperationButton.AutoSize = false;
            this.ApplyOperationButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ApplyOperationButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ApplyOperationButton.Depth = 0;
            this.ApplyOperationButton.HighEmphasis = true;
            this.ApplyOperationButton.Icon = null;
            this.ApplyOperationButton.Location = new System.Drawing.Point(326, 491);
            this.ApplyOperationButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ApplyOperationButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ApplyOperationButton.Name = "ApplyOperationButton";
            this.ApplyOperationButton.Size = new System.Drawing.Size(132, 36);
            this.ApplyOperationButton.TabIndex = 1;
            this.ApplyOperationButton.Text = "Apply";
            this.ApplyOperationButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ApplyOperationButton.UseAccentColor = false;
            this.ApplyOperationButton.UseVisualStyleBackColor = true;
            this.ApplyOperationButton.Click += new System.EventHandler(this.ApplyOperationButton_Click);
            // 
            // CancelOperationButton
            // 
            this.CancelOperationButton.AutoSize = false;
            this.CancelOperationButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelOperationButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.CancelOperationButton.Depth = 0;
            this.CancelOperationButton.HighEmphasis = true;
            this.CancelOperationButton.Icon = null;
            this.CancelOperationButton.Location = new System.Drawing.Point(236, 491);
            this.CancelOperationButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CancelOperationButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CancelOperationButton.Name = "CancelOperationButton";
            this.CancelOperationButton.Size = new System.Drawing.Size(82, 36);
            this.CancelOperationButton.TabIndex = 2;
            this.CancelOperationButton.Text = "Cancel";
            this.CancelOperationButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CancelOperationButton.UseAccentColor = false;
            this.CancelOperationButton.UseVisualStyleBackColor = true;
            this.CancelOperationButton.Click += new System.EventHandler(this.CancelOperationButton_Click);
            // 
            // BuyScriptSettingsGroupBox
            // 
            this.BuyScriptSettingsGroupBox.Controls.Add(this.BuyScriptCloseWindowLabel);
            this.BuyScriptSettingsGroupBox.Controls.Add(this.BuyScriptCloseWindowTextBox);
            this.BuyScriptSettingsGroupBox.Controls.Add(this.BuyScriptSettingsDelayBeforeLabel);
            this.BuyScriptSettingsGroupBox.Controls.Add(this.BuyScriptPurchaseLabel);
            this.BuyScriptSettingsGroupBox.Controls.Add(this.BuyScriptAgreeTextBox);
            this.BuyScriptSettingsGroupBox.Controls.Add(this.BuyScriptAgreeLabel);
            this.BuyScriptSettingsGroupBox.Controls.Add(this.BuyScriptPurchaseTextBox);
            this.BuyScriptSettingsGroupBox.Controls.Add(this.BuyScriptBuyNowLabel);
            this.BuyScriptSettingsGroupBox.Controls.Add(this.BuyScriptBuyNowTextBox);
            this.BuyScriptSettingsGroupBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuyScriptSettingsGroupBox.Location = new System.Drawing.Point(6, 311);
            this.BuyScriptSettingsGroupBox.Name = "BuyScriptSettingsGroupBox";
            this.BuyScriptSettingsGroupBox.Size = new System.Drawing.Size(223, 217);
            this.BuyScriptSettingsGroupBox.TabIndex = 8;
            this.BuyScriptSettingsGroupBox.TabStop = false;
            this.BuyScriptSettingsGroupBox.Text = "Buy Script Settings";
            // 
            // BuyScriptCloseWindowLabel
            // 
            this.BuyScriptCloseWindowLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BuyScriptCloseWindowLabel.BackColor = System.Drawing.SystemColors.Control;
            this.BuyScriptCloseWindowLabel.Depth = 0;
            this.BuyScriptCloseWindowLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BuyScriptCloseWindowLabel.HighEmphasis = true;
            this.BuyScriptCloseWindowLabel.Location = new System.Drawing.Point(6, 173);
            this.BuyScriptCloseWindowLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.BuyScriptCloseWindowLabel.Name = "BuyScriptCloseWindowLabel";
            this.BuyScriptCloseWindowLabel.Size = new System.Drawing.Size(107, 36);
            this.BuyScriptCloseWindowLabel.TabIndex = 8;
            this.BuyScriptCloseWindowLabel.Text = "\'Close Window\' Click";
            this.BuyScriptCloseWindowLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BuyScriptCloseWindowTextBox
            // 
            this.BuyScriptCloseWindowTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BuyScriptCloseWindowTextBox.Depth = 0;
            this.BuyScriptCloseWindowTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BuyScriptCloseWindowTextBox.Hint = "ms";
            this.BuyScriptCloseWindowTextBox.LeadingIcon = null;
            this.BuyScriptCloseWindowTextBox.Location = new System.Drawing.Point(119, 173);
            this.BuyScriptCloseWindowTextBox.MaxLength = 50;
            this.BuyScriptCloseWindowTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.BuyScriptCloseWindowTextBox.Multiline = false;
            this.BuyScriptCloseWindowTextBox.Name = "BuyScriptCloseWindowTextBox";
            this.BuyScriptCloseWindowTextBox.Size = new System.Drawing.Size(98, 36);
            this.BuyScriptCloseWindowTextBox.TabIndex = 7;
            this.BuyScriptCloseWindowTextBox.Text = "";
            this.BuyScriptCloseWindowTextBox.TrailingIcon = null;
            this.BuyScriptCloseWindowTextBox.UseTallSize = false;
            // 
            // BuyScriptSettingsDelayBeforeLabel
            // 
            this.BuyScriptSettingsDelayBeforeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BuyScriptSettingsDelayBeforeLabel.Depth = 0;
            this.BuyScriptSettingsDelayBeforeLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BuyScriptSettingsDelayBeforeLabel.Location = new System.Drawing.Point(6, 21);
            this.BuyScriptSettingsDelayBeforeLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.BuyScriptSettingsDelayBeforeLabel.Name = "BuyScriptSettingsDelayBeforeLabel";
            this.BuyScriptSettingsDelayBeforeLabel.Size = new System.Drawing.Size(211, 23);
            this.BuyScriptSettingsDelayBeforeLabel.TabIndex = 6;
            this.BuyScriptSettingsDelayBeforeLabel.Text = "Delay Before:";
            this.BuyScriptSettingsDelayBeforeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BuyScriptPurchaseLabel
            // 
            this.BuyScriptPurchaseLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BuyScriptPurchaseLabel.BackColor = System.Drawing.SystemColors.Control;
            this.BuyScriptPurchaseLabel.Depth = 0;
            this.BuyScriptPurchaseLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BuyScriptPurchaseLabel.HighEmphasis = true;
            this.BuyScriptPurchaseLabel.Location = new System.Drawing.Point(6, 131);
            this.BuyScriptPurchaseLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.BuyScriptPurchaseLabel.Name = "BuyScriptPurchaseLabel";
            this.BuyScriptPurchaseLabel.Size = new System.Drawing.Size(107, 36);
            this.BuyScriptPurchaseLabel.TabIndex = 5;
            this.BuyScriptPurchaseLabel.Text = "\'Purchase\' Click";
            this.BuyScriptPurchaseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BuyScriptAgreeTextBox
            // 
            this.BuyScriptAgreeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BuyScriptAgreeTextBox.Depth = 0;
            this.BuyScriptAgreeTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BuyScriptAgreeTextBox.Hint = "ms";
            this.BuyScriptAgreeTextBox.LeadingIcon = null;
            this.BuyScriptAgreeTextBox.Location = new System.Drawing.Point(119, 89);
            this.BuyScriptAgreeTextBox.MaxLength = 50;
            this.BuyScriptAgreeTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.BuyScriptAgreeTextBox.Multiline = false;
            this.BuyScriptAgreeTextBox.Name = "BuyScriptAgreeTextBox";
            this.BuyScriptAgreeTextBox.Size = new System.Drawing.Size(98, 36);
            this.BuyScriptAgreeTextBox.TabIndex = 4;
            this.BuyScriptAgreeTextBox.Text = "";
            this.BuyScriptAgreeTextBox.TrailingIcon = null;
            this.BuyScriptAgreeTextBox.UseTallSize = false;
            // 
            // BuyScriptAgreeLabel
            // 
            this.BuyScriptAgreeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BuyScriptAgreeLabel.BackColor = System.Drawing.SystemColors.Control;
            this.BuyScriptAgreeLabel.Depth = 0;
            this.BuyScriptAgreeLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BuyScriptAgreeLabel.HighEmphasis = true;
            this.BuyScriptAgreeLabel.Location = new System.Drawing.Point(6, 89);
            this.BuyScriptAgreeLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.BuyScriptAgreeLabel.Name = "BuyScriptAgreeLabel";
            this.BuyScriptAgreeLabel.Size = new System.Drawing.Size(107, 36);
            this.BuyScriptAgreeLabel.TabIndex = 3;
            this.BuyScriptAgreeLabel.Text = "\'I agree\' \r\nCheck:";
            this.BuyScriptAgreeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BuyScriptPurchaseTextBox
            // 
            this.BuyScriptPurchaseTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BuyScriptPurchaseTextBox.Depth = 0;
            this.BuyScriptPurchaseTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BuyScriptPurchaseTextBox.Hint = "ms";
            this.BuyScriptPurchaseTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BuyScriptPurchaseTextBox.LeadingIcon = null;
            this.BuyScriptPurchaseTextBox.Location = new System.Drawing.Point(119, 131);
            this.BuyScriptPurchaseTextBox.MaxLength = 50;
            this.BuyScriptPurchaseTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.BuyScriptPurchaseTextBox.Multiline = false;
            this.BuyScriptPurchaseTextBox.Name = "BuyScriptPurchaseTextBox";
            this.BuyScriptPurchaseTextBox.Size = new System.Drawing.Size(98, 36);
            this.BuyScriptPurchaseTextBox.TabIndex = 2;
            this.BuyScriptPurchaseTextBox.Text = "";
            this.BuyScriptPurchaseTextBox.TrailingIcon = null;
            this.BuyScriptPurchaseTextBox.UseTallSize = false;
            // 
            // BuyScriptBuyNowLabel
            // 
            this.BuyScriptBuyNowLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BuyScriptBuyNowLabel.BackColor = System.Drawing.SystemColors.Control;
            this.BuyScriptBuyNowLabel.Depth = 0;
            this.BuyScriptBuyNowLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BuyScriptBuyNowLabel.HighEmphasis = true;
            this.BuyScriptBuyNowLabel.Location = new System.Drawing.Point(6, 47);
            this.BuyScriptBuyNowLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.BuyScriptBuyNowLabel.Name = "BuyScriptBuyNowLabel";
            this.BuyScriptBuyNowLabel.Size = new System.Drawing.Size(107, 36);
            this.BuyScriptBuyNowLabel.TabIndex = 1;
            this.BuyScriptBuyNowLabel.Text = "\'Buy Now\' Click:";
            this.BuyScriptBuyNowLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BuyScriptBuyNowTextBox
            // 
            this.BuyScriptBuyNowTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BuyScriptBuyNowTextBox.Depth = 0;
            this.BuyScriptBuyNowTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BuyScriptBuyNowTextBox.Hint = "ms";
            this.BuyScriptBuyNowTextBox.LeadingIcon = null;
            this.BuyScriptBuyNowTextBox.Location = new System.Drawing.Point(119, 47);
            this.BuyScriptBuyNowTextBox.MaxLength = 50;
            this.BuyScriptBuyNowTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.BuyScriptBuyNowTextBox.Multiline = false;
            this.BuyScriptBuyNowTextBox.Name = "BuyScriptBuyNowTextBox";
            this.BuyScriptBuyNowTextBox.Size = new System.Drawing.Size(98, 36);
            this.BuyScriptBuyNowTextBox.TabIndex = 0;
            this.BuyScriptBuyNowTextBox.Text = "";
            this.BuyScriptBuyNowTextBox.TrailingIcon = null;
            this.BuyScriptBuyNowTextBox.UseTallSize = false;
            // 
            // JunkRemoverScriptSettingsGroupBox
            // 
            this.JunkRemoverScriptSettingsGroupBox.Controls.Add(this.JunkRemoverScriptSettingsEnabledCheckBox);
            this.JunkRemoverScriptSettingsGroupBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JunkRemoverScriptSettingsGroupBox.Location = new System.Drawing.Point(235, 67);
            this.JunkRemoverScriptSettingsGroupBox.Name = "JunkRemoverScriptSettingsGroupBox";
            this.JunkRemoverScriptSettingsGroupBox.Size = new System.Drawing.Size(223, 67);
            this.JunkRemoverScriptSettingsGroupBox.TabIndex = 8;
            this.JunkRemoverScriptSettingsGroupBox.TabStop = false;
            this.JunkRemoverScriptSettingsGroupBox.Text = "Junk Remover Script Settings";
            // 
            // JunkRemoverScriptSettingsEnabledCheckBox
            // 
            this.JunkRemoverScriptSettingsEnabledCheckBox.AutoSize = true;
            this.JunkRemoverScriptSettingsEnabledCheckBox.Depth = 0;
            this.JunkRemoverScriptSettingsEnabledCheckBox.Location = new System.Drawing.Point(9, 21);
            this.JunkRemoverScriptSettingsEnabledCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.JunkRemoverScriptSettingsEnabledCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.JunkRemoverScriptSettingsEnabledCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.JunkRemoverScriptSettingsEnabledCheckBox.Name = "JunkRemoverScriptSettingsEnabledCheckBox";
            this.JunkRemoverScriptSettingsEnabledCheckBox.Ripple = true;
            this.JunkRemoverScriptSettingsEnabledCheckBox.Size = new System.Drawing.Size(92, 37);
            this.JunkRemoverScriptSettingsEnabledCheckBox.TabIndex = 2;
            this.JunkRemoverScriptSettingsEnabledCheckBox.Text = "Enabled";
            this.JunkRemoverScriptSettingsEnabledCheckBox.UseVisualStyleBackColor = true;
            // 
            // ProxySettingsGroupBox
            // 
            this.ProxySettingsGroupBox.Controls.Add(this.ProxySettingsProxyListPanel);
            this.ProxySettingsGroupBox.Controls.Add(this.ProxySettingsProxyListFromFileButton);
            this.ProxySettingsGroupBox.Controls.Add(this.ProxyEnabledCheckBox);
            this.ProxySettingsGroupBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProxySettingsGroupBox.Location = new System.Drawing.Point(236, 251);
            this.ProxySettingsGroupBox.Name = "ProxySettingsGroupBox";
            this.ProxySettingsGroupBox.Size = new System.Drawing.Size(222, 231);
            this.ProxySettingsGroupBox.TabIndex = 9;
            this.ProxySettingsGroupBox.TabStop = false;
            this.ProxySettingsGroupBox.Text = "Proxy Settings";
            // 
            // ProxySettingsProxyListPanel
            // 
            this.ProxySettingsProxyListPanel.AutoScroll = true;
            this.ProxySettingsProxyListPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ProxySettingsProxyListPanel.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.ProxySettingsProxyListPanel.Location = new System.Drawing.Point(6, 54);
            this.ProxySettingsProxyListPanel.Name = "ProxySettingsProxyListPanel";
            this.ProxySettingsProxyListPanel.Size = new System.Drawing.Size(210, 171);
            this.ProxySettingsProxyListPanel.TabIndex = 11;
            // 
            // ProxySettingsProxyListFromFileButton
            // 
            this.ProxySettingsProxyListFromFileButton.AutoSize = false;
            this.ProxySettingsProxyListFromFileButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ProxySettingsProxyListFromFileButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ProxySettingsProxyListFromFileButton.Depth = 0;
            this.ProxySettingsProxyListFromFileButton.HighEmphasis = true;
            this.ProxySettingsProxyListFromFileButton.Icon = null;
            this.ProxySettingsProxyListFromFileButton.Location = new System.Drawing.Point(140, 27);
            this.ProxySettingsProxyListFromFileButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ProxySettingsProxyListFromFileButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ProxySettingsProxyListFromFileButton.Name = "ProxySettingsProxyListFromFileButton";
            this.ProxySettingsProxyListFromFileButton.Size = new System.Drawing.Size(75, 18);
            this.ProxySettingsProxyListFromFileButton.TabIndex = 10;
            this.ProxySettingsProxyListFromFileButton.Text = "From File";
            this.ProxySettingsProxyListFromFileButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ProxySettingsProxyListFromFileButton.UseAccentColor = false;
            this.ProxySettingsProxyListFromFileButton.UseVisualStyleBackColor = true;
            this.ProxySettingsProxyListFromFileButton.Click += new System.EventHandler(this.ProxySettingsProxyListFromFileButton_Click);
            // 
            // ProxyEnabledCheckBox
            // 
            this.ProxyEnabledCheckBox.AutoSize = true;
            this.ProxyEnabledCheckBox.Depth = 0;
            this.ProxyEnabledCheckBox.Location = new System.Drawing.Point(8, 21);
            this.ProxyEnabledCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.ProxyEnabledCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ProxyEnabledCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.ProxyEnabledCheckBox.Name = "ProxyEnabledCheckBox";
            this.ProxyEnabledCheckBox.Ripple = true;
            this.ProxyEnabledCheckBox.Size = new System.Drawing.Size(92, 37);
            this.ProxyEnabledCheckBox.TabIndex = 2;
            this.ProxyEnabledCheckBox.Text = "Enabled";
            this.ProxyEnabledCheckBox.UseVisualStyleBackColor = true;
            // 
            // WorkerDefaultSettingsGroupBox
            // 
            this.WorkerDefaultSettingsGroupBox.Controls.Add(this.WorkerDefaultSettingsDelayLabel);
            this.WorkerDefaultSettingsGroupBox.Controls.Add(this.WorkerDefaultSettingsDelayTextBox);
            this.WorkerDefaultSettingsGroupBox.Controls.Add(this.WorkerDefaultSettingsAutoBuyCheckbox);
            this.WorkerDefaultSettingsGroupBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkerDefaultSettingsGroupBox.Location = new System.Drawing.Point(235, 140);
            this.WorkerDefaultSettingsGroupBox.Name = "WorkerDefaultSettingsGroupBox";
            this.WorkerDefaultSettingsGroupBox.Size = new System.Drawing.Size(223, 105);
            this.WorkerDefaultSettingsGroupBox.TabIndex = 9;
            this.WorkerDefaultSettingsGroupBox.TabStop = false;
            this.WorkerDefaultSettingsGroupBox.Text = "Worker Default Settings";
            // 
            // WorkerDefaultSettingsDelayLabel
            // 
            this.WorkerDefaultSettingsDelayLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WorkerDefaultSettingsDelayLabel.BackColor = System.Drawing.SystemColors.Control;
            this.WorkerDefaultSettingsDelayLabel.Depth = 0;
            this.WorkerDefaultSettingsDelayLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.WorkerDefaultSettingsDelayLabel.HighEmphasis = true;
            this.WorkerDefaultSettingsDelayLabel.Location = new System.Drawing.Point(6, 62);
            this.WorkerDefaultSettingsDelayLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.WorkerDefaultSettingsDelayLabel.Name = "WorkerDefaultSettingsDelayLabel";
            this.WorkerDefaultSettingsDelayLabel.Size = new System.Drawing.Size(64, 36);
            this.WorkerDefaultSettingsDelayLabel.TabIndex = 9;
            this.WorkerDefaultSettingsDelayLabel.Text = "Delay:";
            this.WorkerDefaultSettingsDelayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WorkerDefaultSettingsDelayTextBox
            // 
            this.WorkerDefaultSettingsDelayTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WorkerDefaultSettingsDelayTextBox.Depth = 0;
            this.WorkerDefaultSettingsDelayTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.WorkerDefaultSettingsDelayTextBox.Hint = "ms";
            this.WorkerDefaultSettingsDelayTextBox.LeadingIcon = null;
            this.WorkerDefaultSettingsDelayTextBox.Location = new System.Drawing.Point(76, 62);
            this.WorkerDefaultSettingsDelayTextBox.MaxLength = 50;
            this.WorkerDefaultSettingsDelayTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.WorkerDefaultSettingsDelayTextBox.Multiline = false;
            this.WorkerDefaultSettingsDelayTextBox.Name = "WorkerDefaultSettingsDelayTextBox";
            this.WorkerDefaultSettingsDelayTextBox.Size = new System.Drawing.Size(141, 36);
            this.WorkerDefaultSettingsDelayTextBox.TabIndex = 9;
            this.WorkerDefaultSettingsDelayTextBox.Text = "";
            this.WorkerDefaultSettingsDelayTextBox.TrailingIcon = null;
            this.WorkerDefaultSettingsDelayTextBox.UseTallSize = false;
            // 
            // WorkerDefaultSettingsAutoBuyCheckbox
            // 
            this.WorkerDefaultSettingsAutoBuyCheckbox.AutoSize = true;
            this.WorkerDefaultSettingsAutoBuyCheckbox.Depth = 0;
            this.WorkerDefaultSettingsAutoBuyCheckbox.Location = new System.Drawing.Point(9, 21);
            this.WorkerDefaultSettingsAutoBuyCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.WorkerDefaultSettingsAutoBuyCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.WorkerDefaultSettingsAutoBuyCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.WorkerDefaultSettingsAutoBuyCheckbox.Name = "WorkerDefaultSettingsAutoBuyCheckbox";
            this.WorkerDefaultSettingsAutoBuyCheckbox.Ripple = true;
            this.WorkerDefaultSettingsAutoBuyCheckbox.Size = new System.Drawing.Size(99, 37);
            this.WorkerDefaultSettingsAutoBuyCheckbox.TabIndex = 2;
            this.WorkerDefaultSettingsAutoBuyCheckbox.Text = "Auto Buy";
            this.WorkerDefaultSettingsAutoBuyCheckbox.UseVisualStyleBackColor = true;
            // 
            // ProxySettingsProxyListFileOpenDialog
            // 
            this.ProxySettingsProxyListFileOpenDialog.FileName = "openFileDialog1";
            this.ProxySettingsProxyListFileOpenDialog.Title = "Where are your proxy list, honey? ";
            // 
            // LoginButton
            // 
            this.LoginButton.AutoSize = false;
            this.LoginButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LoginButton.BackColor = System.Drawing.SystemColors.Control;
            this.LoginButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.LoginButton.Depth = 0;
            this.LoginButton.DrawShadows = false;
            this.LoginButton.FlatAppearance.BorderSize = 0;
            this.LoginButton.HighEmphasis = false;
            this.LoginButton.Icon = null;
            this.LoginButton.Location = new System.Drawing.Point(378, 30);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.LoginButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(79, 25);
            this.LoginButton.TabIndex = 10;
            this.LoginButton.Text = "Account";
            this.LoginButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.LoginButton.UseAccentColor = false;
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.AccountButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 534);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.WorkerDefaultSettingsGroupBox);
            this.Controls.Add(this.ProxySettingsGroupBox);
            this.Controls.Add(this.JunkRemoverScriptSettingsGroupBox);
            this.Controls.Add(this.BuyScriptSettingsGroupBox);
            this.Controls.Add(this.CancelOperationButton);
            this.Controls.Add(this.ApplyOperationButton);
            this.Controls.Add(this.ParserSettingsGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.Sizable = false;
            this.Text = "Global Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ParserSettingsGroupBox.ResumeLayout(false);
            this.BuyScriptSettingsGroupBox.ResumeLayout(false);
            this.JunkRemoverScriptSettingsGroupBox.ResumeLayout(false);
            this.JunkRemoverScriptSettingsGroupBox.PerformLayout();
            this.ProxySettingsGroupBox.ResumeLayout(false);
            this.ProxySettingsGroupBox.PerformLayout();
            this.WorkerDefaultSettingsGroupBox.ResumeLayout(false);
            this.WorkerDefaultSettingsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ParserSettingsGroupBox;
        private MaterialSkin.Controls.MaterialTextBox ParserScriptCountryTextBox;
        private MaterialSkin.Controls.MaterialTextBox ParserScriptCurrencyTextBox;
        private MaterialSkin.Controls.MaterialTextBox ParserScriptLanguageTextBox;
        private MaterialSkin.Controls.MaterialTextBox ParserScriptCountTextBox;
        private MaterialSkin.Controls.MaterialButton ApplyOperationButton;
        private MaterialSkin.Controls.MaterialButton CancelOperationButton;
        private System.Windows.Forms.GroupBox BuyScriptSettingsGroupBox;
        private System.Windows.Forms.GroupBox JunkRemoverScriptSettingsGroupBox;
        private MaterialSkin.Controls.MaterialCheckbox JunkRemoverScriptSettingsEnabledCheckBox;
        private MaterialSkin.Controls.MaterialLabel BuyScriptPurchaseLabel;
        private MaterialSkin.Controls.MaterialTextBox BuyScriptAgreeTextBox;
        private MaterialSkin.Controls.MaterialLabel BuyScriptAgreeLabel;
        private MaterialSkin.Controls.MaterialTextBox BuyScriptPurchaseTextBox;
        private MaterialSkin.Controls.MaterialLabel BuyScriptBuyNowLabel;
        private MaterialSkin.Controls.MaterialTextBox BuyScriptBuyNowTextBox;
        private MaterialSkin.Controls.MaterialLabel BuyScriptSettingsDelayBeforeLabel;
        private System.Windows.Forms.GroupBox ProxySettingsGroupBox;
        private MaterialSkin.Controls.MaterialCheckbox ProxyEnabledCheckBox;
        private System.Windows.Forms.GroupBox WorkerDefaultSettingsGroupBox;
        private MaterialSkin.Controls.MaterialCheckbox WorkerDefaultSettingsAutoBuyCheckbox;
        private MaterialSkin.Controls.MaterialLabel ParserScriptCountryLabel;
        private MaterialSkin.Controls.MaterialLabel ParserScriptLanguageLabel;
        private MaterialSkin.Controls.MaterialLabel ParserScriptCurrencyLabel;
        private MaterialSkin.Controls.MaterialLabel ParserScriptSettingsCountLabel;
        private MaterialSkin.Controls.MaterialLabel WorkerDefaultSettingsDelayLabel;
        private MaterialSkin.Controls.MaterialTextBox WorkerDefaultSettingsDelayTextBox;
        private MaterialSkin.Controls.MaterialLabel BuyScriptCloseWindowLabel;
        private MaterialSkin.Controls.MaterialTextBox BuyScriptCloseWindowTextBox;
        private MaterialSkin.Controls.MaterialButton ProxySettingsProxyListFromFileButton;
        private System.Windows.Forms.OpenFileDialog ProxySettingsProxyListFileOpenDialog;
        private System.Windows.Forms.Panel ProxySettingsProxyListPanel;
        private MaterialSkin.Controls.MaterialButton LoginButton;
        private MaterialSkin.Controls.MaterialLabel ParserScriptSettingsFilterLabel;
        private MaterialSkin.Controls.MaterialTextBox ParserScriptSettingsFilterTextBox;
    }
}