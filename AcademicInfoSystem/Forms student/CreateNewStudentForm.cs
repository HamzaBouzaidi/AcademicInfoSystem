using AcademicInfoSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademicInfoSystem
{
    public partial class CreateNewStudentForm : Form
    {
        public CreateNewStudentForm()
        {
            InitializeComponent();
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
           
            if (!verify())
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            Student student = new Student();
            string firstName = textBoxFname.Text.Trim();
            string lastName = textBoxLname.Text.Trim();      
            string GroupIdtext = textBoxGroupId.Text.Trim();
            string StudentGroup = textBoxStudentGroup.Text.Trim();

            int userId = 1;   // Replace with the actual UserId from your User table
            int GroupId = int.Parse(GroupIdtext);
            bool success = student.AddStudent(firstName, lastName, userId, GroupId, StudentGroup);


            if (success)
                MessageBox.Show("Student added successfully!");
            else
                MessageBox.Show("Failed to add student. Check foreign keys or database connection.");
        }


        bool verify()
        {
            if ((textBoxFname.Text.Trim() == "") ||
                (textBoxLname.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;


            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
