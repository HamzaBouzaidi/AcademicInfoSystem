namespace AcademicInfoSystem
{
    partial class updateStudentForm
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
            textBoxStudentId = new TextBox();
            label1 = new Label();
            textBoxFirstName = new TextBox();
            label2 = new Label();
            textBoxLastName = new TextBox();
            label3 = new Label();
            textBoxStudentGroup = new TextBox();
            label4 = new Label();
            textBoxGroupId = new TextBox();
            label5 = new Label();
            buttonRemove = new Button();
            buttonEditStudent = new Button();
            buttonFind = new Button();
            SuspendLayout();
            // 
            // textBoxStudentId
            // 
            textBoxStudentId.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxStudentId.Location = new Point(199, 60);
            textBoxStudentId.Name = "textBoxStudentId";
            textBoxStudentId.Size = new Size(128, 35);
            textBoxStudentId.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 66);
            label1.Name = "label1";
            label1.Size = new Size(171, 29);
            label1.TabIndex = 3;
            label1.Text = "Student ID : ";
            label1.UseMnemonic = false;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxFirstName.Location = new Point(199, 164);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(227, 35);
            textBoxFirstName.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 164);
            label2.Name = "label2";
            label2.Size = new Size(170, 29);
            label2.TabIndex = 5;
            label2.Text = "First Name : ";
            label2.UseMnemonic = false;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxLastName.Location = new Point(199, 259);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(227, 35);
            textBoxLastName.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 259);
            label3.Name = "label3";
            label3.Size = new Size(164, 29);
            label3.TabIndex = 7;
            label3.Text = "Last Name : ";
            label3.UseMnemonic = false;
            // 
            // textBoxStudentGroup
            // 
            textBoxStudentGroup.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxStudentGroup.Location = new Point(730, 66);
            textBoxStudentGroup.Name = "textBoxStudentGroup";
            textBoxStudentGroup.Size = new Size(227, 35);
            textBoxStudentGroup.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(495, 66);
            label4.Name = "label4";
            label4.Size = new Size(219, 29);
            label4.TabIndex = 9;
            label4.Text = "Student Group : ";
            label4.UseMnemonic = false;
            // 
            // textBoxGroupId
            // 
            textBoxGroupId.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxGroupId.Location = new Point(730, 158);
            textBoxGroupId.Name = "textBoxGroupId";
            textBoxGroupId.Size = new Size(227, 35);
            textBoxGroupId.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(495, 148);
            label5.Name = "label5";
            label5.Size = new Size(140, 29);
            label5.TabIndex = 11;
            label5.Text = "Group Id: ";
            label5.UseMnemonic = false;
            // 
            // buttonRemove
            // 
            buttonRemove.BackColor = Color.Red;
            buttonRemove.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonRemove.Location = new Point(435, 577);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(168, 62);
            buttonRemove.TabIndex = 14;
            buttonRemove.Text = "Remove";
            buttonRemove.UseVisualStyleBackColor = false;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // buttonEditStudent
            // 
            buttonEditStudent.BackColor = SystemColors.GradientInactiveCaption;
            buttonEditStudent.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonEditStudent.Location = new Point(638, 577);
            buttonEditStudent.Name = "buttonEditStudent";
            buttonEditStudent.Size = new Size(166, 62);
            buttonEditStudent.TabIndex = 13;
            buttonEditStudent.Text = "Edit";
            buttonEditStudent.UseVisualStyleBackColor = false;
            buttonEditStudent.Click += buttonEditStudent_Click;
            // 
            // buttonFind
            // 
            buttonFind.BackColor = Color.Lime;
            buttonFind.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonFind.Location = new Point(336, 60);
            buttonFind.Name = "buttonFind";
            buttonFind.Size = new Size(90, 35);
            buttonFind.TabIndex = 15;
            buttonFind.Text = "Find";
            buttonFind.UseVisualStyleBackColor = false;
            buttonFind.Click += buttonFind_Click;
            // 
            // UpdateDeleteStudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1096, 716);
            Controls.Add(buttonFind);
            Controls.Add(buttonRemove);
            Controls.Add(buttonEditStudent);
            Controls.Add(textBoxGroupId);
            Controls.Add(label5);
            Controls.Add(textBoxStudentGroup);
            Controls.Add(label4);
            Controls.Add(textBoxLastName);
            Controls.Add(label3);
            Controls.Add(textBoxFirstName);
            Controls.Add(label2);
            Controls.Add(textBoxStudentId);
            Controls.Add(label1);
            Name = "UpdateDeleteStudentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateDeleteStudentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button buttonRemove;
        private Button buttonEditStudent;
        private Button buttonFind;
        internal TextBox textBoxStudentId;
        internal TextBox textBoxFirstName;
        internal TextBox textBoxLastName;
        internal TextBox textBoxStudentGroup;
        internal TextBox textBoxGroupId;
    }
}