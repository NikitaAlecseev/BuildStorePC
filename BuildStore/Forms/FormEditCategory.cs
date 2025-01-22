using BuildStore.Core;
using BuildStore.Models;
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

namespace BuildStore.Forms
{
    public partial class FormEditCategory : MaterialForm
    {
        private string pathImage = "";
        private string formatFile = "";
        private int indexImage = 0;
        private Category category;

        public FormEditCategory()
        {
            InitializeComponent();
        }

        private void FormEditCategory_Load(object sender, EventArgs e)
        {
            
        }

        public void LoadData(Category _category)
        {
            category = _category;

            if (_category.id_undercategory != "")
            {
                loadMainCategory();
                loadCharasteristicks();

                comboBoxTypeCategory.SelectedIndex = 1;
                comboBoxMainCategory.SelectedIndex = Convert.ToInt32(_category.id_undercategory) - 1;
                comboBoxMainCategory.Visible = true;
            }
            if(_category.Image != "")
            {
                pictureBox1.ImageLocation = GlobalVar.PathMainImageFolder + _category.Image;
                textBoxLinkImage.Text = GlobalVar.PathMainImageFolder + _category.Image;
            }
            textBoxRelativeLink.Text = _category.Image;
            textBoxCategory.Text = _category.TitleCategory;
        }

        private void loadCharasteristicks()
        {
            CommandDB command = new CommandDB();
            command.LoadData($"Select TitleAttribute From Attribute Where id_underCategory = {category.ID};");
            for(int i = 0; i < command.MainTable.Rows.Count; i++)
            {
                listBoxCharaster.Items.Insert(i, new MaterialSkin.MaterialListBoxItem(command.MainTable.Rows[i][0].ToString()));
            }
        }

        private void loadMainCategory()
        {
            if (comboBoxMainCategory.Items.Count > 0) return;

            CommandDB command = new CommandDB();
            command.LoadData("Select TitleMainCategory From MainCategory");
            for (int i = 0; i < command.MainTable.Rows.Count; i++)
            {
                comboBoxMainCategory.Items.Add(command.MainTable.Rows[i][0].ToString());
            }

        }

        private void bttEditCategory_Click(object sender, EventArgs e)
        {
            try
            {
                if(comboBoxTypeCategory.SelectedIndex == 0)
                {
                    FTP ftp = new FTP("ftp://nikitdax.beget.tech/", "nikitdax_admin", "nB2qTJ3!");

                    // отпарвляем картинку категории по пути "category/main/"
                    if (formatFile != "")
                    {
                        ftp.SendImage(textBoxRelativeLink.Text, pathImage);
                        updateCountMainCategory();
                    }

                    // отправка SQL запрос
                    CommandDB command = new CommandDB();
                    command.SendCommand($"Update MainCategory Set TitleMainCategory = '{textBoxCategory.Text}', Image = '{textBoxRelativeLink.Text}' Where ID_MainCategory = {category.ID};");

                    MessageBox.Show("Категория изменена!");
                    this.Close();
                }
                else
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
                    command.SendCommand($"Update UnderCategory Set TitleUnderCategory = '{textBoxCategory.Text}',Image = '{textBoxRelativeLink.Text}', id_mainCategory = {idMainCategory} WHERE ID_UnderCategory = {category.ID};");

                    MessageBox.Show("Под категория изменена!");
                    this.Close();
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

                if (comboBoxTypeCategory.SelectedIndex == 0)
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

        private int getCountImageMainCategory()
        {
            CommandDB command = new CommandDB();
            command.LoadData("Select CountImages From HelpStaticFolder Where NameFolder ='category/main';");

            if (command.MainTable.Rows.Count == 0) return 0;
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

        private void bttAddCharasteristick_Click(object sender, EventArgs e)
        {
            if (textBoxTitleCharast.Text == "") return;
            if (comboBoxTypeCategory.SelectedIndex == 0) return;

            CommandDB command = new CommandDB();
            command.SendCommand($"Insert Into Attribute (id_underCategory, TitleAttribute) VALUES ({category.ID},'{textBoxTitleCharast.Text}');");
            listBoxCharaster.Items.Insert(listBoxCharaster.Items.Count, new MaterialSkin.MaterialListBoxItem(textBoxTitleCharast.Text));
            textBoxTitleCharast.Text = "";
        }

        private void listBoxCharaster_SelectedIndexChanged(object sender, MaterialSkin.MaterialListBoxItem selectedItem)
        {
            if (MessageBox.Show("Вы уверены, что хотите удалить " + selectedItem.Text + "?","Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                CommandDB command = new CommandDB();
                command.SendCommand($"Delete FROM Attribute Where TitleAttribute = '{selectedItem.Text}';");
                listBoxCharaster.RemoveItem(selectedItem);
            }
        }
    }
}
