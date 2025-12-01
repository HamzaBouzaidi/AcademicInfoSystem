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
    public partial class UpdateDeleteTeacherForm : Form
    {
        public UpdateDeleteTeacherForm()
        {
            InitializeComponent();
        }
        Teacher teacher = new Teacher();    
        bool verify()
        {
            if ((textBoxTeacherId.Text == "") ||

                (textBoxUserId.Text == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void buttonFindTeacherId_Click(object sender, EventArgs e)
        {
            int TeacherId = Convert.ToInt32(textBoxTeacherId.Text);
            MySqlCommand command = new MySqlCommand("SELECT TeacherId, UserId FROM teacher Where TeacherId = " + TeacherId);
            DataTable table = teacher.GetTeacherList(command);
            if (table.Rows.Count > 0)
            {
                textBoxTeacherId.Text = table.Rows[0]["TeacherId"].ToString();
                textBoxUserId.Text = table.Rows[0]["UserId"].ToString();
            }
            else
            {
                MessageBox.Show("Teacher not found.");
            }


        }

        private void buttonRemoveTeacher_Click(object sender, EventArgs e)
        {
            int TeacherId = Convert.ToInt32(textBoxTeacherId.Text);
            if (teacher.DeleteTeacher(TeacherId))
            {
                MessageBox.Show("Teacher  deleted successfully.");
            }
            else
            {
                MessageBox.Show("Failed to delete Teacher . It may be referenced by other records.");
            }
        }
    }
}
