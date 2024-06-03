using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;

namespace CRUD_ADO.NET.DataBase
{
    public class Connection
    {
        private readonly string database;
        private readonly string server;
        private readonly string port;
        private readonly string user;
        private readonly string pass;
        private readonly string connectionString;
        private static MySqlConnection connection;

        public ConnectionState State { get; }

        public Connection()
        {
            database = ConfigurationManager.AppSettings["Database"];
            server = ConfigurationManager.AppSettings["Server"];
            port = ConfigurationManager.AppSettings["Port"];
            user = ConfigurationManager.AppSettings["User"];
            pass = ConfigurationManager.AppSettings["Password"];

            connectionString = $"database ={database}; datasource={server}; port={port}; username ={user}; password = {pass}";


        }

        public MySqlConnection GetConnection()
        {
            connection = new MySqlConnection(connectionString);
            try
            {
                if (State != ConnectionState.Open)
                {
                    connection.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message, "NOTIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return connection;
        }
    }
}
