using AcademicInfoSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademicInfoSystem.Forms_Subject
{
    public partial class CreateSubjectForm : Form
    {
        public CreateSubjectForm()
        {
            InitializeComponent();


        }


        bool verify()
        {
            if ((textBoxSubjectName.Text.Trim() == "") ||
                (textBoxTeacherId.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;


            }
        }
        private void buttonAddSubject_Click(object sender, EventArgs e)
        {

            if (!verify())
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
           
            Subject subject = new Subject();
            string Name = textBoxSubjectName.Text.Trim();
            int TeacherId = textBoxTeacherId.Text.Trim() == "" ? 0 : int.Parse(textBoxTeacherId.Text.Trim());
            int SubjectId = 0; // Assuming SubjectId is auto-incremented in the database



            bool success = subject.AddSubject(SubjectId, Name, TeacherId);
            if (success)
                MessageBox.Show("Subject added successfully!");
            else
                MessageBox.Show("Failed to add subject. Check foreign keys or database connection.");
        }

        private void buttonCancelSubject_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
