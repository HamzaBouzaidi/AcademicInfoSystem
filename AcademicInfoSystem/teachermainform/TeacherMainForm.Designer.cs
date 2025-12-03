using AcademicInfoSystem.teachermainform;
namespace AcademicInfoSystem.TeacherMainForm
{
    partial class TeacherMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            studentsGradesToolStripMenuItem = new ToolStripMenuItem();
            addGradeToolStripMenuItem = new ToolStripMenuItem();
            gradeListToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { studentsGradesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1202, 37);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // studentsGradesToolStripMenuItem
            // 
            studentsGradesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addGradeToolStripMenuItem, gradeListToolStripMenuItem });
            studentsGradesToolStripMenuItem.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            studentsGradesToolStripMenuItem.Name = "studentsGradesToolStripMenuItem";
            studentsGradesToolStripMenuItem.Size = new Size(199, 33);
            studentsGradesToolStripMenuItem.Text = "Students Grades";
            // 
            // addGradeToolStripMenuItem
            // 
            addGradeToolStripMenuItem.BackColor = Color.DarkSalmon;
            addGradeToolStripMenuItem.Name = "addGradeToolStripMenuItem";
            addGradeToolStripMenuItem.Size = new Size(202, 34);
            addGradeToolStripMenuItem.Text = "Add Grade";
            addGradeToolStripMenuItem.Click += addGradeToolStripMenuItem_Click;
            // 
            // gradeListToolStripMenuItem
            // 
            gradeListToolStripMenuItem.BackColor = Color.DarkSalmon;
            gradeListToolStripMenuItem.Name = "gradeListToolStripMenuItem";
            gradeListToolStripMenuItem.Size = new Size(202, 34);
            gradeListToolStripMenuItem.Text = "Grade List ";
            gradeListToolStripMenuItem.Click += this.gradeListToolStripMenuItem_Click;
            // 
            // TeacherMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1202, 579);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "TeacherMainForm";
            Text = "TeacherMainForm";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem studentsGradesToolStripMenuItem;
        private ToolStripMenuItem addGradeToolStripMenuItem;
        private ToolStripMenuItem gradeListToolStripMenuItem;


        private void addGradeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddGrades addGradesForm = new AddGrades();
            addGradesForm.Show(this);
        }


        private void gradeListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GradeList gradeListForm = new GradeList();
            gradeListForm.Show(this);
        }
    }

}