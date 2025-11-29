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
        private void SubjectList_Load(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("Select * from Subject");
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.DataSource = subject.GetSubjectsList(command);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            updateStudentForm updateDeleteSubjectForm = new updateStudentForm();
            updateDeleteSubjectForm.textBoxStudentId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            updateDeleteSubjectForm.textBoxFirstName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            updateDeleteSubjectForm.textBoxLastName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            updateDeleteSubjectForm.Show();
        }
    }
}
