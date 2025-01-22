namespace BuildStore.Tiles
{
    partial class TileUser
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelPatronymic = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.label4 = new MaterialSkin.Controls.MaterialLabel();
            this.label3 = new MaterialSkin.Controls.MaterialLabel();
            this.label2 = new MaterialSkin.Controls.MaterialLabel();
            this.labelPost = new MaterialSkin.Controls.MaterialLabel();
            this.labelPhone = new MaterialSkin.Controls.MaterialLabel();
            this.labelName = new MaterialSkin.Controls.MaterialLabel();
            this.labelSurname = new MaterialSkin.Controls.MaterialLabel();
            this.label1 = new MaterialSkin.Controls.MaterialLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::BuildStore.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(41, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(172)))));
            this.panel1.Controls.Add(this.labelPatronymic);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.labelPost);
            this.panel1.Controls.Add(this.labelPhone);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Controls.Add(this.labelSurname);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 241);
            this.panel1.TabIndex = 2;
            // 
            // labelPatronymic
            // 
            this.labelPatronymic.AutoSize = true;
            this.labelPatronymic.Depth = 0;
            this.labelPatronymic.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelPatronymic.Location = new System.Drawing.Point(6, 122);
            this.labelPatronymic.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelPatronymic.Name = "labelPatronymic";
            this.labelPatronymic.Size = new System.Drawing.Size(74, 19);
            this.labelPatronymic.TabIndex = 9;
            this.labelPatronymic.Text = "Фамилия:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(5, 95);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(89, 24);
            this.materialLabel1.TabIndex = 8;
            this.materialLabel1.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Depth = 0;
            this.label4.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label4.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.label4.Location = new System.Drawing.Point(5, 184);
            this.label4.MouseState = MaterialSkin.MouseState.HOVER;
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Должность";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Depth = 0;
            this.label3.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label3.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.label3.Location = new System.Drawing.Point(5, 141);
            this.label3.MouseState = MaterialSkin.MouseState.HOVER;
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Телефон";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Depth = 0;
            this.label2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.label2.Location = new System.Drawing.Point(5, 52);
            this.label2.MouseState = MaterialSkin.MouseState.HOVER;
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Имя";
            // 
            // labelPost
            // 
            this.labelPost.AutoSize = true;
            this.labelPost.Depth = 0;
            this.labelPost.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelPost.Location = new System.Drawing.Point(6, 208);
            this.labelPost.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelPost.Name = "labelPost";
            this.labelPost.Size = new System.Drawing.Size(47, 19);
            this.labelPost.TabIndex = 4;
            this.labelPost.Text = "Долж:";
            this.labelPost.Visible = false;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Depth = 0;
            this.labelPhone.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelPhone.Location = new System.Drawing.Point(6, 165);
            this.labelPhone.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(32, 19);
            this.labelPhone.TabIndex = 3;
            this.labelPhone.Text = "Тел:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Depth = 0;
            this.labelName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelName.Location = new System.Drawing.Point(6, 76);
            this.labelName.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(74, 19);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Фамилия:";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Depth = 0;
            this.labelSurname.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelSurname.Location = new System.Drawing.Point(6, 33);
            this.labelSurname.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(70, 19);
            this.labelSurname.TabIndex = 1;
            this.labelSurname.Text = "Фамилия";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Depth = 0;
            this.label1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.MouseState = MaterialSkin.MouseState.HOVER;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 86);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(180, 30);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 30);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // TileUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::BuildStore.Properties.Resources.productCart;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "TileUser";
            this.Size = new System.Drawing.Size(200, 378);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel label1;
        private MaterialSkin.Controls.MaterialLabel labelPhone;
        private MaterialSkin.Controls.MaterialLabel labelName;
        private MaterialSkin.Controls.MaterialLabel labelSurname;
        private MaterialSkin.Controls.MaterialLabel labelPost;
        private MaterialSkin.Controls.MaterialLabel label2;
        private MaterialSkin.Controls.MaterialLabel label4;
        private MaterialSkin.Controls.MaterialLabel label3;
        private MaterialSkin.Controls.MaterialLabel labelPatronymic;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}
