using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SupermarketManagementSystem
{
    internal class DatabaseConnector
    {
        public static string connectionString = "server=localhost;user=root;password=;database=app_supermarket_management;";
        public static MySqlConnection GetConnection()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            return connection;
        }
        public static MySqlDataReader ExecuteQuery(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, GetConnection());
            MySqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }
        public static MySqlDataAdapter ExercuteAdapater(string query)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, GetConnection());
            return adapter;
        }
    }
}
