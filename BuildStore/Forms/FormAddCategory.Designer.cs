namespace BuildStore.Forms
{
    partial class FormAddCategory
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
            this.bttAddCategory = new MaterialSkin.Controls.MaterialButton();
            this.textBoxCategory = new MaterialSkin.Controls.MaterialTextBox();
            this.comboBoxTypeCategory = new MaterialSkin.Controls.MaterialComboBox();
            this.comboBoxMainCategory = new MaterialSkin.Controls.MaterialComboBox();
            this.bttClose = new MaterialSkin.Controls.MaterialButton();
            this.buttonAddPicture = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxLinkImage = new MaterialSkin.Controls.MaterialTextBox();
            this.textBoxRelativeLink = new MaterialSkin.Controls.MaterialTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bttAddCategory
            // 
            this.bttAddCategory.AutoSize = false;
            this.bttAddCategory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bttAddCategory.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bttAddCategory.Depth = 0;
            this.bttAddCategory.HighEmphasis = true;
            this.bttAddCategory.Icon = null;
            this.bttAddCategory.Location = new System.Drawing.Point(23, 510);
            this.bttAddCategory.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bttAddCategory.MouseState = MaterialSkin.MouseState.HOVER;
            this.bttAddCategory.Name = "bttAddCategory";
            this.bttAddCategory.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bttAddCategory.Size = new System.Drawing.Size(454, 46);
            this.bttAddCategory.TabIndex = 0;
            this.bttAddCategory.Text = "Добавить категорию";
            this.bttAddCategory.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bttAddCategory.UseAccentColor = false;
            this.bttAddCategory.UseVisualStyleBackColor = true;
            this.bttAddCategory.Click += new System.EventHandler(this.bttAddCategory_Click);
            // 
            // textBoxCategory
            // 
            this.textBoxCategory.AnimateReadOnly = false;
            this.textBoxCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCategory.Depth = 0;
            this.textBoxCategory.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxCategory.Hint = "Название категории";
            this.textBoxCategory.LeadingIcon = null;
            this.textBoxCategory.Location = new System.Drawing.Point(25, 159);
            this.textBoxCategory.MaxLength = 50;
            this.textBoxCategory.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxCategory.Multiline = false;
            this.textBoxCategory.Name = "textBoxCategory";
            this.textBoxCategory.Size = new System.Drawing.Size(454, 50);
            this.textBoxCategory.TabIndex = 1;
            this.textBoxCategory.Text = "";
            this.textBoxCategory.TrailingIcon = null;
            // 
            // comboBoxTypeCategory
            // 
            this.comboBoxTypeCategory.AutoResize = false;
            this.comboBoxTypeCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxTypeCategory.Depth = 0;
            this.comboBoxTypeCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxTypeCategory.DropDownHeight = 174;
            this.comboBoxTypeCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTypeCategory.DropDownWidth = 121;
            this.comboBoxTypeCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboBoxTypeCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboBoxTypeCategory.FormattingEnabled = true;
            this.comboBoxTypeCategory.Hint = "Тип категории";
            this.comboBoxTypeCategory.IntegralHeight = false;
            this.comboBoxTypeCategory.ItemHeight = 43;
            this.comboBoxTypeCategory.Items.AddRange(new object[] {
            "Главная категория",
            "Подкатегория"});
            this.comboBoxTypeCategory.Location = new System.Drawing.Point(25, 94);
            this.comboBoxTypeCategory.MaxDropDownItems = 4;
            this.comboBoxTypeCategory.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBoxTypeCategory.Name = "comboBoxTypeCategory";
            this.comboBoxTypeCategory.Size = new System.Drawing.Size(224, 49);
            this.comboBoxTypeCategory.StartIndex = 0;
            this.comboBoxTypeCategory.TabIndex = 2;
            this.comboBoxTypeCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxTypeCategory_SelectedIndexChanged);
            // 
            // comboBoxMainCategory
            // 
            this.comboBoxMainCategory.AutoResize = false;
            this.comboBoxMainCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxMainCategory.Depth = 0;
            this.comboBoxMainCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxMainCategory.DropDownHeight = 174;
            this.comboBoxMainCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMainCategory.DropDownWidth = 121;
            this.comboBoxMainCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboBoxMainCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboBoxMainCategory.FormattingEnabled = true;
            this.comboBoxMainCategory.Hint = "Родитель категории";
            this.comboBoxMainCategory.IntegralHeight = false;
            this.comboBoxMainCategory.ItemHeight = 43;
            this.comboBoxMainCategory.Location = new System.Drawing.Point(255, 94);
            this.comboBoxMainCategory.MaxDropDownItems = 4;
            this.comboBoxMainCategory.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBoxMainCategory.Name = "comboBoxMainCategory";
            this.comboBoxMainCategory.Size = new System.Drawing.Size(224, 49);
            this.comboBoxMainCategory.StartIndex = 0;
            this.comboBoxMainCategory.TabIndex = 3;
            this.comboBoxMainCategory.Visible = false;
            // 
            // bttClose
            // 
            this.bttClose.AutoSize = false;
            this.bttClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bttClose.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bttClose.Depth = 0;
            this.bttClose.HighEmphasis = true;
            this.bttClose.Icon = null;
            this.bttClose.Location = new System.Drawing.Point(23, 565);
            this.bttClose.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bttClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.bttClose.Name = "bttClose";
            this.bttClose.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bttClose.Size = new System.Drawing.Size(454, 46);
            this.bttClose.TabIndex = 5;
            this.bttClose.Text = "отмена";
            this.bttClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bttClose.UseAccentColor = false;
            this.bttClose.UseVisualStyleBackColor = true;
            this.bttClose.Click += new System.EventHandler(this.bttClose_Click);
            // 
            // buttonAddPicture
            // 
            this.buttonAddPicture.AllowDrop = true;
            this.buttonAddPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddPicture.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddPicture.Location = new System.Drawing.Point(25, 337);
            this.buttonAddPicture.Name = "buttonAddPicture";
            this.buttonAddPicture.Size = new System.Drawing.Size(150, 150);
            this.buttonAddPicture.TabIndex = 39;
            this.buttonAddPicture.Text = "Drop image";
            this.buttonAddPicture.UseVisualStyleBackColor = true;
            this.buttonAddPicture.DragDrop += new System.Windows.Forms.DragEventHandler(this.buttonAddPicture_DragDrop);
            this.buttonAddPicture.DragEnter += new System.Windows.Forms.DragEventHandler(this.buttonAddPicture_DragEnter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(327, 337);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxLinkImage
            // 
            this.textBoxLinkImage.AnimateReadOnly = false;
            this.textBoxLinkImage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLinkImage.Depth = 0;
            this.textBoxLinkImage.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxLinkImage.Hint = "Ссылка на изображение";
            this.textBoxLinkImage.LeadingIcon = null;
            this.textBoxLinkImage.Location = new System.Drawing.Point(25, 271);
            this.textBoxLinkImage.MaxLength = 50;
            this.textBoxLinkImage.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxLinkImage.Multiline = false;
            this.textBoxLinkImage.Name = "textBoxLinkImage";
            this.textBoxLinkImage.Size = new System.Drawing.Size(454, 50);
            this.textBoxLinkImage.TabIndex = 40;
            this.textBoxLinkImage.Text = "";
            this.textBoxLinkImage.TrailingIcon = null;
            // 
            // textBoxRelativeLink
            // 
            this.textBoxRelativeLink.AnimateReadOnly = false;
            this.textBoxRelativeLink.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRelativeLink.Depth = 0;
            this.textBoxRelativeLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxRelativeLink.Hint = "Относительная ссылка";
            this.textBoxRelativeLink.LeadingIcon = null;
            this.textBoxRelativeLink.Location = new System.Drawing.Point(25, 215);
            this.textBoxRelativeLink.MaxLength = 50;
            this.textBoxRelativeLink.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxRelativeLink.Multiline = false;
            this.textBoxRelativeLink.Name = "textBoxRelativeLink";
            this.textBoxRelativeLink.Size = new System.Drawing.Size(454, 50);
            this.textBoxRelativeLink.TabIndex = 50;
            this.textBoxRelativeLink.Text = "";
            this.textBoxRelativeLink.TrailingIcon = null;
            this.textBoxRelativeLink.TextChanged += new System.EventHandler(this.textBoxRelativeLink_TextChanged);
            // 
            // FormAddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 637);
            this.Controls.Add(this.textBoxRelativeLink);
            this.Controls.Add(this.textBoxLinkImage);
            this.Controls.Add(this.buttonAddPicture);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bttClose);
            this.Controls.Add(this.comboBoxMainCategory);
            this.Controls.Add(this.comboBoxTypeCategory);
            this.Controls.Add(this.textBoxCategory);
            this.Controls.Add(this.bttAddCategory);
            this.Name = "FormAddCategory";
            this.Text = "Добавление категории";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton bttAddCategory;
        private MaterialSkin.Controls.MaterialTextBox textBoxCategory;
        private MaterialSkin.Controls.MaterialComboBox comboBoxTypeCategory;
        private MaterialSkin.Controls.MaterialComboBox comboBoxMainCategory;
        private MaterialSkin.Controls.MaterialButton bttClose;
        private System.Windows.Forms.Button buttonAddPicture;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialTextBox textBoxLinkImage;
        private MaterialSkin.Controls.MaterialTextBox textBoxRelativeLink;
    }
}