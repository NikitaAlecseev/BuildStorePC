using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using BuildStore.Forms;
using BuildStore.Core;

namespace BuildStore.Forms
{
    public partial class FormAuthorization : MaterialForm
    {
        public FormAuthorization()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Color.FromArgb(255, 136, 0), Color.FromArgb(160, 90, 0), Color.FromArgb(255, 0, 0), Color.FromArgb(255, 90, 0), TextShade.WHITE);

            textBoxPasssword.Password = true;
        }

        private void bttAutorization_Click(object sender, EventArgs e)
        {
            CommandDB command = new CommandDB();
            command.LoadData($"Select * From Employee Inner Join Authentication On Employee.id_authentication = Authentication.ID_Authentication Where Authentication.Login = '{textBoxLogin.Text}' AND Authentication.Password = BINARY '{textBoxPasssword.Text}';");
            if (command.MainTable.Rows.Count > 0)
            {
                FormMain form = new FormMain();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Вы ввели не верный логин или пароль!","Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
