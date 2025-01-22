using BuildStore.Core;
using BuildStore.Models;
using BuildStore.Tiles;
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
    public partial class FormEditProduct : MaterialForm
    {
        private Products products;
        private List<Specifications> specifications = new List<Specifications>();
        private List<string> tempValueSpec = new List<string>();
        public FormEditProduct()
        {
            InitializeComponent();
        }

        private void FormEditProduct_Load(object sender, EventArgs e)
        {
            LoadMainCategory();
            LoadUnderCategory();
            LoadDiscount();
        }

        public void LoadData(Products _products)
        {
            products = _products;
            textBoxTitle.Text = _products.TitleProduct;
            textBoxDescription.Text = _products.DescriptionProduct;
            textBoxCost.Text = _products.Cost;
            comboBoxCategory.Text = _products.TitleMainCategory;
            comboBoxUnderCategory.Text = _products.TitleUnderCategory;
            comboBoxDiscount.Text = _products.TitleDiscount;

            if(_products.Image != "")
            {
                textBoxLinkImage.Text = GlobalVar.PathMainImageFolder + _products.Image;
                textBoxRelativeLink.Text = _products.Image;
                pictureBox1.ImageLocation = textBoxLinkImage.Text;
            }

            // загрузка характеристик
            flowLayoutCharast.Controls.Clear();
            CommandDB command = new CommandDB();
            command.LoadData($"Select Attribute.ID_Attribute, TitleAttribute, Value From AttributeValue Inner Join Attribute On Attribute.ID_Attribute = AttributeValue.id_attribute Where AttributeValue.id_product = {_products.Id};");
            for(int i = 0;i< command.MainTable.Rows.Count; i++)
            {
                Specifications spec = new Specifications();
                spec.SpecificationsId = command.MainTable.Rows[i][0].ToString();
                spec.SpecificationsName = command.MainTable.Rows[i][1].ToString();
                spec.SpecificationsValue = command.MainTable.Rows[i][2].ToString();
                specifications.Add(spec);
                tempValueSpec.Add(spec.SpecificationsValue);
                
                TileSpecifications tile = new TileSpecifications();
                tile.LoadData(spec);
                flowLayoutCharast.Controls.Add(tile);
            }
        }

        private void LoadMainCategory()
        {
            CommandDB command = new CommandDB();
            command.LoadData("Select TitleMainCategory From MainCategory");
            for (int i = 0; i < command.MainTable.Rows.Count; i++) // добавляем главные категории
            {
                comboBoxCategory.Items.Add(command.MainTable.Rows[i][0].ToString());
            }
            if (comboBoxCategory.Items.Count <= 0) return;
            comboBoxCategory.SelectedIndex = 0;
        }

        private void LoadUnderCategory()
        {
            CommandDB command = new CommandDB();
            command.LoadData($"Select TitleUnderCategory From UnderCategory Where id_mainCategory = {comboBoxCategory.SelectedIndex + 1}");
            for (int i = 0; i < command.MainTable.Rows.Count; i++) // добавляем под категории
            {
                comboBoxUnderCategory.Items.Add(command.MainTable.Rows[i][0].ToString());
            }
            if (comboBoxUnderCategory.Items.Count <= 0) return;
            comboBoxUnderCategory.SelectedIndex = 0;
        }

        private void LoadDiscount()
        {
            CommandDB command = new CommandDB();
            command.LoadData($"Select TitleDiscount From Discount");
            for (int i = 0; i < command.MainTable.Rows.Count; i++) // добавляем под категории
            {
                comboBoxDiscount.Items.Add(command.MainTable.Rows[i][0].ToString());
            }
            comboBoxDiscount.SelectedIndex = 0;
        }

        private void tabPage3_Paint(object sender, PaintEventArgs e)
        {
            listBox1.Items.Clear();

            pictureBoxItog.Image = pictureBox1.Image;
            labelTitle.Text = textBoxTitle.Text;
            labelCost.Text = textBoxCost.Text + " руб";

            for (int i = 0; i < specifications.Count; i++)
            {
                listBox1.Items.Insert(i, new MaterialSkin.MaterialListBoxItem(specifications[i].SpecificationsName + ": " + specifications[i].SpecificationsValue));
            }
        }

        private void bttEdit_Click(object sender, EventArgs e)
        {
            CommandDB command = new CommandDB();
            command.SendCommand($"Update Products Set TitleProduct ='{textBoxTitle.Text}',Description='{textBoxDescription.Text}',Cost={textBoxCost.Text},Image='{textBoxRelativeLink.Text}',id_underCategory={comboBoxUnderCategory.SelectedIndex + 1},id_discount={comboBoxDiscount.SelectedIndex + 1} Where ID_Product = {products.Id};");

            // меняем характеристики
            for(int i = 0; i < specifications.Count; i++)
            {
                if(specifications[i].SpecificationsValue != tempValueSpec[i])
                {
                    command.SendCommand($"Update AttributeValue Set Value = '{specifications[i].SpecificationsValue}' Where id_attribute = {specifications[i].SpecificationsId};");
                }
            }
            MessageBox.Show("Changed!");
            this.Hide();
        }

        private void FormEditProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
