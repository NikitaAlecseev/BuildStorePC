using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuildStore.Models;
using BuildStore.Tiles;
using System.Net;
using BuildStore.Core;

namespace BuildStore.Forms
{
    public partial class FormAddProduct : MaterialForm
    {
        private string pathImage = "";
        private string sendPathImage = "";
        private List<Specifications> specifications = new List<Specifications>();

        public FormAddProduct()
        {
            InitializeComponent();
        }


        private void FormAddProduct_Load(object sender, EventArgs e)
        {
            LoadMainCategory();
            LoadUnderCategory();
            LoadDiscount();
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
        }

        private void buttonAddPicture_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            pathImage = files[0];
            try
            {
                Bitmap image = new Bitmap(files[0]);
                pictureBox1.Image = image;
                pictureBox1.Invalidate();
                sendPathImage = "0" + (getNumberImage() + 1) + Path.GetExtension(files[0]);
                textBoxLinkImage.Text = GlobalVar.PathMainImageFolder + sendPathImage; // генерируем ссылку
            }
            catch
            {
                DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл",
                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAddPicture_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }


        private void materialButton1_Click(object sender, EventArgs e)
        {
            if(pathImage == "")
            {
                if(textBoxLinkImage.Text != "")
                {
                    sendPathImage = textBoxLinkImage.Text;
                }
                else
                {
                    MessageBox.Show("Вы не добавили картинку!");
                    return;
                }
            }
            else
            {
                FTP ftp = new FTP("ftp://nikitdax.beget.tech/", "nikitdax_admin", "nB2qTJ3!");
                ftp.SendImage(sendPathImage, pathImage);
                setNumberImage();
            }


            CommandDB command = new CommandDB();
            command.SendCommand($"Insert Into Products (TitleProduct,Description,Cost,Count,Image,id_underCategory,id_discount) " +
                $"VALUES ('{textBoxTitle.Text}','{textBoxDescription.Text}',{textBoxCost.Text},{tbCount.Text},'{sendPathImage}',{comboBoxUnderCategory.SelectedIndex + 1},{comboBoxDiscount.SelectedIndex + 1});");

            command.LoadData("Select MAX(ID_Product) From Products");
            string idProduct = command.MainTable.Rows[0][0].ToString();

            // добавляем характеристики
            for(int i = 0; i < specifications.Count; i++)
            {
                command.SendCommand($"Insert Into AttributeValue (id_attribute,id_product,Value) VALUES({specifications[i].SpecificationsId},{idProduct},'{specifications[i].SpecificationsValue}');");
            }

            MessageBox.Show("Продукт добавлен!");
            this.Hide();
        }


        private void tabPage3_Paint(object sender, PaintEventArgs e)
        {
            listBox1.Items.Clear();

            pictureBoxItog.Image = pictureBox1.Image;
            labelTitle.Text = textBoxTitle.Text;
            labelCost.Text = textBoxCost.Text + " руб";

            for(int i = 0; i < specifications.Count; i++)
            {
                listBox1.Items.Insert(i, new MaterialSkin.MaterialListBoxItem(specifications[i].SpecificationsName + ": " + specifications[i].SpecificationsValue));
            }
        }


        private int getNumberImage() // получает последнее число картинки
        {
            CommandDB command = new CommandDB();
            command.LoadData("Select CountImages From HelpStaticFolder Where ID_HelpStaticFolder = 3;");
            return Convert.ToInt32(command.MainTable.Rows[0][0].ToString());
        }

        private void setNumberImage() // изменяет конфигурацию файла с картинками
        {
            CommandDB command = new CommandDB();
            command.SendCommand("Update HelpStaticFolder Set CountImages = CountImages + 1 Where ID_HelpStaticFolder = 3;");
        }

        private void comboBoxUnderCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            // загружаем характеристика для этой подкатегории
            CommandDB command = new CommandDB();
            command.LoadData($"Select * From Attribute Where id_underCategory = {comboBoxUnderCategory.SelectedIndex + 1};");
            flowLayoutCharast.Controls.Clear();
            specifications.Clear();
            for(int i = 0; i < command.MainTable.Rows.Count; i++)
            {
                Specifications spec = new Specifications();
                spec.SpecificationsId = command.MainTable.Rows[i][0].ToString();
                spec.SpecificationsName = command.MainTable.Rows[i][2].ToString();
                specifications.Add(spec);

                TileSpecifications tile = new TileSpecifications();
                tile.LoadData(spec);
                flowLayoutCharast.Controls.Add(tile);
            }
        }

        private void FormAddProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
