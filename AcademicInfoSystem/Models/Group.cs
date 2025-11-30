using AcademicInfoSystem.Database;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicInfoSystem.Models
{
    internal class Group
    {
        public bool AddGroup(int GroupId, string Name)
        {
            try
            {
                MySqlConnection connection = DatabaseConnection.GetConnection();
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                MySqlCommand command = new MySqlCommand("INSERT INTO studentgroup (GroupId, Name) VALUES (@studgId, @Na)", connection);
                command.Parameters.Add("@studgId", MySqlDbType.Int32).Value = GroupId;
                command.Parameters.Add("@Na", MySqlDbType.VarChar).Value = Name;




                int result = command.ExecuteNonQuery();

                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();


                }
                return result == 1;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
                return false;

            }

        }



        public DataTable GetGrouptList(MySqlCommand command)
        {
            command.Connection = DatabaseConnection.GetConnection();

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }

        public bool UpdateGroup(int GroupId, string Name)
        {

            try
            {
                MySqlConnection connection = DatabaseConnection.GetConnection();
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                MySqlCommand command = new MySqlCommand("UPDATE studentgroup SET GroupId=@studgId, Name=@Na WHERE GroupId=@studgId", connection);
                command.Parameters.Add("@studgId", MySqlDbType.Int32).Value = GroupId;
                command.Parameters.Add("@Na", MySqlDbType.VarChar).Value = Name;
                

                int result = command.ExecuteNonQuery();
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();

                }
                return result == 1;

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
                return false;
            }

        }



        public bool DeleteGroup(int GroupId)
        {
            try
            {
                MySqlConnection connection = DatabaseConnection.GetConnection();
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                MySqlCommand command = new MySqlCommand("DELETE FROM studentgroup WHERE GroupId = @studgId", connection);
                command.Parameters.Add("@studgId", MySqlDbType.Int32).Value = GroupId;
                int result = command.ExecuteNonQuery();
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
                return result == 1;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
                return false;
            }
        }



        public DataTable GetGroupList(MySqlCommand command)
        {
            command.Connection = DatabaseConnection.GetConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }
    }
}
