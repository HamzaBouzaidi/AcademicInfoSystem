using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using AcademicInfoSystem.Models;

namespace AcademicInfoSystem
{
    public partial class updateStudentForm : Form
    {
        public updateStudentForm()
        {
            InitializeComponent();
        }

        Student student = new Student();
        bool verify()
        {
            if ((textBoxFirstName.Text.Trim() == "") ||
                (textBoxLastName.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;


            }


        }
        
        private void buttonFind_Click(object sender, EventArgs e)
        {

            int StudentId = Convert.ToInt32(textBoxStudentId.Text);
            MySqlCommand command = new MySqlCommand("SELECT StudentId, FirstName, LastName, UserId, GroupId, StudentGroup FROM Student Where StudentId = " + StudentId);
            DataTable table = student.GetStudentList(command);
            if (table.Rows.Count > 0)
            {
                textBoxFirstName.Text = table.Rows[0]["FirstName"].ToString();
                textBoxLastName.Text = table.Rows[0]["LastName"].ToString();
                textBoxGroupId.Text = table.Rows[0]["GroupId"].ToString();
                textBoxStudentGroup.Text = table.Rows[0]["StudentGroup"].ToString();
            }
            else
            {
                MessageBox.Show("Student not found.");
            }
        }

        private void buttonEditStudent_Click(object sender, EventArgs e)
        {

            int StudentId = Convert.ToInt32(textBoxStudentId.Text);
            string firstName = textBoxFirstName.Text;
            string lastName = textBoxLastName.Text;
            int GroupId = Convert.ToInt32(textBoxGroupId.Text);
            string StudentGroup = textBoxStudentGroup.Text;
            if (student.UpdateStudentList(StudentId, firstName, lastName, GroupId, StudentGroup))
            {
                MessageBox.Show("Student updated successfully!");
            }
            else
            {
                MessageBox.Show("Failed to update student. Check foreign keys or database connection.");
            }


        }
         

        private void buttonRemove_Click(object sender, EventArgs e)
        {

            
            int StudentId = Convert.ToInt32(textBoxStudentId.Text);
            if (MessageBox.Show("Are you sure you wanna delete this student ", "Delet Student ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
            {
                if (student.DeleteStudent(StudentId))
                {
                    MessageBox.Show("Student deleted successfully!", "Delete student ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxFirstName.Text = "";
                    textBoxLastName.Text = "";
                    textBoxGroupId.Text = "";
                    textBoxStudentGroup.Text = "";
                }
                else
                {
                    MessageBox.Show("Failed to delete student. Check database connection.", "Delete student ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                }
            
        }
    
    }
}
