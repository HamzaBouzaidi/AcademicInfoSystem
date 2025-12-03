using AcademicInfoSystem.Database;
using AcademicInfoSystem.Models;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace AcademicInfoSystem.teachermainform
{
    public partial class EditDeleteGradeForm : Form
    {
        private Grade _grade = new Grade();
        private int _currentGradeId = 0; // Store the Grade ID being edited

        public EditDeleteGradeForm()
        {
            InitializeComponent();
        }

        // Constructor with GradeId parameter (when clicked from grid)
        public EditDeleteGradeForm(int gradeId) : this()
        {
            _currentGradeId = gradeId;
            LoadGradeData(gradeId);
        }

        private void LoadGradeData(int gradeId)
        {
            try
            {
                string sql = "SELECT * FROM grade WHERE GradeId = @gradeId";
                // FIXED: Use DatabaseConnection.GetConnection() instead of hardcoded string

                using (MySqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@gradeId", gradeId);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Fill form fields
                                textBoxStudentId.Text = reader["StudentId"].ToString();
                                textBoxSubjectId.Text = reader["SubjectId"].ToString();
                                textBoxValue.Text = reader["Value"].ToString();
                                textBoxComment.Text = reader["Comment"].ToString();

                                // Parse date
                                if (reader["Date"] != DBNull.Value)
                                {
                                    dateTimePicker1.Value = Convert.ToDateTime(reader["Date"]);
                                }

                                // Change button text to "Update" since we're editing
                                buttonEditGrade.Text = "Update";
                            }
                            else
                            {
                                MessageBox.Show("Grade not found!");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading grade: {ex.Message}");
            }
        }

        // FIND button - Find grade by ID
        private void buttonFindGrade_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxStudentId.Text) ||
                string.IsNullOrWhiteSpace(textBoxSubjectId.Text))
            {
                MessageBox.Show("Please enter Student ID and Subject ID to find.");
                return;
            }

            try
            {
                int studentId = int.Parse(textBoxStudentId.Text.Trim());
                int subjectId = int.Parse(textBoxSubjectId.Text.Trim());

                string sql = "SELECT * FROM grade WHERE StudentId = @studentId AND SubjectId = @subjectId";
                // FIXED: Use DatabaseConnection.GetConnection() instead of hardcoded string

                using (MySqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@studentId", studentId);
                        command.Parameters.AddWithValue("@subjectId", subjectId);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Store Grade ID
                                _currentGradeId = Convert.ToInt32(reader["GradeId"]);

                                // Fill other fields
                                textBoxValue.Text = reader["Value"].ToString();
                                textBoxComment.Text = reader["Comment"].ToString();

                                if (reader["Date"] != DBNull.Value)
                                {
                                    dateTimePicker1.Value = Convert.ToDateTime(reader["Date"]);
                                }

                                // Change button to "Update"
                                buttonEditGrade.Text = "Update";

                                MessageBox.Show("Grade found!");
                            }
                            else
                            {
                                MessageBox.Show("No grade found for this student and subject.");
                                // Change button to "Add" since we'll be adding new
                                buttonEditGrade.Text = "Add";
                                _currentGradeId = 0;
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
                MessageBox.Show($"Error finding grade: {ex.Message}");
            }
        }

        // EDIT/UPDATE button - Update existing grade or add new
        private void buttonEditGrade_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            try
            {
                int studentId = int.Parse(textBoxStudentId.Text.Trim());
                int subjectId = int.Parse(textBoxSubjectId.Text.Trim());
                string value = textBoxValue.Text.Trim();
                DateTime date = dateTimePicker1.Value;
                string comment = textBoxComment.Text.Trim();

                bool success = false;

                if (_currentGradeId > 0)
                {
                    // UPDATE existing grade
                    success = UpdateGrade(_currentGradeId, studentId, subjectId, value, date, comment);
                    if (success)
                        MessageBox.Show("Grade updated successfully!");
                }
                else
                {
                    // ADD new grade
                    success = AddGrade(studentId, subjectId, value, date, comment);
                    if (success)
                        MessageBox.Show("Grade added successfully!");
                }

                if (success)
                {
                    ClearForm();
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

        // REMOVE button - Delete grade
        private void buttonRemoveGrade_Click(object sender, EventArgs e)
        {
            if (_currentGradeId == 0)
            {
                MessageBox.Show("Please find a grade first before deleting.");
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete grade ID {_currentGradeId}?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    bool success = DeleteGrade(_currentGradeId);
                    if (success)
                    {
                        MessageBox.Show("Grade deleted successfully!");
                        ClearForm();
                        _currentGradeId = 0;
                        buttonEditGrade.Text = "Add";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting grade: {ex.Message}");
                }
            }
        }

        // CANCEL button
        private void buttonCancelGrade_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Helper Methods
        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(textBoxStudentId.Text) ||
                string.IsNullOrWhiteSpace(textBoxSubjectId.Text) ||
                string.IsNullOrWhiteSpace(textBoxValue.Text))
            {
                MessageBox.Show("Please fill in Student ID, Subject ID, and Grade Value.");
                return false;
            }
            return true;
        }

        private bool AddGrade(int studentId, int subjectId, string value, DateTime date, string comment)
        {
            return _grade.AddGrade(studentId, subjectId, value, date, comment);
        }

        private bool UpdateGrade(int gradeId, int studentId, int subjectId, string value, DateTime date, string comment)
        {
            try
            {
                string sql = "UPDATE grade SET StudentId = @studentId, SubjectId = @subjectId, " +
                            "Value = @value, Date = @date, Comment = @comment " +
                            "WHERE GradeId = @gradeId";
                // FIXED: Use DatabaseConnection.GetConnection() instead of hardcoded string

                using (MySqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@gradeId", gradeId);
                        command.Parameters.AddWithValue("@studentId", studentId);
                        command.Parameters.AddWithValue("@subjectId", subjectId);
                        command.Parameters.AddWithValue("@value", value);
                        command.Parameters.AddWithValue("@date", date);
                        command.Parameters.AddWithValue("@comment", comment);

                        int result = command.ExecuteNonQuery();
                        return result == 1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating grade: {ex.Message}");
                return false;
            }
        }

        private bool DeleteGrade(int gradeId)
        {
            try
            {
                string sql = "DELETE FROM grade WHERE GradeId = @gradeId";
                // FIXED: Use DatabaseConnection.GetConnection() instead of hardcoded string

                using (MySqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@gradeId", gradeId);

                        int result = command.ExecuteNonQuery();
                        return result == 1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting grade: {ex.Message}");
                return false;
            }
        }

        private void ClearForm()
        {
            textBoxStudentId.Clear();
            textBoxSubjectId.Clear();
            textBoxValue.Clear();
            textBoxComment.Clear();
            dateTimePicker1.Value = DateTime.Now;
            textBoxStudentId.Focus();
            _currentGradeId = 0;
            buttonEditGrade.Text = "Add";
        }
    }
}