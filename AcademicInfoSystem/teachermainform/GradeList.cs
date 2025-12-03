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
                // ✅ FIX: Your SQL has wrong column names
                // Your Grade table has "Value" column, not "GradeValue"
                MySqlCommand command = new MySqlCommand(
                    "SELECT g.GradeId, s.FirstName, s.LastName, sub.Name AS SubjectName, g.Value, g.Date, g.Comment " +
                    "FROM grade g " +
                    "JOIN student s ON g.StudentId = s.StudentId " +
                    "JOIN subject sub ON g.SubjectId = sub.SubjectId");

                dataGridView4.ReadOnly = true;
                dataGridView4.RowTemplate.Height = 30;

                // ✅ FIX: Call the correct method
                dataGridView4.DataSource = grade.GetGradeList(command);

                // Optional: Format columns
                if (dataGridView4.Columns.Count > 0)
                {
                    dataGridView4.Columns[0].HeaderText = "Grade ID";
                    dataGridView4.Columns[1].HeaderText = "First Name";
                    dataGridView4.Columns[2].HeaderText = "Last Name";
                    dataGridView4.Columns[3].HeaderText = "Subject";
                    dataGridView4.Columns[4].HeaderText = "Grade";
                    dataGridView4.Columns[5].HeaderText = "Date";
                    dataGridView4.Columns[6].HeaderText = "Comment";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading grade list: {ex.Message}");
            }
        }
    }
}
    
