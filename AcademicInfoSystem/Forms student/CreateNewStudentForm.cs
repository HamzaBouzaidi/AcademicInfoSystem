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
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            string firstName = textBoxFname.Text.Trim();
            string lastName = textBoxLname.Text.Trim();
            int groupId = int.Parse(textBoxGroupId.Text.Trim());
            string groupName = textBoxStudentGroup.Text.Trim();

            Student student = new Student();
            bool success = student.AddStudent(firstName, lastName, groupId, groupName);

            if (success)
                MessageBox.Show("Student added successfully!");
            else
                MessageBox.Show("Failed to add student.");
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
