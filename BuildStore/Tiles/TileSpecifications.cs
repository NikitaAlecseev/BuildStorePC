using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuildStore.Models;

namespace BuildStore.Tiles
{
    public partial class TileSpecifications : UserControl
    {
        public string SpecificationsTitle;
        public string SpecificationsValue;

        private Specifications specifications;
        public TileSpecifications()
        {
            InitializeComponent();
        }
        public void LoadData(Specifications _specifications)
        {
            specifications = _specifications;
            textBox1.Hint = _specifications.SpecificationsName;

            if(_specifications.SpecificationsValue != "")
            {
                textBox1.Text = _specifications.SpecificationsValue;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            specifications.SpecificationsValue = textBox1.Text;
        }
    }
}
