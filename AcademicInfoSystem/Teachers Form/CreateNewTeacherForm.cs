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
            if ((textBoxTeacherId.Text.Trim() == "") ||
                (textBoxUserId.Text.Trim() == ""))
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
            if (!verify())
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            Teacher teacher = new Teacher();

            int TeacherId = textBoxTeacherId.Text.Trim() == "" ? 0 : int.Parse(textBoxTeacherId.Text.Trim());
            int UserId = textBoxUserId.Text.Trim() == "" ? 0 : int.Parse(textBoxUserId.Text.Trim());


            bool success = teacher.AddTeacher(TeacherId, UserId);
            if (success)
                MessageBox.Show("Teacher added successfully!");
            else
                MessageBox.Show("Failed to add Teacher. Check foreign keys or database connection.");
        }

        private void buttonCancelTeacher_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
