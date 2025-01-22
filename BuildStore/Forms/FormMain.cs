using BuildStore.Core;
using BuildStore.Models;
using BuildStore.Tiles;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuildStore.Forms
{
    public partial class FormMain : MaterialForm
    {
        public FormMain()
        {
            InitializeComponent();
            LoadClients();
            LoadPosts();
            LoadProducts();
            LoadDiscount();
            LoadMainCategory();
            TestLoadChart();
        }

        private void TestLoadChart()
        {
            chartCountOrder.Series["Series1"].Points.AddXY(1, 0);
            chartCountOrder.Series["Series1"].Points.AddXY(2, 20);
            chartCountOrder.Series["Series1"].Points.AddXY(3, 20);
            chartCountOrder.Series["Series1"].Points.AddXY(4, 12);
            chartCountOrder.Series["Series1"].Points.AddXY(5, 15);
            chartCountOrder.Series["Series1"].Points.AddXY(6, 0);

            chartIncome.Series["Series1"].Points.AddXY(1, 0);
            chartIncome.Series["Series1"].Points.AddXY(2, 12000);
            chartIncome.Series["Series1"].Points.AddXY(3, 15000);
            chartIncome.Series["Series1"].Points.AddXY(4, 4000);
            chartIncome.Series["Series1"].Points.AddXY(5, 8000);
            chartIncome.Series["Series1"].Points.AddXY(6, 0);
        }

        private void bttAddProduct_Click(object sender, EventArgs e)
        {
            FormAddProduct form = new FormAddProduct();
            form.Show();
        }

        private void LoadProducts()
        {
            flowLayoutPanel1.Controls.Clear();
            CommandDB command = new CommandDB();
            command.LoadData($"Select ID_Product,TitleProduct,Description,Cost,Products.Image,TitleMainCategory,TitleUnderCategory,TitleDiscount From Products Inner Join UnderCategory On UnderCategory.ID_UnderCategory = Products.id_underCategory Inner Join MainCategory On MainCategory.ID_MainCategory = UnderCategory.id_mainCategory Inner Join Discount On Discount.ID_Discount = Products.id_discount Where TitleProduct like '%{textBoxTitleProduct.Text}%' AND TitleMainCategory like '%{comboBoxProductMainCategory.Text}%' AND TitleUnderCategory like '%{comboBoxProductUnderCategory.Text}%';");
            for(int i = 0; i < command.MainTable.Rows.Count; i++) // загрузка товаров
            {
                Products products = new Products();
                products.Id = command.MainTable.Rows[i][0].ToString();
                products.TitleProduct = command.MainTable.Rows[i][1].ToString();
                products.DescriptionProduct = command.MainTable.Rows[i][2].ToString();
                products.Cost = command.MainTable.Rows[i][3].ToString();
                products.Image = command.MainTable.Rows[i][4].ToString();
                products.TitleMainCategory = command.MainTable.Rows[i][5].ToString();
                products.TitleUnderCategory = command.MainTable.Rows[i][6].ToString();
                products.TitleDiscount = command.MainTable.Rows[i][7].ToString();

                TileProduct tile = new TileProduct();
                tile.LoadData(products);
                flowLayoutPanel1.Controls.Add(tile);
            }
        }
        private void LoadPosts()
        {
            CommandDB command = new CommandDB();
            command.LoadData("Select TitlePost From Posts");
            for(int i = 0; i < command.MainTable.Rows.Count; i++)
            {
                comboBoxPost.Items.Add(command.MainTable.Rows[i][0].ToString());
            }
        }

        private void LoadEmployee()
        {
            flowLayoutPanelUsers.Controls.Clear();

            CommandDB command = new CommandDB();
            string _postUser = "";
            if(comboBoxPost.Text != "Все")
            {
                _postUser = comboBoxPost.Text;
            }

            string _query = $"Select ID_Employee,Surname,Name,Patronymic,Phone,Address,Image,Login,Password,Secret,TitlePost From Employee  Inner join Posts On Posts.ID_Post = Employee.id_post Inner join Authentication On Authentication.ID_Authentication = Employee.id_authentication Where Surname like '%{textBoxSurname.Text}%' And Name like'%{textBoxName.Text}%' And Patronymic like '%{textBoxPatronymic.Text}%' And TitlePost like '%{_postUser}%';";
            command.LoadData(_query);

            for (int i = 0; i < command.MainTable.Rows.Count; i++)
            {
                Users user = new Users();
                user.Id = command.MainTable.Rows[i][0].ToString();
                user.Surname = command.MainTable.Rows[i][1].ToString();
                user.Name = command.MainTable.Rows[i][2].ToString();
                user.Patronymic = command.MainTable.Rows[i][3].ToString();
                user.Phone = command.MainTable.Rows[i][4].ToString();
                user.Address = command.MainTable.Rows[i][5].ToString();
                user.Image = command.MainTable.Rows[i][6].ToString();
                user.Login = command.MainTable.Rows[i][7].ToString();
                user.Password = command.MainTable.Rows[i][8].ToString();
                user.Secret = command.MainTable.Rows[i][9].ToString();
                user.Post = command.MainTable.Rows[i][10].ToString();

                TileUser tile = new TileUser();
                tile.LoadData(user);
                flowLayoutPanelUsers.Controls.Add(tile);
            }
        }
        private void LoadClients()
        {
            flowLayoutPanelUsers.Controls.Clear();

            CommandDB command = new CommandDB();
            string _query = $"Select ID_Client,Surname,Name,Patronymic,Phone,Address,Image,Login,Password,Secret From Clients Inner Join Authentication On Authentication.ID_Authentication = Clients.id_authentication Where Surname like '%{textBoxSurname.Text}%' AND Name like '%{textBoxName.Text}%' AND Patronymic like '%{textBoxPatronymic.Text}%';";
            command.LoadData(_query);

            for (int i = 0; i < command.MainTable.Rows.Count; i++)
            {
                Users user = new Users();
                user.Id = command.MainTable.Rows[i][0].ToString();
                user.Surname = command.MainTable.Rows[i][1].ToString();
                user.Name = command.MainTable.Rows[i][2].ToString();
                user.Patronymic = command.MainTable.Rows[i][3].ToString();
                user.Phone = command.MainTable.Rows[i][4].ToString();
                user.Address = command.MainTable.Rows[i][5].ToString();
                user.Image = command.MainTable.Rows[i][6].ToString();
                user.Login = command.MainTable.Rows[i][7].ToString();
                user.Password = command.MainTable.Rows[i][8].ToString();
                user.Secret = command.MainTable.Rows[i][9].ToString();

                TileUser tile = new TileUser();
                tile.LoadData(user);
                flowLayoutPanelUsers.Controls.Add(tile);
            }
        }

        private void LoadDiscount()
        {
            CommandDB command = new CommandDB();
            command.LoadData("Select * From Discount");
            for(int i = 0; i < command.MainTable.Rows.Count; i++)
            {
                listBoxDiscount.Items.Add(new MaterialListBoxItem(command.MainTable.Rows[i][1].ToString() + " (" + command.MainTable.Rows[i][2].ToString() + "%)"));
            }
        }

        private void comboBoxTypeUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxTypeUser.SelectedIndex)
            {
                case 0:
                    comboBoxPost.Visible = false;
                    LoadClients();
                    break;
                case 1:
                    comboBoxPost.Visible = true;
                    LoadEmployee();
                    break;
            }
        }

        private void comboBoxPost_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxPost.SelectedIndex == 0)
            {
                LoadEmployee();
            }
            else
            {
                LoadEmployee();
            }    
        }

        private void timerUpdateUsers_Tick(object sender, EventArgs e)
        {
            switch (comboBoxTypeUser.SelectedIndex)
            {
                case 0:
                    comboBoxPost.Visible = false;
                    LoadClients();
                    break;
                case 1:
                    comboBoxPost.Visible = true;
                    LoadEmployee();
                    break;
            }
        }

        private void textBoxSurname_TextChanged(object sender, EventArgs e)
        {
            switch (comboBoxTypeUser.SelectedIndex)
            {
                case 0:
                    comboBoxPost.Visible = false;
                    LoadClients();
                    break;
                case 1:
                    comboBoxPost.Visible = true;
                    LoadEmployee();
                    break;
            }
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            switch (comboBoxTypeUser.SelectedIndex)
            {
                case 0:
                    comboBoxPost.Visible = false;
                    LoadClients();
                    break;
                case 1:
                    comboBoxPost.Visible = true;
                    LoadEmployee();
                    break;
            }
        }

        private void textBoxPatronymic_TextChanged(object sender, EventArgs e)
        {
            switch (comboBoxTypeUser.SelectedIndex)
            {
                case 0:
                    comboBoxPost.Visible = false;
                    LoadClients();
                    break;
                case 1:
                    comboBoxPost.Visible = true;
                    LoadEmployee();
                    break;
            }
        }

        private void loadUnderCategory()
        {
            CommandDB command = new CommandDB();
            command.LoadData($"Select TitleUnderCategory From UnderCategory Inner Join MainCategory On MainCategory.ID_MainCategory = UnderCategory.id_mainCategory  Where TitleMainCategory = '{comboBoxProductMainCategory.Text}'");
            comboBoxProductUnderCategory.Items.Clear();
            for (int i = 0; i < command.MainTable.Rows.Count; i++)
            {
                comboBoxProductUnderCategory.Items.Add(command.MainTable.Rows[i][0].ToString());
            }
            comboBoxProductUnderCategory.SelectedIndex = 0;
        }
        private void comboBoxProductMainCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadUnderCategory();
            LoadProducts();
        }
        private void comboBoxProductUnderCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadProducts();
        }
        private void textBoxTitleProduct_TextChanged(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void bttAddUser_Click(object sender, EventArgs e)
        {
            FormAddUser form = new FormAddUser();
            form.Show();
        }


        private List<Category> category = new List<Category>();
        // регион категорий
        private void LoadMainCategory()
        {
            CommandDB commandDB = new CommandDB();
            commandDB.LoadData("Select TitleMainCategory From MainCategory");
            for(int i = 0; i < commandDB.MainTable.Rows.Count; i++)
            {
                comboBoxCategory.Items.Add(commandDB.MainTable.Rows[i][0].ToString());
                comboBoxProductMainCategory.Items.Add(commandDB.MainTable.Rows[i][0].ToString());
            }
            comboBoxProductMainCategory.SelectedIndex = 0;
        }

        private void bttAddCategory_Click(object sender, EventArgs e)
        {
            FormAddCategory form = new FormAddCategory();
            form.Show();
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTileCategory(comboBoxCategory.SelectedIndex);
        }
        private void LoadTileCategory(int _id)
        {
            flowLayoutCategory.Controls.Clear();

            if (_id == 0)
            {
                CommandDB command = new CommandDB();
                command.LoadData($"Select * From MainCategory");
                for (int i = 0; i < command.MainTable.Rows.Count; i++)
                {
                    Category category = new Category();
                    category.ID = command.MainTable.Rows[i][0].ToString();
                    category.TitleCategory = command.MainTable.Rows[i][1].ToString();
                    category.Image = command.MainTable.Rows[i][2].ToString();

                    TileCategory tile = new TileCategory();
                    tile.LoadData(category, flowLayoutCategory, comboBoxCategory);
                    flowLayoutCategory.Controls.Add(tile);
                }
            }
            else
            {
                CommandDB command = new CommandDB();
                command.LoadData($"Select * From UnderCategory Where id_mainCategory = {_id}");
                for(int i = 0; i < command.MainTable.Rows.Count; i++)
                {
                    Category category = new Category();
                    category.ID = command.MainTable.Rows[i][0].ToString();
                    category.TitleCategory = command.MainTable.Rows[i][1].ToString();
                    category.Image = command.MainTable.Rows[i][2].ToString();
                    category.id_undercategory = command.MainTable.Rows[i][3].ToString();

                    TileCategory tile = new TileCategory();
                    tile.LoadData(category, flowLayoutCategory, comboBoxCategory);
                    flowLayoutCategory.Controls.Add(tile);
                }
            }
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            FormAddUser form = new FormAddUser();
            form.Show();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            FormAddDiscount form = new FormAddDiscount();
            form.Show();
        }

        private void listBoxDiscount_SelectedIndexChanged(object sender, MaterialListBoxItem selectedItem)
        {
            if(MessageBox.Show("Вы уверены, что хотите удалить " + selectedItem.Text + "?","Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                CommandDB command = new CommandDB();
                command.LoadData($"Select ID_Discount From Discount Where TitleDiscount = '{selectedItem.Text}'");
                string idDiscount = command.MainTable.Rows[0][0].ToString();
                command.SendCommand($"Update Products Set id_discount = 1 Where id_discount = {idDiscount}");
                MessageBox.Show("Удален!");
            }
        }

        private void StatistickIncome(int _type)
        {
            FillingStatistick fillingStatistick = new FillingStatistick();
            switch (_type)
            {
                case 1:
                    fillingStatistick.FillIncomeDay(chartIncome);
                    break;
                case 2:
                    fillingStatistick.FillIncomeMonth(chartIncome);
                    break;
                case 3:
                    fillingStatistick.FillIncomeYear(chartIncome);
                    break;
            }
        }
        private void StatistickOrder(int _type)
        {
            FillingStatistick fillingStatistick = new FillingStatistick();
            switch (_type)
            {
                case 1:
                    fillingStatistick.FillingOrderDay(chartCountOrder);
                    break;
                case 2:
                    fillingStatistick.FillingOrderMonth(chartCountOrder);
                    break;
                case 3:
                    fillingStatistick.FillingOrderYear(chartCountOrder);
                    break;
            }
        }

        private void materialComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (materialComboBox4.SelectedIndex)
            {
                case 0:
                    StatistickIncome(1);
                    break;
                case 1:
                    StatistickIncome(2);
                    break;
                case 2:
                    StatistickIncome(3);
                    break;
            }
        }

        private void materialComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (materialComboBox3.SelectedIndex)
            {
                case 0:
                    StatistickOrder(1);
                    break;
                case 1:
                    StatistickOrder(2);
                    break;
                case 2:
                    StatistickOrder(3);
                    break;
            }
        }

        private void Category_Paint(object sender, PaintEventArgs e)
        {
            LoadTileCategory(0);
        }

        private void Products_Paint(object sender, PaintEventArgs e)
        {
            LoadProducts();
        }
    }
}
