namespace BuildStore.Tiles
{
    partial class TileProduct
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
            this.labelTitle = new MaterialSkin.Controls.MaterialLabel();
            this.labelCost = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.labelUnderCategory = new System.Windows.Forms.Label();
            this.labelMainCategory = new System.Windows.Forms.Label();
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
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::BuildStore.Properties.Resources.box_icon;
            this.pictureBox1.Location = new System.Drawing.Point(40, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelTitle
            // 
            this.labelTitle.Depth = 0;
            this.labelTitle.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelTitle.Location = new System.Drawing.Point(3, 9);
            this.labelTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(191, 24);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "Название";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelCost
            // 
            this.labelCost.Depth = 0;
            this.labelCost.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelCost.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelCost.Location = new System.Drawing.Point(7, 123);
            this.labelCost.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(187, 24);
            this.labelCost.TabIndex = 4;
            this.labelCost.Text = "250.00 руб";
            this.labelCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(172)))));
            this.panel1.Controls.Add(this.labelDiscount);
            this.panel1.Controls.Add(this.labelUnderCategory);
            this.panel1.Controls.Add(this.labelMainCategory);
            this.panel1.Controls.Add(this.labelCost);
            this.panel1.Controls.Add(this.labelTitle);
            this.panel1.Location = new System.Drawing.Point(3, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 157);
            this.panel1.TabIndex = 5;
            // 
            // labelDiscount
            // 
            this.labelDiscount.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDiscount.ForeColor = System.Drawing.Color.Black;
            this.labelDiscount.Location = new System.Drawing.Point(0, 88);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(194, 23);
            this.labelDiscount.TabIndex = 8;
            this.labelDiscount.Text = "Скидка";
            this.labelDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelUnderCategory
            // 
            this.labelUnderCategory.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUnderCategory.ForeColor = System.Drawing.Color.Black;
            this.labelUnderCategory.Location = new System.Drawing.Point(0, 65);
            this.labelUnderCategory.Name = "labelUnderCategory";
            this.labelUnderCategory.Size = new System.Drawing.Size(194, 23);
            this.labelUnderCategory.TabIndex = 7;
            this.labelUnderCategory.Text = "под кат:";
            this.labelUnderCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMainCategory
            // 
            this.labelMainCategory.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMainCategory.ForeColor = System.Drawing.Color.Black;
            this.labelMainCategory.Location = new System.Drawing.Point(0, 42);
            this.labelMainCategory.Name = "labelMainCategory";
            this.labelMainCategory.Size = new System.Drawing.Size(191, 23);
            this.labelMainCategory.TabIndex = 5;
            this.labelMainCategory.Text = "Категория";
            this.labelMainCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // TileProduct
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
            this.Name = "TileProduct";
            this.Size = new System.Drawing.Size(200, 300);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel labelTitle;
        private MaterialSkin.Controls.MaterialLabel labelCost;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelUnderCategory;
        private System.Windows.Forms.Label labelMainCategory;
        private System.Windows.Forms.Label labelDiscount;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}
