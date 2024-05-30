using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;

namespace CRUD_ADO.NET.DataBase
{
    public class Connection
    {
        private string database;
        private string server;
        private string port;
        private string user;
        private string pass;

        public Connection()
        {
            database = ConfigurationManager.AppSettings["Database"];
            server = ConfigurationManager.AppSettings["Server"];
            port = ConfigurationManager.AppSettings["Port"];
            user = ConfigurationManager.AppSettings["User"];
            pass = ConfigurationManager.AppSettings["Password"];
        }

        public ConnectionState State { get; }

        public MySqlConnection GetConnection()
        {
            string stringBuilder = $"database ={database}; datasource={server}; port={port}; username ={user}; password = {pass}";

            MySqlConnection conn = new MySqlConnection(stringBuilder);

            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message, "NOTIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return conn;
        }
    }
}
