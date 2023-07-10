using System.Data;
using MySql.Data.MySqlClient;

namespace ObmennikNew.Classes
{
    class Connection
    {
        private MySqlConnection sqlConnection = new MySqlConnection("datasource = localhost; port = 3306; username = root; password = ; database = CurrencyExchanger_db");

        public MySqlConnection GetConnection()
        {
            return sqlConnection;
        }

        public void OpenConnection()
        {
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        public void CloseConnection()
        {
            if (sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }
    }
}