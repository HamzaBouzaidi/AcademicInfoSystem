using AcademicInfoSystem.Database;
using AcademicInfoSystem.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace AcademicInfoSystem.Models
{
    internal class Grade
    {

        public bool AddGrade(int StudentId, int SubjectId, string Value, DateTime Date, string Comment)
        {
            try
            {
                
                using (MySqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();

                    MySqlCommand command = new MySqlCommand(
                        "INSERT INTO grade (StudentId, SubjectId, Value, Date, Comment) VALUES (@stdId, @subId, @Val, @Da, @Com)",
                        connection);

                    command.Parameters.AddWithValue("@stdId", StudentId);
                    command.Parameters.AddWithValue("@subId", SubjectId);
                    command.Parameters.AddWithValue("@Val", Value);
                    command.Parameters.AddWithValue("@Da", Date);
                    command.Parameters.AddWithValue("@Com", Comment);

                    int result = command.ExecuteNonQuery();
                    return result == 1;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Database Error: {ex.Message}");
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return false;
            }
        }


        public DataTable GetGradeList(MySqlCommand command)
        {
            try
            {
                // FIXED: Using statement should have parentheses for clarity
                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    command.Connection = conn;

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading grades: {ex.Message}");
                return new DataTable();
            }
        }
    }
}



