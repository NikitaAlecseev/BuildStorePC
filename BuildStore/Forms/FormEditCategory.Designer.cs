namespace BuildStore.Forms
{
    partial class FormEditCategory
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
            this.textBoxLinkImage = new MaterialSkin.Controls.MaterialTextBox();
            this.buttonAddPicture = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bttClose = new MaterialSkin.Controls.MaterialButton();
            this.comboBoxMainCategory = new MaterialSkin.Controls.MaterialComboBox();
            this.comboBoxTypeCategory = new MaterialSkin.Controls.MaterialComboBox();
            this.textBoxCategory = new MaterialSkin.Controls.MaterialTextBox();
            this.bttEditCategory = new MaterialSkin.Controls.MaterialButton();
            this.textBoxRelativeLink = new MaterialSkin.Controls.MaterialTextBox();
            this.listBoxCharaster = new MaterialSkin.Controls.MaterialListBox();
            this.textBoxTitleCharast = new MaterialSkin.Controls.MaterialTextBox();
            this.bttAddCharasteristick = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxLinkImage
            // 
            this.textBoxLinkImage.AnimateReadOnly = false;
            this.textBoxLinkImage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLinkImage.Depth = 0;
            this.textBoxLinkImage.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxLinkImage.Hint = "Ссылка на изображение";
            this.textBoxLinkImage.LeadingIcon = null;
            this.textBoxLinkImage.Location = new System.Drawing.Point(16, 253);
            this.textBoxLinkImage.MaxLength = 50;
            this.textBoxLinkImage.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxLinkImage.Multiline = false;
            this.textBoxLinkImage.Name = "textBoxLinkImage";
            this.textBoxLinkImage.Size = new System.Drawing.Size(454, 50);
            this.textBoxLinkImage.TabIndex = 48;
            this.textBoxLinkImage.Text = "";
            this.textBoxLinkImage.TrailingIcon = null;
            // 
            // buttonAddPicture
            // 
            this.buttonAddPicture.AllowDrop = true;
            this.buttonAddPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddPicture.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddPicture.Location = new System.Drawing.Point(16, 322);
            this.buttonAddPicture.Name = "buttonAddPicture";
            this.buttonAddPicture.Size = new System.Drawing.Size(150, 150);
            this.buttonAddPicture.TabIndex = 47;
            this.buttonAddPicture.Text = "Drop image";
            this.buttonAddPicture.UseVisualStyleBackColor = true;
            this.buttonAddPicture.DragDrop += new System.Windows.Forms.DragEventHandler(this.buttonAddPicture_DragDrop);
            this.buttonAddPicture.DragEnter += new System.Windows.Forms.DragEventHandler(this.buttonAddPicture_DragEnter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(318, 322);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // bttClose
            // 
            this.bttClose.AutoSize = false;
            this.bttClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bttClose.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bttClose.Depth = 0;
            this.bttClose.HighEmphasis = true;
            this.bttClose.Icon = null;
            this.bttClose.Location = new System.Drawing.Point(14, 550);
            this.bttClose.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bttClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.bttClose.Name = "bttClose";
            this.bttClose.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bttClose.Size = new System.Drawing.Size(454, 46);
            this.bttClose.TabIndex = 45;
            this.bttClose.Text = "отмена";
            this.bttClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bttClose.UseAccentColor = false;
            this.bttClose.UseVisualStyleBackColor = true;
            this.bttClose.Click += new System.EventHandler(this.bttClose_Click);
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
            this.comboBoxMainCategory.Location = new System.Drawing.Point(246, 76);
            this.comboBoxMainCategory.MaxDropDownItems = 4;
            this.comboBoxMainCategory.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBoxMainCategory.Name = "comboBoxMainCategory";
            this.comboBoxMainCategory.Size = new System.Drawing.Size(224, 49);
            this.comboBoxMainCategory.StartIndex = 0;
            this.comboBoxMainCategory.TabIndex = 44;
            this.comboBoxMainCategory.Visible = false;
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
            this.comboBoxTypeCategory.Enabled = false;
            this.comboBoxTypeCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboBoxTypeCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboBoxTypeCategory.FormattingEnabled = true;
            this.comboBoxTypeCategory.Hint = "Тип категории";
            this.comboBoxTypeCategory.IntegralHeight = false;
            this.comboBoxTypeCategory.ItemHeight = 43;
            this.comboBoxTypeCategory.Items.AddRange(new object[] {
            "Главная категория",
            "Подкатегория"});
            this.comboBoxTypeCategory.Location = new System.Drawing.Point(16, 76);
            this.comboBoxTypeCategory.MaxDropDownItems = 4;
            this.comboBoxTypeCategory.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBoxTypeCategory.Name = "comboBoxTypeCategory";
            this.comboBoxTypeCategory.Size = new System.Drawing.Size(224, 49);
            this.comboBoxTypeCategory.StartIndex = 0;
            this.comboBoxTypeCategory.TabIndex = 43;
            // 
            // textBoxCategory
            // 
            this.textBoxCategory.AnimateReadOnly = false;
            this.textBoxCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCategory.Depth = 0;
            this.textBoxCategory.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxCategory.Hint = "Название категории";
            this.textBoxCategory.LeadingIcon = null;
            this.textBoxCategory.Location = new System.Drawing.Point(16, 141);
            this.textBoxCategory.MaxLength = 50;
            this.textBoxCategory.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxCategory.Multiline = false;
            this.textBoxCategory.Name = "textBoxCategory";
            this.textBoxCategory.Size = new System.Drawing.Size(454, 50);
            this.textBoxCategory.TabIndex = 42;
            this.textBoxCategory.Text = "";
            this.textBoxCategory.TrailingIcon = null;
            // 
            // bttEditCategory
            // 
            this.bttEditCategory.AutoSize = false;
            this.bttEditCategory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bttEditCategory.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bttEditCategory.Depth = 0;
            this.bttEditCategory.HighEmphasis = true;
            this.bttEditCategory.Icon = null;
            this.bttEditCategory.Location = new System.Drawing.Point(14, 495);
            this.bttEditCategory.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bttEditCategory.MouseState = MaterialSkin.MouseState.HOVER;
            this.bttEditCategory.Name = "bttEditCategory";
            this.bttEditCategory.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bttEditCategory.Size = new System.Drawing.Size(454, 46);
            this.bttEditCategory.TabIndex = 41;
            this.bttEditCategory.Text = "Редактировать категорию";
            this.bttEditCategory.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bttEditCategory.UseAccentColor = false;
            this.bttEditCategory.UseVisualStyleBackColor = true;
            this.bttEditCategory.Click += new System.EventHandler(this.bttEditCategory_Click);
            // 
            // textBoxRelativeLink
            // 
            this.textBoxRelativeLink.AnimateReadOnly = false;
            this.textBoxRelativeLink.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRelativeLink.Depth = 0;
            this.textBoxRelativeLink.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxRelativeLink.Hint = "Относительная ссылка";
            this.textBoxRelativeLink.LeadingIcon = null;
            this.textBoxRelativeLink.Location = new System.Drawing.Point(16, 197);
            this.textBoxRelativeLink.MaxLength = 50;
            this.textBoxRelativeLink.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxRelativeLink.Multiline = false;
            this.textBoxRelativeLink.Name = "textBoxRelativeLink";
            this.textBoxRelativeLink.Size = new System.Drawing.Size(454, 50);
            this.textBoxRelativeLink.TabIndex = 49;
            this.textBoxRelativeLink.Text = "";
            this.textBoxRelativeLink.TrailingIcon = null;
            this.textBoxRelativeLink.TextChanged += new System.EventHandler(this.textBoxRelativeLink_TextChanged);
            // 
            // listBoxCharaster
            // 
            this.listBoxCharaster.BackColor = System.Drawing.Color.White;
            this.listBoxCharaster.BorderColor = System.Drawing.Color.LightGray;
            this.listBoxCharaster.Depth = 0;
            this.listBoxCharaster.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.listBoxCharaster.Location = new System.Drawing.Point(577, 131);
            this.listBoxCharaster.MouseState = MaterialSkin.MouseState.HOVER;
            this.listBoxCharaster.Name = "listBoxCharaster";
            this.listBoxCharaster.SelectedIndex = -1;
            this.listBoxCharaster.SelectedItem = null;
            this.listBoxCharaster.Size = new System.Drawing.Size(295, 331);
            this.listBoxCharaster.TabIndex = 50;
            this.listBoxCharaster.SelectedIndexChanged += new MaterialSkin.Controls.MaterialListBox.SelectedIndexChangedEventHandler(this.listBoxCharaster_SelectedIndexChanged);
            // 
            // textBoxTitleCharast
            // 
            this.textBoxTitleCharast.AnimateReadOnly = false;
            this.textBoxTitleCharast.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTitleCharast.Depth = 0;
            this.textBoxTitleCharast.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxTitleCharast.Hint = "Название характеристики";
            this.textBoxTitleCharast.LeadingIcon = null;
            this.textBoxTitleCharast.Location = new System.Drawing.Point(577, 75);
            this.textBoxTitleCharast.MaxLength = 50;
            this.textBoxTitleCharast.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxTitleCharast.Multiline = false;
            this.textBoxTitleCharast.Name = "textBoxTitleCharast";
            this.textBoxTitleCharast.Size = new System.Drawing.Size(295, 50);
            this.textBoxTitleCharast.TabIndex = 51;
            this.textBoxTitleCharast.Text = "";
            this.textBoxTitleCharast.TrailingIcon = null;
            // 
            // bttAddCharasteristick
            // 
            this.bttAddCharasteristick.AutoSize = false;
            this.bttAddCharasteristick.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bttAddCharasteristick.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bttAddCharasteristick.Depth = 0;
            this.bttAddCharasteristick.HighEmphasis = true;
            this.bttAddCharasteristick.Icon = null;
            this.bttAddCharasteristick.Location = new System.Drawing.Point(577, 471);
            this.bttAddCharasteristick.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bttAddCharasteristick.MouseState = MaterialSkin.MouseState.HOVER;
            this.bttAddCharasteristick.Name = "bttAddCharasteristick";
            this.bttAddCharasteristick.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bttAddCharasteristick.Size = new System.Drawing.Size(295, 46);
            this.bttAddCharasteristick.TabIndex = 52;
            this.bttAddCharasteristick.Text = "добавить";
            this.bttAddCharasteristick.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bttAddCharasteristick.UseAccentColor = false;
            this.bttAddCharasteristick.UseVisualStyleBackColor = true;
            this.bttAddCharasteristick.Click += new System.EventHandler(this.bttAddCharasteristick_Click);
            // 
            // FormEditCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 615);
            this.Controls.Add(this.bttAddCharasteristick);
            this.Controls.Add(this.textBoxTitleCharast);
            this.Controls.Add(this.listBoxCharaster);
            this.Controls.Add(this.textBoxRelativeLink);
            this.Controls.Add(this.textBoxLinkImage);
            this.Controls.Add(this.buttonAddPicture);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bttClose);
            this.Controls.Add(this.comboBoxMainCategory);
            this.Controls.Add(this.comboBoxTypeCategory);
            this.Controls.Add(this.textBoxCategory);
            this.Controls.Add(this.bttEditCategory);
            this.Name = "FormEditCategory";
            this.Text = "Редактирование категории";
            this.Load += new System.EventHandler(this.FormEditCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox textBoxLinkImage;
        private System.Windows.Forms.Button buttonAddPicture;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialButton bttClose;
        private MaterialSkin.Controls.MaterialComboBox comboBoxMainCategory;
        private MaterialSkin.Controls.MaterialComboBox comboBoxTypeCategory;
        private MaterialSkin.Controls.MaterialTextBox textBoxCategory;
        private MaterialSkin.Controls.MaterialButton bttEditCategory;
        private MaterialSkin.Controls.MaterialTextBox textBoxRelativeLink;
        private MaterialSkin.Controls.MaterialListBox listBoxCharaster;
        private MaterialSkin.Controls.MaterialTextBox textBoxTitleCharast;
        private MaterialSkin.Controls.MaterialButton bttAddCharasteristick;
    }
}