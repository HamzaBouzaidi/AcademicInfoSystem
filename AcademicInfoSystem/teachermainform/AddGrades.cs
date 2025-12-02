using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using AcademicInfoSystem.Models;
namespace AcademicInfoSystem.TeacherMainForm
  
{
    public partial class AddGrades
    {
        public AddGrades()
        {
            InitializeComponent();
        }
        bool verify()
        {
            if ((textBoxStudentId.Text.Trim() == "") ||
                (textBoxSubjectId.Text.Trim() == "") ||
                (textBoxValue.Text.Trim() == "") ||
                (dateTimePicker1.Text.Trim() == "") ||
                 (textBoxComment.Text.Trim() == ""))

            {
                return false;
            }
            else
            {
                return true;


            }
        }


        private void buttonAddGrade_Click(object sender, EventArgs e)
        {
            if (!verify())
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            Grade grade = new Grade();
            int studentId = int.Parse(textBoxStudentId.Text.Trim());
            int subjectId = int.Parse(textBoxSubjectId.Text.Trim());
            string value = textBoxValue.Text.Trim(); // Keep as string for grades like "A", "B+", "85"
            DateTime date = dateTimePicker1.Value;
            string comment = textBoxComment.Text.Trim();

            // GradeId is 0 or let the database auto-generate it
            int gradeId = 0;

            bool success = grade.AddGrade( studentId, subjectId, value, date, comment);

            if (success)
                MessageBox.Show("Grade added successfully!");
            else
                MessageBox.Show("Failed to add grade. Check foreign keys or database connection.");
        }
    }
}
