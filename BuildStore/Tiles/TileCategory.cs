using BuildStore.Core;
using BuildStore.Forms;
using BuildStore.Models;
using MaterialSkin.Controls;
using System.Windows.Forms;

namespace BuildStore.Tiles
{
    public partial class TileCategory : UserControl
    {
        private Category category;
        private FlowLayoutPanel flowPanel;
        private MaterialComboBox comboBox;
        public TileCategory()
        {
            InitializeComponent();
        }

        public void LoadData(Category _category, FlowLayoutPanel _panel, MaterialComboBox _comboBox)
        {
            category = _category;
            labelTitle.Text = _category.TitleCategory;
            if(_category.Image != "")
            {
                pictureBox1.ImageLocation = GlobalVar.PathMainImageFolder + _category.Image;
            }
        }

        private void editToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormEditCategory form = new FormEditCategory();
            form.LoadData(category);
            form.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if(MessageBox.Show("Вы уверены, что хотите удалить " + category.TitleCategory + "?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                CommandDB command = new CommandDB();
                command.SendCommand("SET FOREIGN_KEY_CHECKS=0");
                if (category.id_undercategory != "") // если это подкатегория
                {
                    command.SendCommand($"Delete FROM Products Where id_underCategory = {category.id_undercategory};"); // удаляем данные в таблице Products
                    command.SendCommand($"Delete FROM ProductAttributeValues Where id_attributeValue = (Select ID_Attribute From Attribute Where id_underCategory = {category.id_undercategory});"); // удаляем данные в таблице ProductAttributeValues
                    command.SendCommand($"Delete FROM AttributeValue Where id_attribute = (Select ID_Attribute From Attribute Where id_underCategory = {category.id_undercategory} LIMIT 1));"); // удаляем данные в таблице AttributeValue
                    command.SendCommand($"Delete FROM Attribute Where id_underCategory = {category.id_undercategory}"); // удаляем данные в таблице Attribute
                    command.SendCommand($"Delete FROM UnderCategory Where ID_UnderCategory = {category.ID}");
                }
                else
                {
                    command.LoadData($"Select ID_UnderCategory From UnderCategory Where id_mainCategory = {category.ID};");

                    if(command.MainTable.Rows.Count > 0)
                    {
                        string idUnderCategory = command.MainTable.Rows[0][0].ToString();
                        command.SendCommand($"Delete FROM Products Where id_underCategory = {idUnderCategory};"); // удаляем данные в таблице Products
                        command.SendCommand($"Delete FROM ProductAttributeValues Where id_attributeValue = (Select ID_Attribute From Attribute Where id_underCategory = {idUnderCategory});"); // удаляем данные в таблице ProductAttributeValues
                        command.SendCommand($"Delete FROM AttributeValue Where id_attribute = (Select ID_Attribute From Attribute Where id_underCategory = {idUnderCategory}));"); // удаляем данные в таблице AttributeValue
                        command.SendCommand($"Delete FROM Attribute Where id_underCategory = {idUnderCategory}"); // удаляем данные в таблице Attribute
                        command.SendCommand($"Delete FROM UnderCategory Where id_mainCategory = {category.ID}"); // удаляем подкатегорию
                    }

                    command.SendCommand($"Delete FROM MainCategory Where ID_MainCategory = {category.ID}");
                    command.SendCommand("SET FOREIGN_KEY_CHECKS=1");
                }
            }
        }
    }
}
