using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    internal class MakeReport
    {
        public void MakeRoportOrder(DataTable data, DataGridViewCellEventArgs e)
        {
            try
            {
                var ind = e.RowIndex;
                var dataForOrder = data.Rows[ind];
                var id = dataForOrder[0];
                string name = string.Format("Заказ №{0}", id);
                var sW = new StreamWriter("C:\\Users\\Женя\\source\\repos\\CargoTransportations\\ReportsOfOrders\\" + name + ".txt");

                var id_trailer = int.Parse(dataForOrder[1].ToString());
                var id_driver = int.Parse(dataForOrder[2].ToString());
                var id_partner = int.Parse(dataForOrder[3].ToString());
                var id_client = int.Parse(dataForOrder[4].ToString());

                WorkWithDB DBT = new WorkWithDB();
                var trailer = DBT.LoadDataFromDB($"select model, numsing, id from trailers where id = {id_trailer}");
                WorkWithDB DBD = new WorkWithDB();
                var driver = DBD.LoadDataFromDB($"select surname, name, phone, id from drivers where id = {id_driver}");
                WorkWithDB DBP = new WorkWithDB();
                var partner = DBP.LoadDataFromDB($"select surname, name, phone, id from drivers where id = {id_partner}");
                WorkWithDB DBC = new WorkWithDB();
                var client = DBC.LoadDataFromDB($"select surname, name, phone, id from clients where id = {id_client}");

                if (int.Parse(dataForOrder[3].ToString()) == 0) { var partner1 = "На данном заказе напарник не нужен"; }


                sW.WriteLine($"Данные о заказе №{id}:");
                sW.WriteLine($"Трейлер: Модель - {trailer.Rows[0][0]}, Номерной знак - {trailer.Rows[0][0]}");
                sW.WriteLine($"Водитель: {driver.Rows[0][0]} {driver.Rows[0][1]}, Телефон - {driver.Rows[0][2]}");
                if (id_partner == 0) { sW.WriteLine($"Напарник: На данном заказе напарник не нужен"); }
                else { sW.WriteLine($"Напарник: {partner.Rows[0][0]} {partner.Rows[0][1]}, Телефон - {partner.Rows[0][2]}"); }
                sW.WriteLine($"Клиент: {client.Rows[0][0]} {client.Rows[0][1]}, Телефон - {client.Rows[0][2]}");
                sW.WriteLine($"Пункт отправления: {dataForOrder[5]}");
                sW.WriteLine($"Пункт назначения: {dataForOrder[6]}");
                sW.WriteLine($"Примерная общая дистанция: {dataForOrder[7]}");
                sW.WriteLine($"Дата начала: {dataForOrder[8].ToString().Substring(0, 10)}");
                sW.WriteLine($"Дата завершения: {dataForOrder[9].ToString().Substring(0, 10)}");
                sW.WriteLine($"Общий вес груза: {dataForOrder[10]}");
                sW.WriteLine($"Общий объём груза: {dataForOrder[11]}");
                sW.WriteLine($"Примерная общая стоимость: {dataForOrder[12]}");
                sW.Close();

                MessageBox.Show("Отчёт о заказе успешно сформирован, можете найти его в папке с отчётами", "Отчёт о заказе", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}