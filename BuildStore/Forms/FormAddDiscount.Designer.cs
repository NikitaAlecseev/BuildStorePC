namespace BuildStore.Forms
{
    partial class FormAddDiscount
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
            this.textBoxTitle = new MaterialSkin.Controls.MaterialTextBox();
            this.textBoxDiscount = new MaterialSkin.Controls.MaterialTextBox();
            this.bttAdd = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.AnimateReadOnly = false;
            this.textBoxTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTitle.Depth = 0;
            this.textBoxTitle.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxTitle.Hint = "Название скидки";
            this.textBoxTitle.LeadingIcon = null;
            this.textBoxTitle.Location = new System.Drawing.Point(23, 94);
            this.textBoxTitle.MaxLength = 50;
            this.textBoxTitle.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxTitle.Multiline = false;
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(373, 50);
            this.textBoxTitle.TabIndex = 0;
            this.textBoxTitle.Text = "";
            this.textBoxTitle.TrailingIcon = null;
            // 
            // textBoxDiscount
            // 
            this.textBoxDiscount.AnimateReadOnly = false;
            this.textBoxDiscount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDiscount.Depth = 0;
            this.textBoxDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxDiscount.Hint = "Скидка в %";
            this.textBoxDiscount.LeadingIcon = null;
            this.textBoxDiscount.Location = new System.Drawing.Point(23, 150);
            this.textBoxDiscount.MaxLength = 50;
            this.textBoxDiscount.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxDiscount.Multiline = false;
            this.textBoxDiscount.Name = "textBoxDiscount";
            this.textBoxDiscount.Size = new System.Drawing.Size(373, 50);
            this.textBoxDiscount.TabIndex = 1;
            this.textBoxDiscount.Text = "";
            this.textBoxDiscount.TrailingIcon = null;
            // 
            // bttAdd
            // 
            this.bttAdd.AutoSize = false;
            this.bttAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bttAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bttAdd.Depth = 0;
            this.bttAdd.HighEmphasis = true;
            this.bttAdd.Icon = null;
            this.bttAdd.Location = new System.Drawing.Point(23, 270);
            this.bttAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bttAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.bttAdd.Name = "bttAdd";
            this.bttAdd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bttAdd.Size = new System.Drawing.Size(373, 44);
            this.bttAdd.TabIndex = 2;
            this.bttAdd.Text = "Добавить скидку";
            this.bttAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bttAdd.UseAccentColor = false;
            this.bttAdd.UseVisualStyleBackColor = true;
            this.bttAdd.Click += new System.EventHandler(this.bttAdd_Click);
            // 
            // FormAddDiscount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 323);
            this.Controls.Add(this.bttAdd);
            this.Controls.Add(this.textBoxDiscount);
            this.Controls.Add(this.textBoxTitle);
            this.Name = "FormAddDiscount";
            this.Text = "Добавление скидки";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox textBoxTitle;
        private MaterialSkin.Controls.MaterialTextBox textBoxDiscount;
        private MaterialSkin.Controls.MaterialButton bttAdd;
    }
}