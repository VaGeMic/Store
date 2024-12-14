using Npgsql;

namespace Store
{
    internal class ConnectToDB
    {
        static string connectString = "Server=localhost; Port=5432; Database=Store; User Id = postgres; Password = 1111";

        private NpgsqlConnection connection = new NpgsqlConnection(connectString);

        public void OpenConnetion()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public void CloseConnetion()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public NpgsqlConnection GetConnection()
        {
            return connection;
        }
    }
}
