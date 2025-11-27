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
    }
}
