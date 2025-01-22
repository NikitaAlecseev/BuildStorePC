using BuildStore.Core;
using BuildStore.Forms;
using BuildStore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuildStore.Tiles
{
    public partial class TileProduct : UserControl
    {
        private Products product;
        public TileProduct()
        {
            InitializeComponent();
        }
        public void LoadData(Products _products)
        {
            product = _products;
            labelTitle.Text = _products.TitleProduct;
            labelCost.Text = _products.Cost + " руб";
            labelMainCategory.Text = "Категория: " + _products.TitleMainCategory;
            labelUnderCategory.Text = _products.TitleUnderCategory;
            labelDiscount.Text = "Скидка: " + _products.TitleDiscount;

            if(_products.Image != "")
            {
                pictureBox1.ImageLocation = GlobalVar.PathMainImageFolder + _products.Image;
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditProduct form = new FormEditProduct();
            form.LoadData(product);
            form.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Вы уверены, что хотите удалить {product.TitleProduct}?","Внимание",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                CommandDB command = new CommandDB();
                command.SendCommand("SET FOREIGN_KEY_CHECKS=0");

                command.SendCommand($"Delete From Reviews Where id_product = {product.Id};");
                command.SendCommand($"Delete From Favourites Where id_product = {product.Id};");
                command.SendCommand($"Delete From AttributeValue Where id_product = {product.Id}");
                command.SendCommand($"Delete From Basket Where id_product = {product.Id}");
                command.SendCommand($"Delete From PositionsOrder Where id_product = {product.Id}");
                command.SendCommand($"Delete From Products Where ID_Product = {product.Id}");

                command.SendCommand("SET FOREIGN_KEY_CHECKS=1");
            }
        }
    }
}
