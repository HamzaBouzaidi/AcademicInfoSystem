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

namespace AcademicInfoSystem
{
    public partial class StudentListForm : Form
    {
        public StudentListForm()
        {
            InitializeComponent();
        }

        Student student = new Student();
        private void StudentListForm_Load(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("Select * from Student");
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.DataSource = student.GetStudentList(command);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            updateStudentForm updateDeleteStudentForm = new updateStudentForm();
            updateDeleteStudentForm.textBoxStudentId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            updateDeleteStudentForm.textBoxFirstName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            updateDeleteStudentForm.textBoxLastName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            updateDeleteStudentForm.textBoxStudentGroup.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            updateDeleteStudentForm.textBoxGroupId.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            updateDeleteStudentForm.Show();
        }
    }

}
