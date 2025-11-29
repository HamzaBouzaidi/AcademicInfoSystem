using AcademicInfoSystem.Database;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace AcademicInfoSystem.Models
{
    internal class Subject
    {

        // do the same crud operations for subject as done for student in Student.cs 
        public bool AddSubject(int SubjectId, string Name, int TeacherId)
        {
            try
            {
                MySqlConnection connection = DatabaseConnection.GetConnection();
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                MySqlCommand command = new MySqlCommand("INSERT INTO subject (Name, TeacherId) VALUES (@subn, @TeaId)", connection);
                command.Parameters.Add("@subn", MySqlDbType.VarChar).Value = Name;
                command.Parameters.Add("@TeaId", MySqlDbType.Int32).Value = TeacherId;
                command.Parameters.Add("@sid", MySqlDbType.Int32).Value = SubjectId;



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
        public DataTable GetSubjectList(MySqlCommand command)
        {
            command.Connection = DatabaseConnection.GetConnection();

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }

        public bool UpdateSubject(int SubjectId, string Name, int TeacherId)
        {

            try
            {
                MySqlConnection connection = DatabaseConnection.GetConnection();
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                MySqlCommand command = new MySqlCommand("UPDATE subject SET Name=@subn, TeacherId=@TeaId WHERE SubjectId=@sid", connection);
                command.Parameters.Add("@subn", MySqlDbType.VarChar).Value = Name;
                command.Parameters.Add("@TeaId", MySqlDbType.Int32).Value = TeacherId;
                command.Parameters.Add("@sid", MySqlDbType.Int32).Value = SubjectId;

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


        public bool DeleteSubject(int SubjectId)
        {
            try
            {
                MySqlConnection connection = DatabaseConnection.GetConnection();
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                MySqlCommand command = new MySqlCommand("DELETE FROM subject WHERE SubjectId=@sid", connection);
                command.Parameters.Add("@sid", MySqlDbType.Int32).Value = SubjectId;
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

        public DataTable GetSubjectsList (MySqlCommand command)
        {
            command.Connection = DatabaseConnection.GetConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }
    }
}



