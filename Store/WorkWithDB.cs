using Npgsql;
using System.Data;

namespace Store
{
    internal class WorkWithDB
    {
        DataSet dataSet = new DataSet();
        ConnectToDB conDB = new ConnectToDB();
        DataTable dt = new DataTable();
        NpgsqlCommand command;
        NpgsqlDataAdapter adapter;
        NpgsqlCommandBuilder builder;

        public DataTable LoadDataFromDB(string queryString)
        {
            try
            {
                conDB.OpenConnetion();

                adapter = new NpgsqlDataAdapter(queryString, conDB.GetConnection());

                builder = new NpgsqlCommandBuilder(adapter);

                builder.GetInsertCommand();
                builder.GetUpdateCommand();
                builder.GetDeleteCommand();

                adapter.Fill(dataSet);
                dt = dataSet.Tables[0];

                conDB.CloseConnetion();

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public DataTable ReloadDataFromDB()
        {
            try
            {
                conDB.OpenConnetion();

                dataSet.Tables[0].Clear();
                adapter.Fill(dataSet);
                dt = dataSet.Tables[0];

                conDB.CloseConnetion();

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public void UpdateDatainDB()
        {
            try
            {
                conDB.OpenConnetion();

                adapter.Update(dataSet.Tables[0]);

                conDB.CloseConnetion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
