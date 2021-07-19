
namespace FloatTool.Controls
{
    partial class ProxyListItemControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.IpTextLabel = new MaterialSkin.Controls.MaterialLabel();
            this.DeleteButton = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // IpTextLabel
            // 
            this.IpTextLabel.Depth = 0;
            this.IpTextLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.IpTextLabel.Location = new System.Drawing.Point(25, 0);
            this.IpTextLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.IpTextLabel.Name = "IpTextLabel";
            this.IpTextLabel.Size = new System.Drawing.Size(245, 18);
            this.IpTextLabel.TabIndex = 0;
            this.IpTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DeleteButton
            // 
            this.DeleteButton.AutoSize = false;
            this.DeleteButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.DeleteButton.Depth = 0;
            this.DeleteButton.HighEmphasis = true;
            this.DeleteButton.Icon = null;
            this.DeleteButton.Location = new System.Drawing.Point(0, 0);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DeleteButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(18, 18);
            this.DeleteButton.TabIndex = 1;
            this.DeleteButton.Text = "x";
            this.DeleteButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.DeleteButton.UseAccentColor = false;
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // ProxyListItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.IpTextLabel);
            this.Name = "ProxyListItemControl";
            this.Size = new System.Drawing.Size(273, 18);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel IpTextLabel;
        private MaterialSkin.Controls.MaterialButton DeleteButton;
    }
}
