namespace BuildStore.Forms
{
    partial class FormEditUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditUser));
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboBoxPost = new MaterialSkin.Controls.MaterialComboBox();
            this.comboBoxTypeUser = new MaterialSkin.Controls.MaterialComboBox();
            this.textBoxAddress = new MaterialSkin.Controls.MaterialTextBox();
            this.textBoxPhone = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.textBoxPatronymic = new MaterialSkin.Controls.MaterialTextBox();
            this.textBoxName = new MaterialSkin.Controls.MaterialTextBox();
            this.textBoxSurname = new MaterialSkin.Controls.MaterialTextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.labelCheckPassword = new System.Windows.Forms.Label();
            this.labelCheckLogin = new System.Windows.Forms.Label();
            this.bttCheck = new MaterialSkin.Controls.MaterialButton();
            this.textBoxPassword2 = new MaterialSkin.Controls.MaterialTextBox();
            this.textBoxSecret = new MaterialSkin.Controls.MaterialTextBox();
            this.textBoxPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.textBoxLogin = new MaterialSkin.Controls.MaterialTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBoxRelativeLink = new MaterialSkin.Controls.MaterialTextBox();
            this.buttonAddPicture = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxLinkImage = new MaterialSkin.Controls.MaterialTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.bttEdit = new MaterialSkin.Controls.MaterialButton();
            this.labelTypeUser = new System.Windows.Forms.Label();
            this.labelPost = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelPatronymic = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "document.png");
            this.imageList2.Images.SetKeyName(1, "image.png");
            this.imageList2.Images.SetKeyName(2, "send.png");
            this.imageList2.Images.SetKeyName(3, "specific.png");
            this.imageList2.Images.SetKeyName(4, "lock.png");
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage4);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList2;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(933, 593);
            this.materialTabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.comboBoxPost);
            this.tabPage1.Controls.Add(this.comboBoxTypeUser);
            this.tabPage1.Controls.Add(this.textBoxAddress);
            this.tabPage1.Controls.Add(this.textBoxPhone);
            this.tabPage1.Controls.Add(this.textBoxPatronymic);
            this.tabPage1.Controls.Add(this.textBoxName);
            this.tabPage1.Controls.Add(this.textBoxSurname);
            this.tabPage1.ImageKey = "document.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(925, 550);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Основное";
            // 
            // comboBoxPost
            // 
            this.comboBoxPost.AutoResize = false;
            this.comboBoxPost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxPost.Depth = 0;
            this.comboBoxPost.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxPost.DropDownHeight = 174;
            this.comboBoxPost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPost.DropDownWidth = 121;
            this.comboBoxPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboBoxPost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboBoxPost.FormattingEnabled = true;
            this.comboBoxPost.Hint = "Должность";
            this.comboBoxPost.IntegralHeight = false;
            this.comboBoxPost.ItemHeight = 43;
            this.comboBoxPost.Location = new System.Drawing.Point(18, 395);
            this.comboBoxPost.MaxDropDownItems = 4;
            this.comboBoxPost.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBoxPost.Name = "comboBoxPost";
            this.comboBoxPost.Size = new System.Drawing.Size(322, 49);
            this.comboBoxPost.StartIndex = 0;
            this.comboBoxPost.TabIndex = 9;
            this.comboBoxPost.Visible = false;
            // 
            // comboBoxTypeUser
            // 
            this.comboBoxTypeUser.AutoResize = false;
            this.comboBoxTypeUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxTypeUser.Depth = 0;
            this.comboBoxTypeUser.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxTypeUser.DropDownHeight = 174;
            this.comboBoxTypeUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTypeUser.DropDownWidth = 121;
            this.comboBoxTypeUser.Enabled = false;
            this.comboBoxTypeUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboBoxTypeUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboBoxTypeUser.FormattingEnabled = true;
            this.comboBoxTypeUser.Hint = "Выберете тип пользователя";
            this.comboBoxTypeUser.IntegralHeight = false;
            this.comboBoxTypeUser.ItemHeight = 43;
            this.comboBoxTypeUser.Items.AddRange(new object[] {
            "Клиент",
            "Сотрудник"});
            this.comboBoxTypeUser.Location = new System.Drawing.Point(18, 26);
            this.comboBoxTypeUser.MaxDropDownItems = 4;
            this.comboBoxTypeUser.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBoxTypeUser.Name = "comboBoxTypeUser";
            this.comboBoxTypeUser.Size = new System.Drawing.Size(322, 49);
            this.comboBoxTypeUser.StartIndex = 0;
            this.comboBoxTypeUser.TabIndex = 8;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.AnimateReadOnly = false;
            this.textBoxAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAddress.Depth = 0;
            this.textBoxAddress.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxAddress.Hint = "Адрес";
            this.textBoxAddress.LeadingIcon = null;
            this.textBoxAddress.Location = new System.Drawing.Point(18, 339);
            this.textBoxAddress.MaxLength = 50;
            this.textBoxAddress.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxAddress.Multiline = false;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(322, 50);
            this.textBoxAddress.TabIndex = 4;
            this.textBoxAddress.Text = "";
            this.textBoxAddress.TrailingIcon = null;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.AllowPromptAsInput = true;
            this.textBoxPhone.AnimateReadOnly = false;
            this.textBoxPhone.AsciiOnly = false;
            this.textBoxPhone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.textBoxPhone.BeepOnError = false;
            this.textBoxPhone.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.textBoxPhone.Depth = 0;
            this.textBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxPhone.HidePromptOnLeave = false;
            this.textBoxPhone.HideSelection = true;
            this.textBoxPhone.Hint = "Телефон";
            this.textBoxPhone.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.textBoxPhone.LeadingIcon = null;
            this.textBoxPhone.Location = new System.Drawing.Point(18, 285);
            this.textBoxPhone.Mask = "#(###) ###-####";
            this.textBoxPhone.MaxLength = 32767;
            this.textBoxPhone.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.PasswordChar = '\0';
            this.textBoxPhone.PrefixSuffixText = null;
            this.textBoxPhone.PromptChar = '_';
            this.textBoxPhone.ReadOnly = false;
            this.textBoxPhone.RejectInputOnFirstFailure = false;
            this.textBoxPhone.ResetOnPrompt = true;
            this.textBoxPhone.ResetOnSpace = true;
            this.textBoxPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxPhone.SelectedText = "";
            this.textBoxPhone.SelectionLength = 0;
            this.textBoxPhone.SelectionStart = 0;
            this.textBoxPhone.ShortcutsEnabled = true;
            this.textBoxPhone.Size = new System.Drawing.Size(322, 48);
            this.textBoxPhone.SkipLiterals = true;
            this.textBoxPhone.TabIndex = 3;
            this.textBoxPhone.TabStop = false;
            this.textBoxPhone.Text = " (   )    -";
            this.textBoxPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxPhone.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.textBoxPhone.TrailingIcon = null;
            this.textBoxPhone.UseSystemPasswordChar = false;
            this.textBoxPhone.ValidatingType = null;
            // 
            // textBoxPatronymic
            // 
            this.textBoxPatronymic.AnimateReadOnly = false;
            this.textBoxPatronymic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPatronymic.Depth = 0;
            this.textBoxPatronymic.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxPatronymic.Hint = "Отчество";
            this.textBoxPatronymic.LeadingIcon = null;
            this.textBoxPatronymic.Location = new System.Drawing.Point(18, 229);
            this.textBoxPatronymic.MaxLength = 50;
            this.textBoxPatronymic.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxPatronymic.Multiline = false;
            this.textBoxPatronymic.Name = "textBoxPatronymic";
            this.textBoxPatronymic.Size = new System.Drawing.Size(322, 50);
            this.textBoxPatronymic.TabIndex = 2;
            this.textBoxPatronymic.Text = "";
            this.textBoxPatronymic.TrailingIcon = null;
            // 
            // textBoxName
            // 
            this.textBoxName.AnimateReadOnly = false;
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxName.Depth = 0;
            this.textBoxName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxName.Hint = "Имя";
            this.textBoxName.LeadingIcon = null;
            this.textBoxName.Location = new System.Drawing.Point(18, 173);
            this.textBoxName.MaxLength = 50;
            this.textBoxName.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxName.Multiline = false;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(322, 50);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.Text = "";
            this.textBoxName.TrailingIcon = null;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.AnimateReadOnly = false;
            this.textBoxSurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSurname.Depth = 0;
            this.textBoxSurname.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxSurname.Hint = "Фамилия";
            this.textBoxSurname.LeadingIcon = null;
            this.textBoxSurname.Location = new System.Drawing.Point(18, 117);
            this.textBoxSurname.MaxLength = 50;
            this.textBoxSurname.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxSurname.Multiline = false;
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(322, 50);
            this.textBoxSurname.TabIndex = 0;
            this.textBoxSurname.Text = "";
            this.textBoxSurname.TrailingIcon = null;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.White;
            this.tabPage4.Controls.Add(this.labelCheckPassword);
            this.tabPage4.Controls.Add(this.labelCheckLogin);
            this.tabPage4.Controls.Add(this.bttCheck);
            this.tabPage4.Controls.Add(this.textBoxPassword2);
            this.tabPage4.Controls.Add(this.textBoxSecret);
            this.tabPage4.Controls.Add(this.textBoxPassword);
            this.tabPage4.Controls.Add(this.textBoxLogin);
            this.tabPage4.ImageKey = "lock.png";
            this.tabPage4.Location = new System.Drawing.Point(4, 39);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(925, 550);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Аунтификация";
            // 
            // labelCheckPassword
            // 
            this.labelCheckPassword.AutoSize = true;
            this.labelCheckPassword.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCheckPassword.ForeColor = System.Drawing.Color.Red;
            this.labelCheckPassword.Location = new System.Drawing.Point(344, 151);
            this.labelCheckPassword.Name = "labelCheckPassword";
            this.labelCheckPassword.Size = new System.Drawing.Size(188, 23);
            this.labelCheckPassword.TabIndex = 14;
            this.labelCheckPassword.Text = "Пароли не совпадают";
            this.labelCheckPassword.Visible = false;
            // 
            // labelCheckLogin
            // 
            this.labelCheckLogin.AutoSize = true;
            this.labelCheckLogin.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCheckLogin.ForeColor = System.Drawing.Color.Green;
            this.labelCheckLogin.Location = new System.Drawing.Point(344, 39);
            this.labelCheckLogin.Name = "labelCheckLogin";
            this.labelCheckLogin.Size = new System.Drawing.Size(134, 23);
            this.labelCheckLogin.TabIndex = 13;
            this.labelCheckLogin.Text = "Логин свободен";
            this.labelCheckLogin.Visible = false;
            // 
            // bttCheck
            // 
            this.bttCheck.AutoSize = false;
            this.bttCheck.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bttCheck.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bttCheck.Depth = 0;
            this.bttCheck.HighEmphasis = true;
            this.bttCheck.Icon = null;
            this.bttCheck.Location = new System.Drawing.Point(43, 265);
            this.bttCheck.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bttCheck.MouseState = MaterialSkin.MouseState.HOVER;
            this.bttCheck.Name = "bttCheck";
            this.bttCheck.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bttCheck.Size = new System.Drawing.Size(238, 36);
            this.bttCheck.TabIndex = 12;
            this.bttCheck.Text = "Проверить пароль";
            this.bttCheck.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bttCheck.UseAccentColor = false;
            this.bttCheck.UseVisualStyleBackColor = true;
            this.bttCheck.Click += new System.EventHandler(this.bttCheck_Click);
            // 
            // textBoxPassword2
            // 
            this.textBoxPassword2.AnimateReadOnly = false;
            this.textBoxPassword2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword2.Depth = 0;
            this.textBoxPassword2.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxPassword2.Hint = "Повторите пароль";
            this.textBoxPassword2.LeadingIcon = null;
            this.textBoxPassword2.Location = new System.Drawing.Point(16, 139);
            this.textBoxPassword2.MaxLength = 50;
            this.textBoxPassword2.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxPassword2.Multiline = false;
            this.textBoxPassword2.Name = "textBoxPassword2";
            this.textBoxPassword2.Password = true;
            this.textBoxPassword2.Size = new System.Drawing.Size(322, 50);
            this.textBoxPassword2.TabIndex = 11;
            this.textBoxPassword2.Text = "";
            this.textBoxPassword2.TrailingIcon = null;
            // 
            // textBoxSecret
            // 
            this.textBoxSecret.AnimateReadOnly = false;
            this.textBoxSecret.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSecret.Depth = 0;
            this.textBoxSecret.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxSecret.Hint = "Секретное слово";
            this.textBoxSecret.LeadingIcon = null;
            this.textBoxSecret.Location = new System.Drawing.Point(16, 206);
            this.textBoxSecret.MaxLength = 50;
            this.textBoxSecret.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxSecret.Multiline = false;
            this.textBoxSecret.Name = "textBoxSecret";
            this.textBoxSecret.Size = new System.Drawing.Size(322, 50);
            this.textBoxSecret.TabIndex = 10;
            this.textBoxSecret.Text = "";
            this.textBoxSecret.TrailingIcon = null;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.AnimateReadOnly = false;
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Depth = 0;
            this.textBoxPassword.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxPassword.Hint = "Пароль";
            this.textBoxPassword.LeadingIcon = null;
            this.textBoxPassword.Location = new System.Drawing.Point(16, 83);
            this.textBoxPassword.MaxLength = 50;
            this.textBoxPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxPassword.Multiline = false;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Password = true;
            this.textBoxPassword.Size = new System.Drawing.Size(322, 50);
            this.textBoxPassword.TabIndex = 9;
            this.textBoxPassword.Text = "";
            this.textBoxPassword.TrailingIcon = null;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.AnimateReadOnly = false;
            this.textBoxLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLogin.Depth = 0;
            this.textBoxLogin.Enabled = false;
            this.textBoxLogin.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxLogin.Hint = "Логин";
            this.textBoxLogin.LeadingIcon = null;
            this.textBoxLogin.Location = new System.Drawing.Point(16, 26);
            this.textBoxLogin.MaxLength = 50;
            this.textBoxLogin.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxLogin.Multiline = false;
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(322, 50);
            this.textBoxLogin.TabIndex = 8;
            this.textBoxLogin.Text = "";
            this.textBoxLogin.TrailingIcon = null;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.textBoxRelativeLink);
            this.tabPage2.Controls.Add(this.buttonAddPicture);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.textBoxLinkImage);
            this.tabPage2.ImageKey = "image.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(925, 550);
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
            this.textBoxRelativeLink.Location = new System.Drawing.Point(21, 83);
            this.textBoxRelativeLink.MaxLength = 50;
            this.textBoxRelativeLink.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxRelativeLink.Multiline = false;
            this.textBoxRelativeLink.Name = "textBoxRelativeLink";
            this.textBoxRelativeLink.Size = new System.Drawing.Size(470, 50);
            this.textBoxRelativeLink.TabIndex = 40;
            this.textBoxRelativeLink.Text = "";
            this.textBoxRelativeLink.TrailingIcon = null;
            // 
            // buttonAddPicture
            // 
            this.buttonAddPicture.AllowDrop = true;
            this.buttonAddPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddPicture.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddPicture.Location = new System.Drawing.Point(21, 172);
            this.buttonAddPicture.Name = "buttonAddPicture";
            this.buttonAddPicture.Size = new System.Drawing.Size(232, 200);
            this.buttonAddPicture.TabIndex = 39;
            this.buttonAddPicture.Text = "Drop image";
            this.buttonAddPicture.UseVisualStyleBackColor = true;
            this.buttonAddPicture.DragDrop += new System.Windows.Forms.DragEventHandler(this.buttonAddPicture_DragDrop);
            this.buttonAddPicture.DragEnter += new System.Windows.Forms.DragEventHandler(this.buttonAddPicture_DragEnter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BuildStore.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(291, 172);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
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
            this.textBoxLinkImage.Location = new System.Drawing.Point(21, 27);
            this.textBoxLinkImage.MaxLength = 50;
            this.textBoxLinkImage.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxLinkImage.Multiline = false;
            this.textBoxLinkImage.Name = "textBoxLinkImage";
            this.textBoxLinkImage.Size = new System.Drawing.Size(470, 50);
            this.textBoxLinkImage.TabIndex = 0;
            this.textBoxLinkImage.Text = "";
            this.textBoxLinkImage.TrailingIcon = null;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.bttEdit);
            this.tabPage3.Controls.Add(this.labelTypeUser);
            this.tabPage3.Controls.Add(this.labelPost);
            this.tabPage3.Controls.Add(this.labelLogin);
            this.tabPage3.Controls.Add(this.labelAddress);
            this.tabPage3.Controls.Add(this.labelPhone);
            this.tabPage3.Controls.Add(this.labelPatronymic);
            this.tabPage3.Controls.Add(this.labelSurname);
            this.tabPage3.Controls.Add(this.labelName);
            this.tabPage3.Controls.Add(this.pictureBox2);
            this.tabPage3.ImageKey = "send.png";
            this.tabPage3.Location = new System.Drawing.Point(4, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(925, 550);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Отправка";
            this.tabPage3.Paint += new System.Windows.Forms.PaintEventHandler(this.tabPage3_Paint);
            // 
            // bttEdit
            // 
            this.bttEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bttEdit.AutoSize = false;
            this.bttEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bttEdit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bttEdit.Depth = 0;
            this.bttEdit.HighEmphasis = true;
            this.bttEdit.Icon = null;
            this.bttEdit.Location = new System.Drawing.Point(284, 463);
            this.bttEdit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bttEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.bttEdit.Name = "bttEdit";
            this.bttEdit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bttEdit.Size = new System.Drawing.Size(291, 36);
            this.bttEdit.TabIndex = 9;
            this.bttEdit.Text = "Изменить";
            this.bttEdit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bttEdit.UseAccentColor = false;
            this.bttEdit.UseVisualStyleBackColor = true;
            this.bttEdit.Click += new System.EventHandler(this.bttEdit_Click);
            // 
            // labelTypeUser
            // 
            this.labelTypeUser.AutoSize = true;
            this.labelTypeUser.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTypeUser.Location = new System.Drawing.Point(71, 216);
            this.labelTypeUser.Name = "labelTypeUser";
            this.labelTypeUser.Size = new System.Drawing.Size(86, 29);
            this.labelTypeUser.TabIndex = 8;
            this.labelTypeUser.Text = "Клиент";
            // 
            // labelPost
            // 
            this.labelPost.AutoSize = true;
            this.labelPost.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPost.Location = new System.Drawing.Point(231, 187);
            this.labelPost.Name = "labelPost";
            this.labelPost.Size = new System.Drawing.Size(130, 29);
            this.labelPost.TabIndex = 7;
            this.labelPost.Text = "Должность:";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.Location = new System.Drawing.Point(231, 158);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(82, 29);
            this.labelLogin.TabIndex = 6;
            this.labelLogin.Text = "Логин:";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAddress.Location = new System.Drawing.Point(231, 129);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(80, 29);
            this.labelAddress.TabIndex = 5;
            this.labelAddress.Text = "Адрес:";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPhone.Location = new System.Drawing.Point(229, 100);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(110, 29);
            this.labelPhone.TabIndex = 4;
            this.labelPhone.Text = "Телефон:";
            // 
            // labelPatronymic
            // 
            this.labelPatronymic.AutoSize = true;
            this.labelPatronymic.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPatronymic.Location = new System.Drawing.Point(229, 71);
            this.labelPatronymic.Name = "labelPatronymic";
            this.labelPatronymic.Size = new System.Drawing.Size(112, 29);
            this.labelPatronymic.TabIndex = 3;
            this.labelPatronymic.Text = "Отчество:";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSurname.Location = new System.Drawing.Point(229, 42);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(109, 29);
            this.labelSurname.TabIndex = 2;
            this.labelSurname.Text = "Фамилия:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(229, 13);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(61, 29);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Имя:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BuildStore.Properties.Resources.user;
            this.pictureBox2.Location = new System.Drawing.Point(23, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 200);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // FormEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 660);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "FormEditUser";
            this.Text = "Редактирование пользователя";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEditUser_FormClosing);
            this.Load += new System.EventHandler(this.FormEditUser_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList2;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private MaterialSkin.Controls.MaterialComboBox comboBoxPost;
        private MaterialSkin.Controls.MaterialComboBox comboBoxTypeUser;
        private MaterialSkin.Controls.MaterialTextBox textBoxAddress;
        private MaterialSkin.Controls.MaterialMaskedTextBox textBoxPhone;
        private MaterialSkin.Controls.MaterialTextBox textBoxPatronymic;
        private MaterialSkin.Controls.MaterialTextBox textBoxName;
        private MaterialSkin.Controls.MaterialTextBox textBoxSurname;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label labelCheckPassword;
        private System.Windows.Forms.Label labelCheckLogin;
        private MaterialSkin.Controls.MaterialButton bttCheck;
        private MaterialSkin.Controls.MaterialTextBox textBoxPassword2;
        private MaterialSkin.Controls.MaterialTextBox textBoxSecret;
        private MaterialSkin.Controls.MaterialTextBox textBoxPassword;
        private MaterialSkin.Controls.MaterialTextBox textBoxLogin;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialTextBox textBoxRelativeLink;
        private System.Windows.Forms.Button buttonAddPicture;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialTextBox textBoxLinkImage;
        private System.Windows.Forms.TabPage tabPage3;
        private MaterialSkin.Controls.MaterialButton bttEdit;
        private System.Windows.Forms.Label labelTypeUser;
        private System.Windows.Forms.Label labelPost;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelPatronymic;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}