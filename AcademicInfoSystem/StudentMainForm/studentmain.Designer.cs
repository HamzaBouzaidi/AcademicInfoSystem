namespace AcademicInfoSystem.StudentMainForm
{
    partial class studentmain
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
            gradesToolStripMenuItem = new ToolStripMenuItem();
            viewYourGradesToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { gradesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1297, 37);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // gradesToolStripMenuItem
            // 
            gradesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewYourGradesToolStripMenuItem, logOutToolStripMenuItem });
            gradesToolStripMenuItem.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gradesToolStripMenuItem.Name = "gradesToolStripMenuItem";
            gradesToolStripMenuItem.Size = new Size(112, 33);
            gradesToolStripMenuItem.Text = "Grades";
            // 
            // viewYourGradesToolStripMenuItem
            // 
            viewYourGradesToolStripMenuItem.BackColor = Color.DarkSalmon;
            viewYourGradesToolStripMenuItem.Name = "viewYourGradesToolStripMenuItem";
            viewYourGradesToolStripMenuItem.Size = new Size(308, 34);
            viewYourGradesToolStripMenuItem.Text = "View Your Grades";
            viewYourGradesToolStripMenuItem.Click += viewYourGradesToolStripMenuItem_Click;
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.BackColor = Color.DarkSalmon;
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(308, 34);
            logOutToolStripMenuItem.Text = "Log out";
            logOutToolStripMenuItem.Click += logOutToolStripMenuItem_Click;
            // 
            // studentmain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1297, 315);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "studentmain";
            Text = "studentmain";
            WindowState = FormWindowState.Maximized;
            Load += studentmain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem gradesToolStripMenuItem;
        private ToolStripMenuItem viewYourGradesToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;


        private void viewYourGradesToolStripMenuItem_Click(object sender, EventArgs e)
        {
             ViewGradesForm viewGradesForm = new ViewGradesForm();
            viewGradesForm.Show();
        }


        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Event handler code here
            this.Close();
        }

    }
}