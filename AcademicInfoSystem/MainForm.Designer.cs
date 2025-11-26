namespace AcademicInfoSystem
{
    partial class MainForm
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
            studentToolStripMenuItem = new ToolStripMenuItem();
            createNewStudentToolStripMenuItem = new ToolStripMenuItem();
            updateStudentToolStripMenuItem = new ToolStripMenuItem();
            studentListToolStripMenuItem = new ToolStripMenuItem();
            manageFormToolStripMenuItem = new ToolStripMenuItem();
            printTheStudentFormToolStripMenuItem = new ToolStripMenuItem();
            subjectToolStripMenuItem = new ToolStripMenuItem();
            groupsToolStripMenuItem = new ToolStripMenuItem();
            gradesToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { studentToolStripMenuItem, subjectToolStripMenuItem, groupsToolStripMenuItem, gradesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(839, 38);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // studentToolStripMenuItem
            // 
            studentToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createNewStudentToolStripMenuItem, updateStudentToolStripMenuItem, studentListToolStripMenuItem, manageFormToolStripMenuItem, printTheStudentFormToolStripMenuItem });
            studentToolStripMenuItem.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            studentToolStripMenuItem.Size = new Size(125, 34);
            studentToolStripMenuItem.Text = "STUDENTS";
            // 
            // createNewStudentToolStripMenuItem
            // 
            createNewStudentToolStripMenuItem.BackColor = Color.DarkSalmon;
            createNewStudentToolStripMenuItem.ForeColor = SystemColors.ControlText;
            createNewStudentToolStripMenuItem.Name = "createNewStudentToolStripMenuItem";
            createNewStudentToolStripMenuItem.Size = new Size(295, 34);
            createNewStudentToolStripMenuItem.Text = "Create New Student";
            createNewStudentToolStripMenuItem.Click += createNewStudentToolStripMenuItem_Click;
            // 
            // updateStudentToolStripMenuItem
            // 
            updateStudentToolStripMenuItem.BackColor = Color.DarkSalmon;
            updateStudentToolStripMenuItem.ForeColor = SystemColors.ControlText;
            updateStudentToolStripMenuItem.Name = "updateStudentToolStripMenuItem";
            updateStudentToolStripMenuItem.Size = new Size(295, 34);
            updateStudentToolStripMenuItem.Text = "Update/delete Student";
            updateStudentToolStripMenuItem.Click += updateStudentToolStripMenuItem_Click;
            // 
            // studentListToolStripMenuItem
            // 
            studentListToolStripMenuItem.BackColor = Color.DarkSalmon;
            studentListToolStripMenuItem.ForeColor = SystemColors.ControlText;
            studentListToolStripMenuItem.Name = "studentListToolStripMenuItem";
            studentListToolStripMenuItem.Size = new Size(295, 34);
            studentListToolStripMenuItem.Text = "Student list";
            studentListToolStripMenuItem.Click += studentListToolStripMenuItem_Click;
            // 
            // manageFormToolStripMenuItem
            // 
            manageFormToolStripMenuItem.BackColor = Color.DarkSalmon;
            manageFormToolStripMenuItem.ForeColor = SystemColors.ControlText;
            manageFormToolStripMenuItem.Name = "manageFormToolStripMenuItem";
            manageFormToolStripMenuItem.Size = new Size(295, 34);
            manageFormToolStripMenuItem.Text = "Manage Form";
            manageFormToolStripMenuItem.Click += manageFormToolStripMenuItem_Click;
            // 
            // printTheStudentFormToolStripMenuItem
            // 
            printTheStudentFormToolStripMenuItem.BackColor = Color.DarkSalmon;
            printTheStudentFormToolStripMenuItem.ForeColor = SystemColors.ControlText;
            printTheStudentFormToolStripMenuItem.Name = "printTheStudentFormToolStripMenuItem";
            printTheStudentFormToolStripMenuItem.Size = new Size(295, 34);
            printTheStudentFormToolStripMenuItem.Text = "Print the student form";
            printTheStudentFormToolStripMenuItem.Click += printTheStudentFormToolStripMenuItem_Click;
            // 
            // subjectToolStripMenuItem
            // 
            subjectToolStripMenuItem.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            subjectToolStripMenuItem.Name = "subjectToolStripMenuItem";
            subjectToolStripMenuItem.Size = new Size(116, 34);
            subjectToolStripMenuItem.Text = "SUBJECTS";
            // 
            // groupsToolStripMenuItem
            // 
            groupsToolStripMenuItem.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupsToolStripMenuItem.Name = "groupsToolStripMenuItem";
            groupsToolStripMenuItem.Size = new Size(105, 34);
            groupsToolStripMenuItem.Text = "GROUPS";
            // 
            // gradesToolStripMenuItem
            // 
            gradesToolStripMenuItem.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gradesToolStripMenuItem.Name = "gradesToolStripMenuItem";
            gradesToolStripMenuItem.Size = new Size(103, 34);
            gradesToolStripMenuItem.Text = "GRADES";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 471);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "MainForm";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem studentToolStripMenuItem;
        private ToolStripMenuItem subjectToolStripMenuItem;
        private ToolStripMenuItem groupsToolStripMenuItem;
        private ToolStripMenuItem gradesToolStripMenuItem;
        private ToolStripMenuItem createNewStudentToolStripMenuItem;
        private ToolStripMenuItem updateStudentToolStripMenuItem;
        private ToolStripMenuItem studentListToolStripMenuItem;
        private ToolStripMenuItem manageFormToolStripMenuItem;
        private ToolStripMenuItem printTheStudentFormToolStripMenuItem;

        private void createNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Your code for creating new student goes here
           CreateNewStudentForm createForm = new CreateNewStudentForm();
              createForm.Show(this);
        }

        private void updateStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Your code for updating/deleting student goes here
            MessageBox.Show("Update/Delete Student clicked!");
        }

        private void studentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Your code for student list goes here
            MessageBox.Show("Student List clicked!");
        }

        private void manageFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Your code for managing form goes here
            MessageBox.Show("Manage Form clicked!");
        }

        private void printTheStudentFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Your code for printing student form goes here
            MessageBox.Show("Print Student Form clicked!");
        }
    }
}