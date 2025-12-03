using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademicInfoSystem.StudentMainForm
{
    public partial class StudentFinalGrades : Form
    {
        public StudentFinalGrades()
        {
            InitializeComponent();
            AddDataGridView();
        }
        private void AddDataGridView()
        {
            // Create and configure DataGridView
            dataGridView5 = new DataGridView
            {
                Name = "dataGridView5",
                Location = new Point(15, 280),  // Position it below your textboxes
                Size = new Size(700, 300),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
                ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            };

            // Add to form
            this.Controls.Add(dataGridView5);

            // Make sure it's visible
            dataGridView5.BringToFront();
        }
    }
}
