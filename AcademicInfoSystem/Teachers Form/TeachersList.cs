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
    public partial class TeachersList : Form
    {
        public TeachersList()
        {
            InitializeComponent();
        }

        Teacher Teacher = new Teacher();
        private void TeachersListForm_Load(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("Select * from teacher");
            dataGridView3.ReadOnly = true;
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            dataGridView3.RowTemplate.Height = 30;
            dataGridView3.DataSource = Teacher.GetTeacherList(command);
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
