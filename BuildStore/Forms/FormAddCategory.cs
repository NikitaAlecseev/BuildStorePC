using BuildStore.Core;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuildStore.Forms
{
    public partial class FormAddCategory : MaterialForm
    {
        private string pathImage = "";
        private string formatFile = "";
        private int indexImage = 0;
        public FormAddCategory()
        {
            InitializeComponent();
        }

        private void comboBoxTypeCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTypeCategory.SelectedIndex == 0)
            {
                comboBoxMainCategory.Visible = false;
            }
            else
            {
                comboBoxMainCategory.Visible = true;
                loadMainCategor();
            }
        }

        private void loadMainCategor()
        {
            if (comboBoxMainCategory.Items.Count > 0) return;

            CommandDB command = new CommandDB();
            command.LoadData("Select TitleMainCategory From MainCategory");
            for (int i = 0; i < command.MainTable.Rows.Count; i++)
            {
                comboBoxMainCategory.Items.Add(command.MainTable.Rows[i][0].ToString());
            }

        }

        private void bttAddCategory_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxTypeCategory.SelectedIndex == 0) // главная категория
                {
                    FTP ftp = new FTP("ftp://nikitdax.beget.tech/", "nikitdax_admin", "nB2qTJ3!");

                    // отпарвляем картинку категории по пути "category/main/"
                    if(formatFile != "")
                    {
                        ftp.SendImage(textBoxRelativeLink.Text, pathImage);
                        updateCountMainCategory();
                    }

                    // отправка SQL запрос
                    CommandDB command = new CommandDB();
                    command.SendCommand($"Insert Into MainCategory (TitleMainCategory, Image) VALUES ('{textBoxCategory.Text}', '{textBoxRelativeLink.Text}');");
                }
                else // подкатегория
                {
                    FTP ftp = new FTP("ftp://nikitdax.beget.tech/", "nikitdax_admin", "nB2qTJ3!");

                    // отпарвляем картинку категории по пути "category/under/"
                    if (formatFile != "")
                    {
                        ftp.SendImage(textBoxRelativeLink.Text, pathImage);
                        updateCountUnderCategory(); // обновляем индексацию картинок в папке
                    }

                    // отправка SQL запрос
                    CommandDB command = new CommandDB();
                    command.LoadData($"Select ID_MainCategory From MainCategory Where TitleMainCategory = '{comboBoxMainCategory.Text}'");
                    string idMainCategory = command.MainTable.Rows[0][0].ToString();
                    command.SendCommand($"Insert Into UnderCategory (TitleUnderCategory, Image, id_mainCategory) VALUES ('{textBoxCategory.Text}', '{textBoxRelativeLink.Text}', {idMainCategory});");
                }

                MessageBox.Show("Категория добавлена!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private int getCountImageMainCategory()
        {
            CommandDB command = new CommandDB();
            command.LoadData("Select CountImages From HelpStaticFolder Where NameFolder ='category/main';");

            if(command.MainTable.Rows.Count == 0) return 0;
            return Convert.ToInt32(command.MainTable.Rows[0][0]);
        }
        private int getCountImageUnderCategory()
        {
            CommandDB command = new CommandDB();
            command.LoadData("Select CountImages From HelpStaticFolder Where NameFolder ='category/under';");

            if (command.MainTable.Rows.Count == 0) return 0;
            return Convert.ToInt32(command.MainTable.Rows[0][0]);
        }

        private void updateCountMainCategory()
        {
            CommandDB command = new CommandDB();
            command.SendCommand("Update HelpStaticFolder SET CountImages = CountImages + 1 WHERE NameFolder = 'category/main';");
        }
        private void updateCountUnderCategory()
        {
            CommandDB command = new CommandDB();
            command.SendCommand("Update HelpStaticFolder SET CountImages = CountImages + 1 WHERE NameFolder = 'category/under';");
        }

        private void bttClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

                if(comboBoxTypeCategory.SelectedIndex == 0)
                {
                    indexImage = Convert.ToInt32(getCountImageMainCategory()) + 1;
                    formatFile = Path.GetExtension(files[0]);
                    textBoxLinkImage.Text = "https://nikitdax.beget.tech/images/category/main/" + indexImage + formatFile; // генерируем ссылку
                    textBoxRelativeLink.Text = "category/main/" + indexImage + formatFile;
                }
                else
                {
                    indexImage = Convert.ToInt32(getCountImageUnderCategory()) + 1;
                    formatFile = Path.GetExtension(files[0]);
                    textBoxLinkImage.Text = "https://nikitdax.beget.tech/images/category/under/" + indexImage + formatFile; // генерируем ссылку
                    textBoxRelativeLink.Text = "category/under/" + indexImage + formatFile;
                }
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

        private void textBoxRelativeLink_TextChanged(object sender, EventArgs e)
        {
            textBoxLinkImage.Text = "https://nikitdax.beget.tech/images/" + textBoxRelativeLink.Text;
        }
    }
}