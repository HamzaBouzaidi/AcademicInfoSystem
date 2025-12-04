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

namespace AcademicInfoSystem.Teachers_Form
{
    public partial class CreateNewTeacherForm : Form
    {
        public CreateNewTeacherForm()
        {
            InitializeComponent();
        }

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

        private void buttonAddTeacher_Click(object sender, EventArgs e)
        {
            if (textBoxFirstName.Text == "" || textBoxLastName.Text == "")
            {
                MessageBox.Show("Fill all fields!");
                return;
            }

            Teacher teacher = new Teacher();

            bool success = teacher.AddTeacher(
                textBoxFirstName.Text.Trim(),
                textBoxLastName.Text.Trim()
            );

            if (success)
                MessageBox.Show("Teacher added successfully!");
            else
                MessageBox.Show("Failed to add teacher.");
        }


        private void buttonCancelTeacher_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
