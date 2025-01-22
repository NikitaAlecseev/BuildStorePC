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
    public partial class FormAddUser : MaterialForm
    {
        private string pathImage = "";
        public FormAddUser()
        {
            InitializeComponent();
        }
        private void FormAddUser_Load(object sender, EventArgs e)
        {
            LoadPosts();
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
            if(comboBoxTypeUser.SelectedIndex == 0)
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
            if(comboBoxTypeUser.SelectedIndex == 0)
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

        private void comboBoxTypeUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTypeUser.SelectedIndex == 0)
            {
                comboBoxPost.Visible = false;
            }
            else
            {
                comboBoxPost.Visible = true;
            }
        }

        private void bttCheck_Click(object sender, EventArgs e)
        {
            CommandDB command = new CommandDB();
            command.LoadData($"Select Login From Authentication Where Login = '{textBoxLogin.Text}'");
            labelCheckLogin.Visible = true;
            if (command.MainTable.Rows.Count > 0) // проверка логина
            {
                labelCheckLogin.Text = "Логин занят!";
                labelCheckLogin.ForeColor = Color.Red;
            }
            else
            {
                labelCheckLogin.Text = "Логин свободен!";
                labelCheckLogin.ForeColor = Color.Green;
            }
            if(textBoxPassword.Text != textBoxPassword2.Text) // проверка пароля
            {
                labelCheckPassword.Visible = true;
            }
            else
            {
                labelCheckPassword.Visible = false;
            }
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {
            labelCheckLogin.Visible = false;
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

        private void bttRegister_Click(object sender, EventArgs e)
        {
            CommandDB command = new CommandDB();
            command.SendCommand($"Insert Into Authentication (Login,Password,Secret) VALUES('{textBoxLogin.Text}','{textBoxPassword.Text}','{textBoxSecret.Text}');");
            command.LoadData("Select MAX(ID_Authentication) From Authentication");
            string lastIDAuthentication = command.MainTable.Rows[0][0].ToString();

            if(pathImage == "")
            {
                textBoxRelativeLink.Text = "users/user.png";
            }
            else
            {
                FTP ftp = new FTP("ftp://nikitdax.beget.tech/", "nikitdax_admin", "nB2qTJ3!");
                ftp.SendImage(textBoxRelativeLink.Text, pathImage);
                setNumberImage();
            }

            if(comboBoxTypeUser.SelectedIndex == 0)
            {
                command.SendCommand($"Insert Into Clients (Surname,Name,Patronymic,Phone,Address,Image,id_authentication) " +
                    $"VALUES('{textBoxSurname.Text}','{textBoxName.Text}','{textBoxPatronymic.Text}','{textBoxPhone.Text}','{textBoxAddress.Text}','{textBoxRelativeLink.Text}',{lastIDAuthentication});");
            }
            else
            {
                command.SendCommand("Insert Into Employee (Surname,Name,Patronymic,Phone,Address,Image,id_post,id_authentication)" +
                    $" VALUES ('{textBoxSurname.Text}','{textBoxName.Text}','{textBoxPatronymic.Text}','{textBoxPhone.Text}','{textBoxAddress.Text}','{textBoxRelativeLink.Text}',{comboBoxPost.SelectedIndex + 1}, {lastIDAuthentication});");
            }
            MessageBox.Show("Пользователь зарегистрирован!");
            this.Hide();
        }

        private void FormAddUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
