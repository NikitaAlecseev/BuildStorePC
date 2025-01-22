namespace BuildStore.Forms
{
    partial class FormAuthorization
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
            this.textBoxLogin = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxPasssword = new MaterialSkin.Controls.MaterialTextBox();
            this.bttAutorization = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLogin.AnimateReadOnly = false;
            this.textBoxLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLogin.Depth = 0;
            this.textBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxLogin.Hint = "Логин";
            this.textBoxLogin.LeadingIcon = null;
            this.textBoxLogin.Location = new System.Drawing.Point(51, 117);
            this.textBoxLogin.MaxLength = 50;
            this.textBoxLogin.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxLogin.Multiline = false;
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(381, 50);
            this.textBoxLogin.TabIndex = 1;
            this.textBoxLogin.Text = "Admin";
            this.textBoxLogin.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(48, 95);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(46, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Логин";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(48, 173);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(57, 19);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "Пароль";
            // 
            // textBoxPasssword
            // 
            this.textBoxPasssword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPasssword.AnimateReadOnly = false;
            this.textBoxPasssword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPasssword.Depth = 0;
            this.textBoxPasssword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxPasssword.Hint = "Пароль";
            this.textBoxPasssword.LeadingIcon = null;
            this.textBoxPasssword.Location = new System.Drawing.Point(51, 195);
            this.textBoxPasssword.MaxLength = 50;
            this.textBoxPasssword.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxPasssword.Multiline = false;
            this.textBoxPasssword.Name = "textBoxPasssword";
            this.textBoxPasssword.Size = new System.Drawing.Size(381, 50);
            this.textBoxPasssword.TabIndex = 3;
            this.textBoxPasssword.Text = "SuperAdmin";
            this.textBoxPasssword.TrailingIcon = null;
            // 
            // bttAutorization
            // 
            this.bttAutorization.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bttAutorization.AutoSize = false;
            this.bttAutorization.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bttAutorization.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bttAutorization.Depth = 0;
            this.bttAutorization.HighEmphasis = true;
            this.bttAutorization.Icon = null;
            this.bttAutorization.Location = new System.Drawing.Point(51, 274);
            this.bttAutorization.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bttAutorization.MouseState = MaterialSkin.MouseState.HOVER;
            this.bttAutorization.Name = "bttAutorization";
            this.bttAutorization.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bttAutorization.Size = new System.Drawing.Size(381, 41);
            this.bttAutorization.TabIndex = 5;
            this.bttAutorization.Text = "Авторизоваться";
            this.bttAutorization.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bttAutorization.UseAccentColor = false;
            this.bttAutorization.UseVisualStyleBackColor = true;
            this.bttAutorization.Click += new System.EventHandler(this.bttAutorization_Click);
            // 
            // FormAuthorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 349);
            this.Controls.Add(this.bttAutorization);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.textBoxPasssword);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.textBoxLogin);
            this.Name = "FormAuthorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox textBoxLogin;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox textBoxPasssword;
        private MaterialSkin.Controls.MaterialButton bttAutorization;
    }
}