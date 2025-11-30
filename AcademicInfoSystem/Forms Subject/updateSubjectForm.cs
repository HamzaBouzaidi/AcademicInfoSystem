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
using MySql.Data.MySqlClient;

namespace AcademicInfoSystem.Forms_Subject
{
    public partial class updateSubjectForm : Form
    {
        public updateSubjectForm()
        {
            InitializeComponent();
        }

        Subject subject = new Subject();

        bool verify ()
        {
            if ((textBoxSubjectName.Text == "") ||
              
                (textBoxTeacherId.Text == ""))
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
            int SubjectId = Convert.ToInt32(textBoxSubjectId.Text);
            MySqlCommand command = new MySqlCommand("SELECT SubjectId, Name, TeacherId FROM subject Where SubjectId = " + SubjectId);
            DataTable table = subject.GetSubjectList(command);
            if (table.Rows.Count > 0)
            {
                textBoxSubjectName.Text = table.Rows[0]["Name"].ToString();
                textBoxTeacherId.Text = table.Rows[0]["TeacherId"].ToString();
            }
            else
            {
                MessageBox.Show("Subject not found.");
            }

        }

        public void buttonEditSubject_Click(object sender, EventArgs e)
        {
           int SubjectId = Convert.ToInt32(textBoxSubjectId.Text);
              string Name = textBoxSubjectName.Text;
              int TeacherId = textBoxTeacherId.Text.Trim() == "" ? 0 : int.Parse(textBoxTeacherId.Text.Trim());
                if(subject.UpdateSubject(SubjectId,  Name, TeacherId))
                {
                    MessageBox.Show("Subject updated successfully.");
                }
                else
                {
                    MessageBox.Show("Failed to update subject. Check foreign keys or database connection.");
                }
        }


        public void buttonRemoveSubject_Click(object sender, EventArgs e)
        {
           int SubjectId = Convert.ToInt32(textBoxSubjectId.Text);
                if(subject.DeleteSubject(SubjectId))
                {
                    MessageBox.Show("Subject deleted successfully.");
                }
                else
                {
                    MessageBox.Show("Failed to delete subject. It may be referenced by other records.");
            }
        }
    }
}
