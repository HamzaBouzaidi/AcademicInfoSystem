using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicInfoSystem.Database
{
    internal class DatabaseConnection
    {
        private static string connectionString = "Server=localhost;Database=AcademicSystem;User=root;Password=;";

        public static MySqlConnection GetConnection()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            return connection;
        }
    }
}
