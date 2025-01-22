using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace BuildStore.Core
{
    public class CommandDB:DB
    {
        private MySqlDataAdapter sqlDataAdapter = null;
        public DataTable MainTable = new DataTable();
        private DataSet dataSet = null;



        /// <summary>
        /// Метод для загрузки данных из БД в DataTable (MainTable)
        /// </summary>
        /// <param name="_command">Команда SQL</param>
        public void LoadData(string _command)
        {
            openConnection(); // открываем подключение

            try
            {
                MySqlCommand newCommand = new MySqlCommand(_command, getConnection()); // объявляем команду

                dataSet = new DataSet();

                sqlDataAdapter = new MySqlDataAdapter();

                sqlDataAdapter.SelectCommand = newCommand; // присваиваем адаптеру команду
                sqlDataAdapter.Fill(dataSet, "Load"); // заполняем dataSet данными из БД

                MainTable = dataSet.Tables["Load"]; // присваиваем таблице данные из dataSet

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Вывод ошибки
            }
            closeConnection(); // закрываем подключение
        }

        public void SendCommand(string _command)
        {
            openConnection(); // открываем подключение
            try
            {
                MySqlCommand Scommand = new MySqlCommand(_command, getConnection()); // объявляем команду
                Scommand.ExecuteNonQuery(); // отправляем команду в БД
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Вывод ошибки
            }

            closeConnection(); // закрываем подключение
        }
    }
}
