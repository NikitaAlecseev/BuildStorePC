using BuildStore.Core;
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
    public partial class FormAddDiscount : MaterialForm
    {
        public FormAddDiscount()
        {
            InitializeComponent();
        }

        private void bttAdd_Click(object sender, EventArgs e)
        {
            CommandDB command = new CommandDB();
            command.SendCommand($"Insert Into Discount (TitleDiscount,DiscountPercent) VALUES ('{textBoxTitle.Text}',{textBoxDiscount.Text});");
            MessageBox.Show("Добавил я твою скидку");
            this.Hide();
        }
    }
}
