using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting;

namespace BuildStore.Core
{
    public class FillingStatistick
    {
        public void FillIncomeDay(Chart _chart)
        {
            _chart.Series["Series1"].Points.Clear();
            CommandDB command = new CommandDB();
            command.LoadData($"SELECT Hour(DateDelivery) As 'Month', SUM((Products.Cost * PositionsOrder.Count)) As 'Cost' FROM `Orders`  Inner Join PositionsOrder On PositionsOrder.NumberOrder = Orders.numberOrder INNER Join Products On Products.ID_Product = PositionsOrder.id_product WHERE DateDelivery BETWEEN(DATE_SUB(Now(), INTERVAL 1 DAY)) AND Now() And Orders.id_statusOrder = 5 Group by Day(DateDelivery)");
            List<int> hour = new List<int>();
            for (int i = 0; i < command.MainTable.Rows.Count; i++)
            {
                hour.Add(int.Parse(command.MainTable.Rows[i][0].ToString()));
            }
            int index = 0;
            for(int i = 0; i < 24; i++)
            {
                if (hour.Contains(i))
                {
                    _chart.Series["Series1"].Points.AddXY(i, command.MainTable.Rows[index][1].ToString());
                    index++;
                }
                else
                {
                    _chart.Series["Series1"].Points.AddXY(i, 0);
                }
            }
        }
        public void FillIncomeMonth(Chart _chart)
        {
            _chart.Series["Series1"].Points.Clear();
            CommandDB command = new CommandDB();
            command.LoadData($"SELECT Day(DateDelivery) As 'Day', SUM((Products.Cost * PositionsOrder.Count)) As 'Cost' FROM `Orders` Inner Join PositionsOrder On PositionsOrder.NumberOrder = Orders.numberOrder INNER Join Products On Products.ID_Product = PositionsOrder.id_product WHERE DateDelivery BETWEEN(DATE_SUB(Now(), INTERVAL 30 DAY)) AND Now() And Orders.id_statusOrder = 5 Group by Day(DateDelivery)");
            List<int> days = new List<int>();

            for (int i = 0; i < command.MainTable.Rows.Count; i++) // получаем актиные дни продаж
            {
                days.Add(int.Parse(command.MainTable.Rows[i][0].ToString()));
            }
            int index = 0;
            for(int i = 1; i < 30; i++)
            {
                if (days.Contains(i))
                {
                    _chart.Series["Series1"].Points.AddXY(i, command.MainTable.Rows[index][1].ToString());
                    index++;
                }
                else
                {
                    _chart.Series["Series1"].Points.AddXY(i, 0);
                }
            }

        }
        public void FillIncomeYear(Chart _chart)
        {
            _chart.Series["Series1"].Points.Clear();
            CommandDB command = new CommandDB();
            command.LoadData($"SELECT Month(DateDelivery) As 'Month', SUM((Products.Cost * PositionsOrder.Count)) As 'Cost' FROM `Orders` Inner Join PositionsOrder On PositionsOrder.NumberOrder = Orders.numberOrder INNER Join Products On Products.ID_Product = PositionsOrder.id_product WHERE DateDelivery BETWEEN(DATE_SUB(Now(), INTERVAL 360 DAY)) AND Now() And Orders.id_statusOrder = 5 Group by Month(DateDelivery)");
            List<int> month = new List<int>();

            for (int i = 0; i < command.MainTable.Rows.Count; i++) // получаем актиные месяцы продаж
            {
                month.Add(int.Parse(command.MainTable.Rows[i][0].ToString()));
            }
            int index = 0;
            for (int i = 1; i < 12; i++)
            {
                if (month.Contains(i))
                {
                    _chart.Series["Series1"].Points.AddXY(i, command.MainTable.Rows[index][1].ToString());
                    index++;
                }
                else
                {
                    _chart.Series["Series1"].Points.AddXY(i, 0);
                }
            }
        }




        public void FillingOrderDay(Chart _chart)
        {
            _chart.Series["Series1"].Points.Clear();
            CommandDB command = new CommandDB();
            command.LoadData($"SELECT Hour(DateDelivery), Count(*) FROM `Orders` Inner Join PositionsOrder On PositionsOrder.NumberOrder = Orders.numberOrder INNER Join Products On Products.ID_Product = PositionsOrder.id_product WHERE DateDelivery BETWEEN(DATE_SUB(Now(), INTERVAL 1 DAY)) AND Now() And Orders.id_statusOrder = 5 Group by Hour(DateDelivery)");
            List<int> hour = new List<int>();
            for (int i = 0; i < command.MainTable.Rows.Count; i++)
            {
                hour.Add(int.Parse(command.MainTable.Rows[i][0].ToString()));
            }
            int index = 0;
            for (int i = 0; i < 24; i++)
            {
                if (hour.Contains(i))
                {
                    _chart.Series["Series1"].Points.AddXY(i, command.MainTable.Rows[index][1].ToString());
                    index++;
                }
                else
                {
                    _chart.Series["Series1"].Points.AddXY(i, 0);
                }
            }
        }
        public void FillingOrderMonth(Chart _chart)
        {
            _chart.Series["Series1"].Points.Clear();
            CommandDB command = new CommandDB();
            command.LoadData($"SELECT Day(DateDelivery), Count(*) FROM `Orders` Inner Join PositionsOrder On PositionsOrder.NumberOrder = Orders.numberOrder INNER Join Products On Products.ID_Product = PositionsOrder.id_product WHERE DateDelivery BETWEEN(DATE_SUB(Now(), INTERVAL 30 DAY)) AND Now() And Orders.id_statusOrder = 5 Group by Day(DateDelivery)");
            List<int> days = new List<int>();

            for (int i = 0; i < command.MainTable.Rows.Count; i++) // получаем актиные дни продаж
            {
                days.Add(int.Parse(command.MainTable.Rows[i][0].ToString()));
            }
            int index = 0;
            for (int i = 1; i < 30; i++)
            {
                if (days.Contains(i))
                {
                    _chart.Series["Series1"].Points.AddXY(i, command.MainTable.Rows[index][1].ToString());
                    index++;
                }
                else
                {
                    _chart.Series["Series1"].Points.AddXY(i, 0);
                }
            }
        }
        public void FillingOrderYear(Chart _chart)
        {
            _chart.Series["Series1"].Points.Clear();
            CommandDB command = new CommandDB();
            command.LoadData($"SELECT Month(DateDelivery), Count(*) FROM `Orders` Inner Join PositionsOrder On PositionsOrder.NumberOrder = Orders.numberOrder INNER Join Products On Products.ID_Product = PositionsOrder.id_product WHERE DateDelivery BETWEEN(DATE_SUB(Now(), INTERVAL 1 YEAR)) AND Now() And Orders.id_statusOrder = 5 Group by Month(DateDelivery)");
            List<int> month = new List<int>();

            for (int i = 0; i < command.MainTable.Rows.Count; i++) // получаем актиные месяцы продаж
            {
                month.Add(int.Parse(command.MainTable.Rows[i][0].ToString()));
            }
            int index = 0;
            for (int i = 1; i < 12; i++)
            {
                if (month.Contains(i))
                {
                    _chart.Series["Series1"].Points.AddXY(i, command.MainTable.Rows[index][1].ToString());
                    index++;
                }
                else
                {
                    _chart.Series["Series1"].Points.AddXY(i, 0);
                }
            }
        }
    }
}
