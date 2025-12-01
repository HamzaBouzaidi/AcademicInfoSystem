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
    internal class Teacher
    {

        public bool AddTeacher(int TeacherId,  int UserId)
        {
            try
            {
                MySqlConnection connection = DatabaseConnection.GetConnection();
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                MySqlCommand command = new MySqlCommand("INSERT INTO teacher (TeacherId, UserId) VALUES (@TeaId, @UsrId)", connection);
                command.Parameters.Add("@TeaId", MySqlDbType.Int32).Value = TeacherId;
                command.Parameters.Add("@UsrId", MySqlDbType.Int32).Value = UserId;
                



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

        // list subjects
        public DataTable GetTeacherList(MySqlCommand command)
        {
            command.Connection = DatabaseConnection.GetConnection();

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }

        public bool UpdateTeacher(int TeacherId, int UserId)
        {

            try
            {
                MySqlConnection connection = DatabaseConnection.GetConnection();
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                MySqlCommand command = new MySqlCommand("UPDATE teacher SET TeacherId=@TeaId, UserId=@UsrId WHERE TeacherId=@TeaId", connection);
                command.Parameters.Add("@TeaId", MySqlDbType.Int32).Value = TeacherId;
                command.Parameters.Add("@UsrId", MySqlDbType.Int32).Value = UserId;
                

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


        public bool DeleteTeacher(int TeacherId)
        {
            try
            {
                MySqlConnection connection = DatabaseConnection.GetConnection();
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                MySqlCommand command = new MySqlCommand("DELETE FROM teacher WHERE TeacherId=@TeaId", connection);
                command.Parameters.Add("@TeaId", MySqlDbType.Int32).Value = TeacherId;
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

        public DataTable GetteacherList(MySqlCommand command)
        {
            command.Connection = DatabaseConnection.GetConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }
    }


}
