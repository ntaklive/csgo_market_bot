
namespace FloatTool.Controls
{
    partial class WeaponsListItemControl
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
            this.Image = new System.Windows.Forms.PictureBox();
            this.PriceLabel = new MaterialSkin.Controls.MaterialLabel();
            this.ItemLabel = new MaterialSkin.Controls.MaterialLabel();
            this.DeleteButton = new MaterialSkin.Controls.MaterialButton();
            this.Panel = new System.Windows.Forms.Panel();
            this.FloatTextBox = new System.Windows.Forms.TextBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.FloatLabel = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.Image)).BeginInit();
            this.Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Image
            // 
            this.Image.Location = new System.Drawing.Point(21, 0);
            this.Image.Name = "Image";
            this.Image.Size = new System.Drawing.Size(63, 52);
            this.Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Image.TabIndex = 0;
            this.Image.TabStop = false;
            // 
            // PriceLabel
            // 
            this.PriceLabel.Depth = 0;
            this.PriceLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PriceLabel.Location = new System.Drawing.Point(384, 27);
            this.PriceLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(46, 25);
            this.PriceLabel.TabIndex = 2;
            this.PriceLabel.Text = "Float:";
            this.PriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ItemLabel
            // 
            this.ItemLabel.BackColor = System.Drawing.SystemColors.Control;
            this.ItemLabel.Depth = 0;
            this.ItemLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ItemLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ItemLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ItemLabel.Location = new System.Drawing.Point(90, 0);
            this.ItemLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.ItemLabel.Name = "ItemLabel";
            this.ItemLabel.Size = new System.Drawing.Size(288, 52);
            this.ItemLabel.TabIndex = 1;
            this.ItemLabel.Text = "Template Item Name";
            this.ItemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DeleteButton
            // 
            this.DeleteButton.AutoSize = false;
            this.DeleteButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.DeleteButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.DeleteButton.Depth = 0;
            this.DeleteButton.DrawShadows = false;
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.HighEmphasis = true;
            this.DeleteButton.Icon = null;
            this.DeleteButton.Location = new System.Drawing.Point(0, 0);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DeleteButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(15, 15);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "X";
            this.DeleteButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.DeleteButton.UseAccentColor = false;
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.SystemColors.Control;
            this.Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel.Controls.Add(this.FloatTextBox);
            this.Panel.Controls.Add(this.PriceTextBox);
            this.Panel.Controls.Add(this.FloatLabel);
            this.Panel.Controls.Add(this.Image);
            this.Panel.Controls.Add(this.DeleteButton);
            this.Panel.Controls.Add(this.ItemLabel);
            this.Panel.Controls.Add(this.PriceLabel);
            this.Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel.Location = new System.Drawing.Point(0, 0);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(544, 54);
            this.Panel.TabIndex = 5;
            // 
            // FloatTextBox
            // 
            this.FloatTextBox.Location = new System.Drawing.Point(436, 29);
            this.FloatTextBox.Name = "FloatTextBox";
            this.FloatTextBox.Size = new System.Drawing.Size(81, 20);
            this.FloatTextBox.TabIndex = 7;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(436, 3);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(81, 20);
            this.PriceTextBox.TabIndex = 6;
            // 
            // FloatLabel
            // 
            this.FloatLabel.Depth = 0;
            this.FloatLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FloatLabel.Location = new System.Drawing.Point(384, 0);
            this.FloatLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.FloatLabel.Name = "FloatLabel";
            this.FloatLabel.Size = new System.Drawing.Size(46, 27);
            this.FloatLabel.TabIndex = 5;
            this.FloatLabel.Text = "Price:";
            this.FloatLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // WeaponsListItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Panel);
            this.Name = "WeaponsListItemControl";
            this.Size = new System.Drawing.Size(544, 54);
            this.Load += new System.EventHandler(this.WeaponsListItemControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Image)).EndInit();
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Image;
        private MaterialSkin.Controls.MaterialLabel PriceLabel;
        private MaterialSkin.Controls.MaterialLabel ItemLabel;
        private MaterialSkin.Controls.MaterialButton DeleteButton;
        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.TextBox FloatTextBox;
        private System.Windows.Forms.TextBox PriceTextBox;
        private MaterialSkin.Controls.MaterialLabel FloatLabel;
    }
}
