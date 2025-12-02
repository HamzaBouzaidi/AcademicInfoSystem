using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace AcademicInfoSystem.Database
{
    internal class DatabaseConnection
    {
        private static string connectionString = "Server=localhost;Database=AcademicSystem;User=root;Password=Iloveshelly123?;";
         private static MySqlConnection connection = new MySqlConnection(connectionString);
        public static MySqlConnection GetConnection()
        {
           
            
            return connection;

        }


        public void openConnection()
        {
           if (GetConnection().State == System.Data.ConnectionState.Closed)
            {
                GetConnection().Open();
            }
           
        }
        public void closeconnection()
        {
            if (GetConnection().State == System.Data.ConnectionState.Open)
            {
                GetConnection().Close();
            }
        }
      
    }
}
