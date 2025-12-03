using AcademicInfoSystem.Database;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademicInfoSystem.StudentMainForm
{
    public partial class ViewGradesForm : Form
    {
        public ViewGradesForm()
        {
            InitializeComponent();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            string studentId = textBoxStudentId.Text.Trim();
            string subjectId = textBoxSubjectId.Text.Trim();

            if (string.IsNullOrEmpty(studentId) || string.IsNullOrEmpty(subjectId))
            {
                MessageBox.Show("Please enter both Student ID and Subject ID.");
                return;
            }

            try
            {
                int studentIdInt = int.Parse(studentId);
                int subjectIdInt = int.Parse(subjectId);

                // FIXED: Use DatabaseConnection.GetConnection() instead of hardcoded string
                string sql = "SELECT Value, Date, Comment FROM grade WHERE StudentId = @sid AND SubjectId = @subid";

                using (MySqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@sid", studentIdInt);
                        command.Parameters.AddWithValue("@subid", subjectIdInt);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            StringBuilder results = new StringBuilder();
                            int count = 0;

                            while (reader.Read())
                            {
                                count++;
                                results.AppendLine($"Grade {count}:");
                                results.AppendLine($"  Value: {reader["Value"]}");
                                results.AppendLine($"  Date: {reader["Date"]}");
                                results.AppendLine($"  Comment: {reader["Comment"]}");
                                results.AppendLine();
                            }

                            if (count > 0)
                            {
                                MessageBox.Show($"Found {count} grade(s):\n\n{results.ToString()}",
                                                "Student Grades");
                            }
                            else
                            {
                                MessageBox.Show("No grades found for this Student ID and Subject ID.");
                            }
                        }
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers for Student ID and Subject ID.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}