using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuildStore.Core
{
    public class DB
    {
        MySqlConnection connection = new MySqlConnection("server=192.168.0.101;username=*****;password=*****;database=******");

        public void openConnection()
        {
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void closeConnection()
        {
            connection.Close();
        }
        public MySqlConnection getConnection()
        {
            return connection;
        }
    }
}
