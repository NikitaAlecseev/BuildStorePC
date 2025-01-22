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
    public partial class FormEditUser : MaterialForm
    {
        private string pathImage = "";
        private Users user;

        private string tempPassword = "";
        private string tempSecret = "";
        public FormEditUser()
        {
            InitializeComponent();
        }

        private void FormEditUser_Load(object sender, EventArgs e)
        {
            LoadPosts();
        }

        public void LoadData(Users _user)
        {
            user = _user;

            tempPassword = _user.Password;
            tempSecret = _user.Secret;

            textBoxSurname.Text = _user.Surname;
            textBoxName.Text = _user.Name;
            textBoxPatronymic.Text = _user.Patronymic;
            textBoxPhone.Text = _user.Phone;
            textBoxAddress.Text = _user.Address;
            comboBoxPost.SelectedText = _user.Post;

            textBoxLogin.Text = _user.Login;
            textBoxPassword.Text = _user.Password;
            textBoxSecret.Text = _user.Secret;

            if(_user.Image != "")
            {
                pictureBox1.ImageLocation = GlobalVar.PathMainImageFolder + _user.Image;
                textBoxRelativeLink.Text = _user.Image;
                textBoxLinkImage.Text = "http://nikitdax.beget.tech/images/" + _user.Image;
            }

            if(_user.Post != "")
            {
                comboBoxTypeUser.SelectedIndex = 1;
                comboBoxPost.Visible = true;
            }
            else
            {
                comboBoxTypeUser.SelectedIndex = 0;
            }
        }

        private void LoadPosts()
        {
            CommandDB command = new CommandDB();
            command.LoadData("Select TitlePost From Posts");
            for (int i = 0; i < command.MainTable.Rows.Count; i++)
            {
                comboBoxPost.Items.Add(command.MainTable.Rows[i][0].ToString());
            }
            comboBoxPost.SelectedItem = user.Post.ToString();
        }

        private void bttCheck_Click(object sender, EventArgs e)
        {
            if(textBoxPassword.Text == textBoxPassword2.Text)
            {
                labelCheckPassword.Visible = false;
                MessageBox.Show("Пароли совпадают!");
            }
            else
            {
                labelCheckPassword.Visible = true;
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
                string relativeLink = "";
                if (comboBoxTypeUser.SelectedIndex == 0)
                {
                    relativeLink = "clients/" + (getNumberImage() + 1) + Path.GetExtension(files[0]);
                    textBoxLinkImage.Text = "http://nikitdax.beget.tech/images/users/" + relativeLink; // генерируем ссылку
                    textBoxRelativeLink.Text = relativeLink;
                }
                else
                {
                    relativeLink = "employee/" + (getNumberImage() + 1) + Path.GetExtension(files[0]);
                    textBoxLinkImage.Text = "http://nikitdax.beget.tech/images/users/" + relativeLink; // генерируем ссылку
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
        private int getNumberImage() // получает последнее число картинки
        {
            CommandDB command = new CommandDB();
            if (comboBoxTypeUser.SelectedIndex == 0)
            {
                command.LoadData("Select CountImages From HelpStaticFolder Where NameFolder ='users/clients';");
            }
            else
            {
                command.LoadData("Select CountImages From HelpStaticFolder Where NameFolder ='users/employee';");
            }

            if (command.MainTable.Rows.Count == 0) return 0;
            return Convert.ToInt32(command.MainTable.Rows[0][0].ToString());
        }

        private void setNumberImage() // изменяет конфигурацию файла с картинками
        {
            if (comboBoxTypeUser.SelectedIndex == 0)
            {
                CommandDB command = new CommandDB();
                command.SendCommand("Update HelpStaticFolder SET CountImages = CountImages + 1 WHERE NameFolder = 'users/clients';");
            }
            else
            {
                CommandDB command = new CommandDB();
                command.SendCommand("Update HelpStaticFolder SET CountImages = CountImages + 1 WHERE NameFolder = 'users/employee';");
            }
        }

        private void tabPage3_Paint(object sender, PaintEventArgs e)
        {
            labelSurname.Text = "Фамилия: " + textBoxSurname.Text;
            labelName.Text = "Имя: " + textBoxName.Text;
            labelPatronymic.Text = "Отчество: " + textBoxPatronymic.Text;
            labelPhone.Text = "Телефон: " + textBoxPhone.Text;
            labelAddress.Text = "Адрес: " + textBoxAddress.Text;
            labelLogin.Text = "Логин: " + textBoxLogin.Text;
            labelTypeUser.Text = comboBoxTypeUser.Text;
            pictureBox2.Image = pictureBox1.Image;

            if (comboBoxPost.Text != "")
            {
                labelPost.Text = "Должность: " + comboBoxPost.Text;
                labelPost.Visible = true;
            }
            else
            {
                labelPost.Visible = false;
            }
        }

        private void bttEdit_Click(object sender, EventArgs e)
        {
            CommandDB command = new CommandDB();

            if(pathImage != "")
            {
                FTP ftp = new FTP("ftp://nikitdax.beget.tech/", "nikitdax_admin", "nB2qTJ3!");
                ftp.SendImage(textBoxRelativeLink.Text, pathImage);
                setNumberImage();
            }

            if(textBoxPassword.Text != tempPassword)
            {
                command.SendCommand($"Update Authentication Set Password = '{textBoxPassword.Text}' Where Login = '{user.Login}';");
            }
            if(textBoxSecret.Text != tempSecret)
            {
                command.SendCommand($"Update Authentication Set Secret = '{textBoxSecret.Text}' Where Login = '{user.Login}';");
            }
            if(comboBoxTypeUser.SelectedIndex == 0)
            {
                command.SendCommand($"Update Clients Set Surname = '{textBoxSurname.Text}',Name='{textBoxName.Text}',Patronymic = '{textBoxPatronymic.Text}', Phone = '{textBoxPhone.Text}',Address = '{textBoxAddress.Text}',Image='{textBoxRelativeLink.Text}' Where ID_Client = {user.Id};");
            }
            else
            {
                command.LoadData($"select ID_Post From Post Where TitlePost = '{comboBoxPost.Text}'");
                string idPost = command.MainTable.Rows[0][0].ToString();
                command.SendCommand($"Update Employee Set Surname = '{textBoxSurname.Text}',Name='{textBoxName.Text}',Patronymic = '{textBoxPatronymic.Text}', Phone = '{textBoxPhone.Text}',Address = '{textBoxAddress.Text}',Image='{textBoxRelativeLink.Text}', id_post = {idPost} Where ID_Client = {user.Id};");
            }
            MessageBox.Show("Поменял!");
            this.Hide();
        }

        private void FormEditUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
