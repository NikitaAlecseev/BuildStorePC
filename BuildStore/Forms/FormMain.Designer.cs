namespace BuildStore.Forms
{
    partial class FormMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.main = new System.Windows.Forms.TabPage();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.materialComboBox4 = new MaterialSkin.Controls.MaterialComboBox();
            this.chartIncome = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialComboBox3 = new MaterialSkin.Controls.MaterialComboBox();
            this.chartCountOrder = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.Category = new System.Windows.Forms.TabPage();
            this.bttAddCategory = new MaterialSkin.Controls.MaterialButton();
            this.comboBoxCategory = new MaterialSkin.Controls.MaterialComboBox();
            this.flowLayoutCategory = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.Products = new System.Windows.Forms.TabPage();
            this.bttAddProduct = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.comboBoxProductUnderCategory = new MaterialSkin.Controls.MaterialComboBox();
            this.comboBoxProductMainCategory = new MaterialSkin.Controls.MaterialComboBox();
            this.textBoxTitleProduct = new MaterialSkin.Controls.MaterialTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Discount = new System.Windows.Forms.TabPage();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.listBoxDiscount = new MaterialSkin.Controls.MaterialListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Users = new System.Windows.Forms.TabPage();
            this.buttonAddUser = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.comboBoxPost = new MaterialSkin.Controls.MaterialComboBox();
            this.comboBoxTypeUser = new MaterialSkin.Controls.MaterialComboBox();
            this.textBoxPatronymic = new MaterialSkin.Controls.MaterialTextBox();
            this.textBoxName = new MaterialSkin.Controls.MaterialTextBox();
            this.textBoxSurname = new MaterialSkin.Controls.MaterialTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanelUsers = new System.Windows.Forms.FlowLayoutPanel();
            this.bttAddUser = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.Setting = new System.Windows.Forms.TabPage();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.materialTextBox5 = new MaterialSkin.Controls.MaterialTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timerUpdateUsers = new System.Windows.Forms.Timer(this.components);
            this.materialTabControl1.SuspendLayout();
            this.main.SuspendLayout();
            this.materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartIncome)).BeginInit();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCountOrder)).BeginInit();
            this.Category.SuspendLayout();
            this.Products.SuspendLayout();
            this.Discount.SuspendLayout();
            this.Users.SuspendLayout();
            this.Setting.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.main);
            this.materialTabControl1.Controls.Add(this.Category);
            this.materialTabControl1.Controls.Add(this.Products);
            this.materialTabControl1.Controls.Add(this.Discount);
            this.materialTabControl1.Controls.Add(this.Users);
            this.materialTabControl1.Controls.Add(this.Setting);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1314, 710);
            this.materialTabControl1.TabIndex = 0;
            // 
            // main
            // 
            this.main.BackColor = System.Drawing.Color.White;
            this.main.Controls.Add(this.materialCard2);
            this.main.Controls.Add(this.materialCard1);
            this.main.Controls.Add(this.label1);
            this.main.ForeColor = System.Drawing.Color.White;
            this.main.ImageKey = "home.png";
            this.main.Location = new System.Drawing.Point(4, 39);
            this.main.Name = "main";
            this.main.Padding = new System.Windows.Forms.Padding(3);
            this.main.Size = new System.Drawing.Size(1306, 667);
            this.main.TabIndex = 0;
            this.main.Text = "Главная";
            // 
            // materialCard2
            // 
            this.materialCard2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.materialComboBox4);
            this.materialCard2.Controls.Add(this.chartIncome);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(679, 50);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(610, 346);
            this.materialCard2.TabIndex = 4;
            // 
            // materialComboBox4
            // 
            this.materialComboBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialComboBox4.AutoResize = false;
            this.materialComboBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox4.Depth = 0;
            this.materialComboBox4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox4.DropDownHeight = 174;
            this.materialComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox4.DropDownWidth = 121;
            this.materialComboBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox4.FormattingEnabled = true;
            this.materialComboBox4.Hint = "Сортировка";
            this.materialComboBox4.IntegralHeight = false;
            this.materialComboBox4.ItemHeight = 43;
            this.materialComboBox4.Items.AddRange(new object[] {
            "За день",
            "За месяц",
            "За год"});
            this.materialComboBox4.Location = new System.Drawing.Point(28, 12);
            this.materialComboBox4.MaxDropDownItems = 4;
            this.materialComboBox4.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox4.Name = "materialComboBox4";
            this.materialComboBox4.Size = new System.Drawing.Size(425, 49);
            this.materialComboBox4.StartIndex = 0;
            this.materialComboBox4.TabIndex = 3;
            this.materialComboBox4.SelectedIndexChanged += new System.EventHandler(this.materialComboBox4_SelectedIndexChanged);
            // 
            // chartIncome
            // 
            chartArea5.Name = "ChartArea1";
            this.chartIncome.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartIncome.Legends.Add(legend5);
            this.chartIncome.Location = new System.Drawing.Point(0, 68);
            this.chartIncome.Name = "chartIncome";
            series5.BorderWidth = 3;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series5.Legend = "Legend1";
            series5.LegendText = "Заработок";
            series5.Name = "Series1";
            this.chartIncome.Series.Add(series5);
            this.chartIncome.Size = new System.Drawing.Size(600, 278);
            this.chartIncome.TabIndex = 1;
            this.chartIncome.Text = "chart1";
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.materialComboBox3);
            this.materialCard1.Controls.Add(this.chartCountOrder);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(10, 50);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(610, 346);
            this.materialCard1.TabIndex = 3;
            // 
            // materialComboBox3
            // 
            this.materialComboBox3.AutoResize = false;
            this.materialComboBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox3.Depth = 0;
            this.materialComboBox3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox3.DropDownHeight = 174;
            this.materialComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox3.DropDownWidth = 121;
            this.materialComboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox3.FormattingEnabled = true;
            this.materialComboBox3.Hint = "Сортировка";
            this.materialComboBox3.IntegralHeight = false;
            this.materialComboBox3.ItemHeight = 43;
            this.materialComboBox3.Items.AddRange(new object[] {
            "За день",
            "За месяц",
            "За год"});
            this.materialComboBox3.Location = new System.Drawing.Point(17, 13);
            this.materialComboBox3.MaxDropDownItems = 4;
            this.materialComboBox3.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox3.Name = "materialComboBox3";
            this.materialComboBox3.Size = new System.Drawing.Size(425, 49);
            this.materialComboBox3.StartIndex = 0;
            this.materialComboBox3.TabIndex = 2;
            this.materialComboBox3.SelectedIndexChanged += new System.EventHandler(this.materialComboBox3_SelectedIndexChanged);
            // 
            // chartCountOrder
            // 
            chartArea6.Name = "ChartArea1";
            this.chartCountOrder.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartCountOrder.Legends.Add(legend6);
            this.chartCountOrder.Location = new System.Drawing.Point(0, 68);
            this.chartCountOrder.Name = "chartCountOrder";
            series6.BorderWidth = 3;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series6.Legend = "Legend1";
            series6.LegendText = "Кол заказов";
            series6.Name = "Series1";
            this.chartCountOrder.Series.Add(series6);
            this.chartCountOrder.Size = new System.Drawing.Size(600, 278);
            this.chartCountOrder.TabIndex = 1;
            this.chartCountOrder.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Главная";
            // 
            // Category
            // 
            this.Category.BackColor = System.Drawing.Color.White;
            this.Category.Controls.Add(this.bttAddCategory);
            this.Category.Controls.Add(this.comboBoxCategory);
            this.Category.Controls.Add(this.flowLayoutCategory);
            this.Category.Controls.Add(this.label5);
            this.Category.ImageKey = "category.png";
            this.Category.Location = new System.Drawing.Point(4, 39);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(1306, 667);
            this.Category.TabIndex = 4;
            this.Category.Text = "Категории";
            this.Category.Paint += new System.Windows.Forms.PaintEventHandler(this.Category_Paint);
            // 
            // bttAddCategory
            // 
            this.bttAddCategory.AutoSize = false;
            this.bttAddCategory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bttAddCategory.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bttAddCategory.Depth = 0;
            this.bttAddCategory.HighEmphasis = true;
            this.bttAddCategory.Icon = null;
            this.bttAddCategory.Location = new System.Drawing.Point(280, 27);
            this.bttAddCategory.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bttAddCategory.MouseState = MaterialSkin.MouseState.HOVER;
            this.bttAddCategory.Name = "bttAddCategory";
            this.bttAddCategory.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bttAddCategory.Size = new System.Drawing.Size(197, 48);
            this.bttAddCategory.TabIndex = 8;
            this.bttAddCategory.Text = "Добавить категорию";
            this.bttAddCategory.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bttAddCategory.UseAccentColor = false;
            this.bttAddCategory.UseVisualStyleBackColor = true;
            this.bttAddCategory.Click += new System.EventHandler(this.bttAddCategory_Click);
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
            this.comboBoxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboBoxCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Hint = "Выбор категории";
            this.comboBoxCategory.IntegralHeight = false;
            this.comboBoxCategory.ItemHeight = 43;
            this.comboBoxCategory.Items.AddRange(new object[] {
            "Главные категории"});
            this.comboBoxCategory.Location = new System.Drawing.Point(7, 27);
            this.comboBoxCategory.MaxDropDownItems = 4;
            this.comboBoxCategory.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(266, 49);
            this.comboBoxCategory.StartIndex = 0;
            this.comboBoxCategory.TabIndex = 3;
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged);
            // 
            // flowLayoutCategory
            // 
            this.flowLayoutCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutCategory.Location = new System.Drawing.Point(7, 87);
            this.flowLayoutCategory.Name = "flowLayoutCategory";
            this.flowLayoutCategory.Size = new System.Drawing.Size(1293, 566);
            this.flowLayoutCategory.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Категории";
            // 
            // Products
            // 
            this.Products.BackColor = System.Drawing.Color.White;
            this.Products.Controls.Add(this.bttAddProduct);
            this.Products.Controls.Add(this.flowLayoutPanel1);
            this.Products.Controls.Add(this.comboBoxProductUnderCategory);
            this.Products.Controls.Add(this.comboBoxProductMainCategory);
            this.Products.Controls.Add(this.textBoxTitleProduct);
            this.Products.Controls.Add(this.label2);
            this.Products.ForeColor = System.Drawing.Color.White;
            this.Products.ImageKey = "product.png";
            this.Products.Location = new System.Drawing.Point(4, 39);
            this.Products.Name = "Products";
            this.Products.Padding = new System.Windows.Forms.Padding(3);
            this.Products.Size = new System.Drawing.Size(1306, 667);
            this.Products.TabIndex = 1;
            this.Products.Text = "Товары";
            this.Products.Paint += new System.Windows.Forms.PaintEventHandler(this.Products_Paint);
            // 
            // bttAddProduct
            // 
            this.bttAddProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttAddProduct.Depth = 0;
            this.bttAddProduct.Icon = global::BuildStore.Properties.Resources.add;
            this.bttAddProduct.Location = new System.Drawing.Point(1207, 577);
            this.bttAddProduct.MouseState = MaterialSkin.MouseState.HOVER;
            this.bttAddProduct.Name = "bttAddProduct";
            this.bttAddProduct.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bttAddProduct.Size = new System.Drawing.Size(56, 56);
            this.bttAddProduct.TabIndex = 2;
            this.bttAddProduct.Text = "+";
            this.bttAddProduct.UseVisualStyleBackColor = true;
            this.bttAddProduct.Click += new System.EventHandler(this.bttAddProduct_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(7, 102);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1293, 559);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // comboBoxProductUnderCategory
            // 
            this.comboBoxProductUnderCategory.AutoResize = false;
            this.comboBoxProductUnderCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxProductUnderCategory.Depth = 0;
            this.comboBoxProductUnderCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxProductUnderCategory.DropDownHeight = 174;
            this.comboBoxProductUnderCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProductUnderCategory.DropDownWidth = 121;
            this.comboBoxProductUnderCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboBoxProductUnderCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboBoxProductUnderCategory.FormattingEnabled = true;
            this.comboBoxProductUnderCategory.Hint = "Под категория";
            this.comboBoxProductUnderCategory.IntegralHeight = false;
            this.comboBoxProductUnderCategory.ItemHeight = 43;
            this.comboBoxProductUnderCategory.Location = new System.Drawing.Point(565, 31);
            this.comboBoxProductUnderCategory.MaxDropDownItems = 4;
            this.comboBoxProductUnderCategory.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBoxProductUnderCategory.Name = "comboBoxProductUnderCategory";
            this.comboBoxProductUnderCategory.Size = new System.Drawing.Size(290, 49);
            this.comboBoxProductUnderCategory.StartIndex = 0;
            this.comboBoxProductUnderCategory.TabIndex = 5;
            this.comboBoxProductUnderCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxProductUnderCategory_SelectedIndexChanged);
            // 
            // comboBoxProductMainCategory
            // 
            this.comboBoxProductMainCategory.AutoResize = false;
            this.comboBoxProductMainCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxProductMainCategory.Depth = 0;
            this.comboBoxProductMainCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxProductMainCategory.DropDownHeight = 174;
            this.comboBoxProductMainCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProductMainCategory.DropDownWidth = 121;
            this.comboBoxProductMainCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboBoxProductMainCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboBoxProductMainCategory.FormattingEnabled = true;
            this.comboBoxProductMainCategory.Hint = "Категория";
            this.comboBoxProductMainCategory.IntegralHeight = false;
            this.comboBoxProductMainCategory.ItemHeight = 43;
            this.comboBoxProductMainCategory.Location = new System.Drawing.Point(290, 30);
            this.comboBoxProductMainCategory.MaxDropDownItems = 4;
            this.comboBoxProductMainCategory.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBoxProductMainCategory.Name = "comboBoxProductMainCategory";
            this.comboBoxProductMainCategory.Size = new System.Drawing.Size(257, 49);
            this.comboBoxProductMainCategory.StartIndex = 0;
            this.comboBoxProductMainCategory.TabIndex = 4;
            this.comboBoxProductMainCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxProductMainCategory_SelectedIndexChanged);
            // 
            // textBoxTitleProduct
            // 
            this.textBoxTitleProduct.AnimateReadOnly = false;
            this.textBoxTitleProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTitleProduct.Depth = 0;
            this.textBoxTitleProduct.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxTitleProduct.Hint = "Поиск";
            this.textBoxTitleProduct.LeadingIcon = null;
            this.textBoxTitleProduct.Location = new System.Drawing.Point(7, 30);
            this.textBoxTitleProduct.MaxLength = 50;
            this.textBoxTitleProduct.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxTitleProduct.Multiline = false;
            this.textBoxTitleProduct.Name = "textBoxTitleProduct";
            this.textBoxTitleProduct.Size = new System.Drawing.Size(255, 50);
            this.textBoxTitleProduct.TabIndex = 3;
            this.textBoxTitleProduct.Text = "";
            this.textBoxTitleProduct.TrailingIcon = null;
            this.textBoxTitleProduct.TextChanged += new System.EventHandler(this.textBoxTitleProduct_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Товары";
            // 
            // Discount
            // 
            this.Discount.BackColor = System.Drawing.Color.White;
            this.Discount.Controls.Add(this.materialButton1);
            this.Discount.Controls.Add(this.listBoxDiscount);
            this.Discount.Controls.Add(this.label6);
            this.Discount.ImageKey = "discount.png";
            this.Discount.Location = new System.Drawing.Point(4, 39);
            this.Discount.Name = "Discount";
            this.Discount.Size = new System.Drawing.Size(1306, 667);
            this.Discount.TabIndex = 5;
            this.Discount.Text = "Скидки";
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(7, 30);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(211, 47);
            this.materialButton1.TabIndex = 4;
            this.materialButton1.Text = "Добавить скидку";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // listBoxDiscount
            // 
            this.listBoxDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxDiscount.BackColor = System.Drawing.Color.White;
            this.listBoxDiscount.BorderColor = System.Drawing.Color.LightGray;
            this.listBoxDiscount.Depth = 0;
            this.listBoxDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.listBoxDiscount.Location = new System.Drawing.Point(7, 83);
            this.listBoxDiscount.MouseState = MaterialSkin.MouseState.HOVER;
            this.listBoxDiscount.Name = "listBoxDiscount";
            this.listBoxDiscount.SelectedIndex = -1;
            this.listBoxDiscount.SelectedItem = null;
            this.listBoxDiscount.Size = new System.Drawing.Size(1296, 581);
            this.listBoxDiscount.TabIndex = 3;
            this.listBoxDiscount.SelectedIndexChanged += new MaterialSkin.Controls.MaterialListBox.SelectedIndexChangedEventHandler(this.listBoxDiscount_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "Скидки";
            // 
            // Users
            // 
            this.Users.BackColor = System.Drawing.Color.White;
            this.Users.Controls.Add(this.buttonAddUser);
            this.Users.Controls.Add(this.comboBoxPost);
            this.Users.Controls.Add(this.comboBoxTypeUser);
            this.Users.Controls.Add(this.textBoxPatronymic);
            this.Users.Controls.Add(this.textBoxName);
            this.Users.Controls.Add(this.textBoxSurname);
            this.Users.Controls.Add(this.label3);
            this.Users.Controls.Add(this.flowLayoutPanelUsers);
            this.Users.Controls.Add(this.bttAddUser);
            this.Users.ImageKey = "user.png";
            this.Users.Location = new System.Drawing.Point(4, 39);
            this.Users.Name = "Users";
            this.Users.Size = new System.Drawing.Size(1306, 667);
            this.Users.TabIndex = 3;
            this.Users.Text = "Пользователи";
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddUser.Depth = 0;
            this.buttonAddUser.Icon = global::BuildStore.Properties.Resources.add;
            this.buttonAddUser.Location = new System.Drawing.Point(1207, 577);
            this.buttonAddUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonAddUser.Size = new System.Drawing.Size(56, 56);
            this.buttonAddUser.TabIndex = 12;
            this.buttonAddUser.Text = "+";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
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
            this.comboBoxPost.Items.AddRange(new object[] {
            "Все"});
            this.comboBoxPost.Location = new System.Drawing.Point(981, 27);
            this.comboBoxPost.MaxDropDownItems = 4;
            this.comboBoxPost.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBoxPost.Name = "comboBoxPost";
            this.comboBoxPost.Size = new System.Drawing.Size(229, 49);
            this.comboBoxPost.StartIndex = 0;
            this.comboBoxPost.TabIndex = 11;
            this.comboBoxPost.Visible = false;
            this.comboBoxPost.SelectedIndexChanged += new System.EventHandler(this.comboBoxPost_SelectedIndexChanged);
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
            this.comboBoxTypeUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboBoxTypeUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboBoxTypeUser.FormattingEnabled = true;
            this.comboBoxTypeUser.Hint = "Тип пользователя";
            this.comboBoxTypeUser.IntegralHeight = false;
            this.comboBoxTypeUser.ItemHeight = 43;
            this.comboBoxTypeUser.Items.AddRange(new object[] {
            "Клиент",
            "Сотрудник"});
            this.comboBoxTypeUser.Location = new System.Drawing.Point(729, 27);
            this.comboBoxTypeUser.MaxDropDownItems = 4;
            this.comboBoxTypeUser.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBoxTypeUser.Name = "comboBoxTypeUser";
            this.comboBoxTypeUser.Size = new System.Drawing.Size(230, 49);
            this.comboBoxTypeUser.StartIndex = 0;
            this.comboBoxTypeUser.TabIndex = 9;
            this.comboBoxTypeUser.SelectedIndexChanged += new System.EventHandler(this.comboBoxTypeUser_SelectedIndexChanged);
            // 
            // textBoxPatronymic
            // 
            this.textBoxPatronymic.AnimateReadOnly = false;
            this.textBoxPatronymic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPatronymic.Depth = 0;
            this.textBoxPatronymic.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxPatronymic.Hint = "Поиск по отчеству";
            this.textBoxPatronymic.LeadingIcon = null;
            this.textBoxPatronymic.Location = new System.Drawing.Point(479, 27);
            this.textBoxPatronymic.MaxLength = 50;
            this.textBoxPatronymic.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxPatronymic.Multiline = false;
            this.textBoxPatronymic.Name = "textBoxPatronymic";
            this.textBoxPatronymic.Size = new System.Drawing.Size(230, 50);
            this.textBoxPatronymic.TabIndex = 6;
            this.textBoxPatronymic.Text = "";
            this.textBoxPatronymic.TrailingIcon = null;
            this.textBoxPatronymic.TextChanged += new System.EventHandler(this.textBoxPatronymic_TextChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.AnimateReadOnly = false;
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxName.Depth = 0;
            this.textBoxName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxName.Hint = "Поиск по имени";
            this.textBoxName.LeadingIcon = null;
            this.textBoxName.Location = new System.Drawing.Point(243, 27);
            this.textBoxName.MaxLength = 50;
            this.textBoxName.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxName.Multiline = false;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(230, 50);
            this.textBoxName.TabIndex = 5;
            this.textBoxName.Text = "";
            this.textBoxName.TrailingIcon = null;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.AnimateReadOnly = false;
            this.textBoxSurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSurname.Depth = 0;
            this.textBoxSurname.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxSurname.Hint = "Поиск по фамилии";
            this.textBoxSurname.LeadingIcon = null;
            this.textBoxSurname.Location = new System.Drawing.Point(7, 27);
            this.textBoxSurname.MaxLength = 50;
            this.textBoxSurname.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxSurname.Multiline = false;
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(230, 50);
            this.textBoxSurname.TabIndex = 4;
            this.textBoxSurname.Text = "";
            this.textBoxSurname.TrailingIcon = null;
            this.textBoxSurname.TextChanged += new System.EventHandler(this.textBoxSurname_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Пользователи";
            // 
            // flowLayoutPanelUsers
            // 
            this.flowLayoutPanelUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelUsers.AutoScroll = true;
            this.flowLayoutPanelUsers.Location = new System.Drawing.Point(7, 83);
            this.flowLayoutPanelUsers.Name = "flowLayoutPanelUsers";
            this.flowLayoutPanelUsers.Size = new System.Drawing.Size(1296, 581);
            this.flowLayoutPanelUsers.TabIndex = 8;
            // 
            // bttAddUser
            // 
            this.bttAddUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttAddUser.Depth = 0;
            this.bttAddUser.Icon = global::BuildStore.Properties.Resources.add;
            this.bttAddUser.Location = new System.Drawing.Point(1207, 577);
            this.bttAddUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.bttAddUser.Name = "bttAddUser";
            this.bttAddUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bttAddUser.Size = new System.Drawing.Size(56, 56);
            this.bttAddUser.TabIndex = 10;
            this.bttAddUser.Text = "+";
            this.bttAddUser.UseVisualStyleBackColor = true;
            this.bttAddUser.Click += new System.EventHandler(this.bttAddUser_Click);
            // 
            // Setting
            // 
            this.Setting.BackColor = System.Drawing.Color.White;
            this.Setting.Controls.Add(this.materialButton2);
            this.Setting.Controls.Add(this.materialTextBox5);
            this.Setting.Controls.Add(this.label4);
            this.Setting.ImageKey = "settings.png";
            this.Setting.Location = new System.Drawing.Point(4, 39);
            this.Setting.Name = "Setting";
            this.Setting.Size = new System.Drawing.Size(1306, 667);
            this.Setting.TabIndex = 2;
            this.Setting.Text = "Настройки";
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSize = false;
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(7, 116);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(261, 47);
            this.materialButton2.TabIndex = 5;
            this.materialButton2.Text = "Выйти из аккаунта";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            // 
            // materialTextBox5
            // 
            this.materialTextBox5.AnimateReadOnly = false;
            this.materialTextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox5.Depth = 0;
            this.materialTextBox5.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox5.Hint = "Ограничение данных (MAX)";
            this.materialTextBox5.LeadingIcon = null;
            this.materialTextBox5.Location = new System.Drawing.Point(7, 45);
            this.materialTextBox5.MaxLength = 50;
            this.materialTextBox5.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox5.Multiline = false;
            this.materialTextBox5.Name = "materialTextBox5";
            this.materialTextBox5.Size = new System.Drawing.Size(261, 50);
            this.materialTextBox5.TabIndex = 4;
            this.materialTextBox5.Text = "";
            this.materialTextBox5.TrailingIcon = null;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Настройки";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "home.png");
            this.imageList1.Images.SetKeyName(1, "product.png");
            this.imageList1.Images.SetKeyName(2, "settings.png");
            this.imageList1.Images.SetKeyName(3, "user.png");
            this.imageList1.Images.SetKeyName(4, "category.png");
            this.imageList1.Images.SetKeyName(5, "discount.png");
            // 
            // timerUpdateUsers
            // 
            this.timerUpdateUsers.Interval = 500;
            this.timerUpdateUsers.Tick += new System.EventHandler(this.timerUpdateUsers_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 777);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(0, 64, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Администрирование";
            this.materialTabControl1.ResumeLayout(false);
            this.main.ResumeLayout(false);
            this.main.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartIncome)).EndInit();
            this.materialCard1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartCountOrder)).EndInit();
            this.Category.ResumeLayout(false);
            this.Category.PerformLayout();
            this.Products.ResumeLayout(false);
            this.Products.PerformLayout();
            this.Discount.ResumeLayout(false);
            this.Discount.PerformLayout();
            this.Users.ResumeLayout(false);
            this.Users.PerformLayout();
            this.Setting.ResumeLayout(false);
            this.Setting.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage main;
        private System.Windows.Forms.TabPage Products;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage Setting;
        private System.Windows.Forms.TabPage Users;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialFloatingActionButton bttAddProduct;
        private MaterialSkin.Controls.MaterialComboBox comboBoxProductUnderCategory;
        private MaterialSkin.Controls.MaterialComboBox comboBoxProductMainCategory;
        private MaterialSkin.Controls.MaterialTextBox textBoxTitleProduct;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MaterialSkin.Controls.MaterialTextBox textBoxPatronymic;
        private MaterialSkin.Controls.MaterialTextBox textBoxName;
        private MaterialSkin.Controls.MaterialTextBox textBoxSurname;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelUsers;
        private MaterialSkin.Controls.MaterialComboBox comboBoxTypeUser;
        private MaterialSkin.Controls.MaterialFloatingActionButton bttAddUser;
        private MaterialSkin.Controls.MaterialComboBox comboBoxPost;
        private System.Windows.Forms.Timer timerUpdateUsers;
        private System.Windows.Forms.TabPage Category;
        private System.Windows.Forms.Label label5;
        private MaterialSkin.Controls.MaterialComboBox comboBoxCategory;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutCategory;
        private MaterialSkin.Controls.MaterialButton bttAddCategory;
        private MaterialSkin.Controls.MaterialFloatingActionButton buttonAddUser;
        private System.Windows.Forms.TabPage Discount;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialListBox listBoxDiscount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCountOrder;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartIncome;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox4;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox3;
        private MaterialSkin.Controls.MaterialButton materialButton2;
    }
}