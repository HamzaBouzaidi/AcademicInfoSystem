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
    internal class Grade
    {

        public bool AddGrade(int StudentId, int SubjectId, string Value, DateTime Date, string Comment)
        {
            try
            {
               
                string connString = "server=localhost;database=academicsystem;uid=root;pwd=Iloveshelly123?;";
                using (MySqlConnection connection = new MySqlConnection(connString))
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
        }
    }


}
