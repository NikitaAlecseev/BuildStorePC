namespace BuildStore.Forms
{
    partial class FormEditProduct
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditProduct));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboBoxDiscount = new MaterialSkin.Controls.MaterialComboBox();
            this.textBoxTitle = new MaterialSkin.Controls.MaterialTextBox();
            this.comboBoxCategory = new MaterialSkin.Controls.MaterialComboBox();
            this.comboBoxUnderCategory = new MaterialSkin.Controls.MaterialComboBox();
            this.textBoxDescription = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.textBoxCost = new MaterialSkin.Controls.MaterialTextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.flowLayoutCharast = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBoxRelativeLink = new MaterialSkin.Controls.MaterialTextBox();
            this.textBoxLinkImage = new MaterialSkin.Controls.MaterialTextBox();
            this.buttonAddPicture = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBoxItog = new System.Windows.Forms.PictureBox();
            this.labelCost = new MaterialSkin.Controls.MaterialLabel();
            this.labelTitle = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new MaterialSkin.Controls.MaterialListBox();
            this.labelProgres = new MaterialSkin.Controls.MaterialLabel();
            this.bttEdit = new MaterialSkin.Controls.MaterialButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxItog)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage4);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(841, 570);
            this.materialTabControl1.TabIndex = 39;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.comboBoxDiscount);
            this.tabPage1.Controls.Add(this.textBoxTitle);
            this.tabPage1.Controls.Add(this.comboBoxCategory);
            this.tabPage1.Controls.Add(this.comboBoxUnderCategory);
            this.tabPage1.Controls.Add(this.textBoxDescription);
            this.tabPage1.Controls.Add(this.textBoxCost);
            this.tabPage1.ImageKey = "description.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(833, 527);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Описание";
            // 
            // comboBoxDiscount
            // 
            this.comboBoxDiscount.AutoResize = false;
            this.comboBoxDiscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxDiscount.Depth = 0;
            this.comboBoxDiscount.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxDiscount.DropDownHeight = 174;
            this.comboBoxDiscount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDiscount.DropDownWidth = 121;
            this.comboBoxDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboBoxDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboBoxDiscount.FormattingEnabled = true;
            this.comboBoxDiscount.Hint = "Акция";
            this.comboBoxDiscount.IntegralHeight = false;
            this.comboBoxDiscount.ItemHeight = 43;
            this.comboBoxDiscount.Location = new System.Drawing.Point(15, 239);
            this.comboBoxDiscount.MaxDropDownItems = 4;
            this.comboBoxDiscount.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBoxDiscount.Name = "comboBoxDiscount";
            this.comboBoxDiscount.Size = new System.Drawing.Size(318, 49);
            this.comboBoxDiscount.StartIndex = 0;
            this.comboBoxDiscount.TabIndex = 10;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.AnimateReadOnly = false;
            this.textBoxTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTitle.Depth = 0;
            this.textBoxTitle.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxTitle.Hint = "Название";
            this.textBoxTitle.LeadingIcon = null;
            this.textBoxTitle.Location = new System.Drawing.Point(15, 17);
            this.textBoxTitle.MaxLength = 50;
            this.textBoxTitle.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxTitle.Multiline = false;
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(318, 50);
            this.textBoxTitle.TabIndex = 5;
            this.textBoxTitle.Text = "";
            this.textBoxTitle.TrailingIcon = null;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.AutoResize = false;
            this.comboBoxCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxCategory.Depth = 0;
            this.comboBoxCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxCategory.DropDownHeight = 174;
            this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategory.DropDownWidth = 121;
            this.comboBoxCategory.Enabled = false;
            this.comboBoxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboBoxCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Hint = "Категория";
            this.comboBoxCategory.IntegralHeight = false;
            this.comboBoxCategory.ItemHeight = 43;
            this.comboBoxCategory.Location = new System.Drawing.Point(15, 129);
            this.comboBoxCategory.MaxDropDownItems = 4;
            this.comboBoxCategory.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(318, 49);
            this.comboBoxCategory.StartIndex = 0;
            this.comboBoxCategory.TabIndex = 1;
            // 
            // comboBoxUnderCategory
            // 
            this.comboBoxUnderCategory.AutoResize = false;
            this.comboBoxUnderCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxUnderCategory.Depth = 0;
            this.comboBoxUnderCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxUnderCategory.DropDownHeight = 174;
            this.comboBoxUnderCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUnderCategory.DropDownWidth = 121;
            this.comboBoxUnderCategory.Enabled = false;
            this.comboBoxUnderCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboBoxUnderCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboBoxUnderCategory.FormattingEnabled = true;
            this.comboBoxUnderCategory.Hint = "Под категория";
            this.comboBoxUnderCategory.IntegralHeight = false;
            this.comboBoxUnderCategory.ItemHeight = 43;
            this.comboBoxUnderCategory.Location = new System.Drawing.Point(15, 184);
            this.comboBoxUnderCategory.MaxDropDownItems = 4;
            this.comboBoxUnderCategory.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBoxUnderCategory.Name = "comboBoxUnderCategory";
            this.comboBoxUnderCategory.Size = new System.Drawing.Size(318, 49);
            this.comboBoxUnderCategory.StartIndex = 0;
            this.comboBoxUnderCategory.TabIndex = 3;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.AnimateReadOnly = false;
            this.textBoxDescription.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.textBoxDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textBoxDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxDescription.Depth = 0;
            this.textBoxDescription.HideSelection = true;
            this.textBoxDescription.Hint = "Сюда описание продукта";
            this.textBoxDescription.Location = new System.Drawing.Point(15, 294);
            this.textBoxDescription.MaxLength = 32767;
            this.textBoxDescription.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.PasswordChar = '\0';
            this.textBoxDescription.ReadOnly = false;
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxDescription.SelectedText = "";
            this.textBoxDescription.SelectionLength = 0;
            this.textBoxDescription.SelectionStart = 0;
            this.textBoxDescription.ShortcutsEnabled = true;
            this.textBoxDescription.Size = new System.Drawing.Size(318, 144);
            this.textBoxDescription.TabIndex = 6;
            this.textBoxDescription.TabStop = false;
            this.textBoxDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxDescription.UseSystemPasswordChar = false;
            // 
            // textBoxCost
            // 
            this.textBoxCost.AnimateReadOnly = false;
            this.textBoxCost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCost.Depth = 0;
            this.textBoxCost.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxCost.Hint = "Стоимость";
            this.textBoxCost.LeadingIcon = null;
            this.textBoxCost.Location = new System.Drawing.Point(15, 73);
            this.textBoxCost.MaxLength = 50;
            this.textBoxCost.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxCost.Multiline = false;
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(318, 50);
            this.textBoxCost.TabIndex = 9;
            this.textBoxCost.Text = "";
            this.textBoxCost.TrailingIcon = null;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.flowLayoutCharast);
            this.tabPage4.ImageKey = "specific.png";
            this.tabPage4.Location = new System.Drawing.Point(4, 39);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(833, 527);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Характеристики";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // flowLayoutCharast
            // 
            this.flowLayoutCharast.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutCharast.AutoScroll = true;
            this.flowLayoutCharast.BackColor = System.Drawing.Color.White;
            this.flowLayoutCharast.Location = new System.Drawing.Point(15, 19);
            this.flowLayoutCharast.Name = "flowLayoutCharast";
            this.flowLayoutCharast.Size = new System.Drawing.Size(937, 480);
            this.flowLayoutCharast.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.textBoxRelativeLink);
            this.tabPage2.Controls.Add(this.textBoxLinkImage);
            this.tabPage2.Controls.Add(this.buttonAddPicture);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.ImageKey = "image.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(833, 527);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Картинка";
            // 
            // textBoxRelativeLink
            // 
            this.textBoxRelativeLink.AnimateReadOnly = false;
            this.textBoxRelativeLink.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRelativeLink.Depth = 0;
            this.textBoxRelativeLink.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxRelativeLink.Hint = "Относительная ссылка";
            this.textBoxRelativeLink.LeadingIcon = null;
            this.textBoxRelativeLink.Location = new System.Drawing.Point(19, 85);
            this.textBoxRelativeLink.MaxLength = 50;
            this.textBoxRelativeLink.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxRelativeLink.Multiline = false;
            this.textBoxRelativeLink.Name = "textBoxRelativeLink";
            this.textBoxRelativeLink.Size = new System.Drawing.Size(470, 50);
            this.textBoxRelativeLink.TabIndex = 39;
            this.textBoxRelativeLink.Text = "";
            this.textBoxRelativeLink.TrailingIcon = null;
            // 
            // textBoxLinkImage
            // 
            this.textBoxLinkImage.AnimateReadOnly = false;
            this.textBoxLinkImage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLinkImage.Depth = 0;
            this.textBoxLinkImage.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxLinkImage.Hint = "Ссылка на изображение";
            this.textBoxLinkImage.LeadingIcon = null;
            this.textBoxLinkImage.Location = new System.Drawing.Point(19, 29);
            this.textBoxLinkImage.MaxLength = 50;
            this.textBoxLinkImage.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxLinkImage.Multiline = false;
            this.textBoxLinkImage.Name = "textBoxLinkImage";
            this.textBoxLinkImage.Size = new System.Drawing.Size(470, 50);
            this.textBoxLinkImage.TabIndex = 38;
            this.textBoxLinkImage.Text = "";
            this.textBoxLinkImage.TrailingIcon = null;
            // 
            // buttonAddPicture
            // 
            this.buttonAddPicture.AllowDrop = true;
            this.buttonAddPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddPicture.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddPicture.Location = new System.Drawing.Point(19, 141);
            this.buttonAddPicture.Name = "buttonAddPicture";
            this.buttonAddPicture.Size = new System.Drawing.Size(232, 200);
            this.buttonAddPicture.TabIndex = 37;
            this.buttonAddPicture.Text = "Drop image";
            this.buttonAddPicture.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(289, 141);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.labelProgres);
            this.tabPage3.Controls.Add(this.bttEdit);
            this.tabPage3.ImageKey = "send.png";
            this.tabPage3.Location = new System.Drawing.Point(4, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(833, 527);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Отправка";
            this.tabPage3.Paint += new System.Windows.Forms.PaintEventHandler(this.tabPage3_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.pictureBoxItog);
            this.groupBox2.Controls.Add(this.labelCost);
            this.groupBox2.Controls.Add(this.labelTitle);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.groupBox2.Location = new System.Drawing.Point(21, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(288, 376);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Основная информация";
            // 
            // pictureBoxItog
            // 
            this.pictureBoxItog.Location = new System.Drawing.Point(44, 28);
            this.pictureBoxItog.Name = "pictureBoxItog";
            this.pictureBoxItog.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxItog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxItog.TabIndex = 45;
            this.pictureBoxItog.TabStop = false;
            // 
            // labelCost
            // 
            this.labelCost.Depth = 0;
            this.labelCost.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelCost.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelCost.Location = new System.Drawing.Point(46, 340);
            this.labelCost.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelCost.Name = "labelCost";
            this.labelCost.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelCost.Size = new System.Drawing.Size(198, 24);
            this.labelCost.TabIndex = 47;
            this.labelCost.Text = "250.00 руб";
            this.labelCost.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle.Depth = 0;
            this.labelTitle.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.labelTitle.Location = new System.Drawing.Point(6, 235);
            this.labelTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(276, 29);
            this.labelTitle.TabIndex = 46;
            this.labelTitle.Text = "Название";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(424, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 382);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Характеристики";
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.BackColor = System.Drawing.Color.White;
            this.listBox1.BorderColor = System.Drawing.Color.LightGray;
            this.listBox1.Depth = 0;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.listBox1.Location = new System.Drawing.Point(6, 28);
            this.listBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectedIndex = -1;
            this.listBox1.SelectedItem = null;
            this.listBox1.Size = new System.Drawing.Size(371, 348);
            this.listBox1.TabIndex = 0;
            // 
            // labelProgres
            // 
            this.labelProgres.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelProgres.AutoSize = true;
            this.labelProgres.Depth = 0;
            this.labelProgres.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelProgres.Location = new System.Drawing.Point(553, 485);
            this.labelProgres.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelProgres.Name = "labelProgres";
            this.labelProgres.Size = new System.Drawing.Size(1, 0);
            this.labelProgres.TabIndex = 43;
            // 
            // bttEdit
            // 
            this.bttEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bttEdit.AutoSize = false;
            this.bttEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bttEdit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bttEdit.Depth = 0;
            this.bttEdit.HighEmphasis = true;
            this.bttEdit.Icon = null;
            this.bttEdit.Location = new System.Drawing.Point(244, 475);
            this.bttEdit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bttEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.bttEdit.Name = "bttEdit";
            this.bttEdit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bttEdit.Size = new System.Drawing.Size(302, 36);
            this.bttEdit.TabIndex = 11;
            this.bttEdit.Text = "Изменить";
            this.bttEdit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bttEdit.UseAccentColor = false;
            this.bttEdit.UseVisualStyleBackColor = true;
            this.bttEdit.Click += new System.EventHandler(this.bttEdit_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "description.png");
            this.imageList1.Images.SetKeyName(1, "image.png");
            this.imageList1.Images.SetKeyName(2, "send.png");
            this.imageList1.Images.SetKeyName(3, "specific.png");
            // 
            // FormEditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 637);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "FormEditProduct";
            this.Text = "Редактирование товара";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEditProduct_FormClosing);
            this.Load += new System.EventHandler(this.FormEditProduct_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxItog)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private MaterialSkin.Controls.MaterialComboBox comboBoxDiscount;
        private MaterialSkin.Controls.MaterialTextBox textBoxTitle;
        private MaterialSkin.Controls.MaterialComboBox comboBoxCategory;
        private MaterialSkin.Controls.MaterialComboBox comboBoxUnderCategory;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 textBoxDescription;
        private MaterialSkin.Controls.MaterialTextBox textBoxCost;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutCharast;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialTextBox textBoxLinkImage;
        private System.Windows.Forms.Button buttonAddPicture;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBoxItog;
        private MaterialSkin.Controls.MaterialLabel labelCost;
        private MaterialSkin.Controls.MaterialLabel labelTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialListBox listBox1;
        private MaterialSkin.Controls.MaterialLabel labelProgres;
        private MaterialSkin.Controls.MaterialButton bttEdit;
        private System.Windows.Forms.ImageList imageList1;
        private MaterialSkin.Controls.MaterialTextBox textBoxRelativeLink;
    }
}