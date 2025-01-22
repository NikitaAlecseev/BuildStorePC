using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuildStore.Core;
using BuildStore.Forms;
using BuildStore.Models;

namespace BuildStore.Tiles
{
    public partial class TileUser : UserControl
    {
        private Users user;
        public TileUser()
        {
            InitializeComponent();
        }

        public void LoadData(Users _user)
        {
            user = _user;
            labelSurname.Text = _user.Surname;
            labelName.Text = _user.Name;
            labelPatronymic.Text = _user.Patronymic;
            labelPhone.Text = _user.Phone;
            if(_user.Post != "")
            {
                labelPost.Text = user.Post;
                labelPost.Visible = true;
                label4.Visible = true;
            }
            else
            {
                this.Size = new Size(240, 325);
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditUser form = new FormEditUser();
            form.LoadData(user);
            form.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Вы уверены, что хотите удалить {user.Surname}?","Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                CommandDB command = new CommandDB();
                command.LoadData($"Select ID_Authentication From Authentication Where Login = '{user.Login}' LIMIT 1");
                string idAuth = command.MainTable.Rows[0][0].ToString();
                command.SendCommand($"Delete From Clients Where id_authentication = {idAuth};");
                command.SendCommand($"Delete From Employee Where id_authentication = {idAuth};");
                command.SendCommand($"Delete From Authentication Where ID_Authentication = {idAuth};");
                MessageBox.Show("Удалил!");
            }
        }
    }
}
