using AcademicInfoSystem.Models;
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

namespace AcademicInfoSystem.teachermainform
{
    public partial class GradeList : Form
    {
        public GradeList()
        {
            InitializeComponent();
        }

        Grade grade = new Grade();
        private void GradeListForm_Load(object sender, EventArgs e)
        {
            try
            {
                // ✅ MODIFIED: Include StudentId and SubjectId
                MySqlCommand command = new MySqlCommand(
                    "SELECT g.GradeId, g.StudentId, s.FirstName, s.LastName, " +
                    "g.SubjectId, sub.Name AS SubjectName, g.Value, g.Date, g.Comment " +
                    "FROM grade g " +
                    "JOIN student s ON g.StudentId = s.StudentId " +
                    "JOIN subject sub ON g.SubjectId = sub.SubjectId");

                dataGridView4.ReadOnly = true;
                dataGridView4.RowTemplate.Height = 30;
                dataGridView4.DataSource = grade.GetGradeList(command);

                // Optional: Hide ID columns if you want
                if (dataGridView4.Columns.Count > 0)
                {
                    dataGridView4.Columns[0].HeaderText = "Grade ID";
                    dataGridView4.Columns[1].HeaderText = "Student ID";
                    dataGridView4.Columns[2].HeaderText = "First Name";
                    dataGridView4.Columns[3].HeaderText = "Last Name";
                    dataGridView4.Columns[4].HeaderText = "Subject ID";
                    dataGridView4.Columns[5].HeaderText = "Subject";
                    dataGridView4.Columns[6].HeaderText = "Grade";
                    dataGridView4.Columns[7].HeaderText = "Date";
                    dataGridView4.Columns[8].HeaderText = "Comment";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading grade list: {ex.Message}");
            }
        }
        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if clicked on a valid data row (not header)
            if (e.RowIndex < 0 || dataGridView4.CurrentRow == null)
                return;

            try
            {
                // Create the EditDeleteGradeForm
                EditDeleteGradeForm editForm = new EditDeleteGradeForm();

                // DEBUG: Show what's in each cell
                string debugInfo = "";
                for (int i = 0; i < dataGridView4.Columns.Count; i++)
                {
                    debugInfo += $"Col {i} [{dataGridView4.Columns[i].HeaderText}]: {dataGridView4.CurrentRow.Cells[i].Value}\n";
                }
                MessageBox.Show(debugInfo, "Debug - Grid Data");

                // Now you can see which columns have what data
                // Based on your grid, columns are:
                // 0: Grade ID, 1: First Name, 2: Last Name, 3: Subject, 4: Grade, 5: Date, 6: Comment

                // Fill the form with data (adjust indices based on debug output)
                editForm.textBoxStudentId.Text = "???"; // You don't have Student ID in grid
                editForm.textBoxSubjectId.Text = "???"; // You don't have Subject ID in grid
                editForm.textBoxValue.Text = dataGridView4.CurrentRow.Cells[4].Value?.ToString() ?? "";

                // Parse date safely
                if (dataGridView4.CurrentRow.Cells[5].Value != null)
                {
                    if (DateTime.TryParse(dataGridView4.CurrentRow.Cells[5].Value.ToString(), out DateTime dateValue))
                    {
                        editForm.dateTimePicker1.Value = dateValue;
                    }
                }

                editForm.textBoxComment.Text = dataGridView4.CurrentRow.Cells[6].Value?.ToString() ?? "";

                // Show the form
                editForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening form: {ex.Message}");
            }
        }


    }
}
    
