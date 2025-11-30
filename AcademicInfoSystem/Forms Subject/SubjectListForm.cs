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

namespace AcademicInfoSystem.Forms_Subject
{
    public partial class SubjectListForm : Form
    {
        public SubjectListForm()
        {
            InitializeComponent();
        }
       
        Subject subject = new Subject();
        private void SubjectListForm_Load(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("Select * from subject");
            dataGridView2.ReadOnly = true;
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            dataGridView2.RowTemplate.Height = 30;
            dataGridView2.DataSource = subject.GetSubjectsList(command);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            updateStudentForm updateStudentForm = new updateStudentForm();
          //  updateStudentForm.textBoxSubjectId.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
          //  updateStudentForm.textBoxSubjectName.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
           // updateStudentForm.textBoxTeacherId.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
           // updateStudentForm.Show();
        }
    }
}
