namespace AcademicInfoSystem
{
    partial class CreateNewStudentForm
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
            label1 = new Label();
            label2 = new Label();
            textBoxFname = new TextBox();
            textBoxLname = new TextBox();
            buttonAddStudent = new Button();
            buttonCancel = new Button();
            label3 = new Label();
            textBoxStudentGroup = new TextBox();
            label4 = new Label();
            textBoxGroupId = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 47);
            label1.Name = "label1";
            label1.Size = new Size(170, 29);
            label1.TabIndex = 0;
            label1.Text = "First Name : ";
            label1.UseMnemonic = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 121);
            label2.Name = "label2";
            label2.Size = new Size(164, 29);
            label2.TabIndex = 1;
            label2.Text = "Last Name : ";
            label2.UseMnemonic = false;
            // 
            // textBoxFname
            // 
            textBoxFname.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxFname.Location = new Point(297, 47);
            textBoxFname.Name = "textBoxFname";
            textBoxFname.Size = new Size(227, 35);
            textBoxFname.TabIndex = 2;
            // 
            // textBoxLname
            // 
            textBoxLname.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxLname.Location = new Point(297, 121);
            textBoxLname.Name = "textBoxLname";
            textBoxLname.Size = new Size(227, 35);
            textBoxLname.TabIndex = 3;
            // 
            // buttonAddStudent
            // 
            buttonAddStudent.BackColor = SystemColors.GradientInactiveCaption;
            buttonAddStudent.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAddStudent.Location = new Point(297, 435);
            buttonAddStudent.Name = "buttonAddStudent";
            buttonAddStudent.Size = new Size(112, 46);
            buttonAddStudent.TabIndex = 4;
            buttonAddStudent.Text = "Add";
            buttonAddStudent.UseVisualStyleBackColor = false;
            buttonAddStudent.Click += buttonAddStudent_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.Red;
            buttonCancel.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCancel.Location = new Point(156, 435);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(112, 46);
            buttonCancel.TabIndex = 5;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 213);
            label3.Name = "label3";
            label3.Size = new Size(213, 29);
            label3.TabIndex = 6;
            label3.Text = "Student Group: ";
            label3.UseMnemonic = false;
            // 
            // textBoxStudentGroup
            // 
            textBoxStudentGroup.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxStudentGroup.Location = new Point(297, 213);
            textBoxStudentGroup.Name = "textBoxStudentGroup";
            textBoxStudentGroup.Size = new Size(227, 35);
            textBoxStudentGroup.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 296);
            label4.Name = "label4";
            label4.Size = new Size(134, 29);
            label4.TabIndex = 8;
            label4.Text = "Group Id:";
            label4.UseMnemonic = false;
            // 
            // textBoxGroupId
            // 
            textBoxGroupId.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxGroupId.Location = new Point(297, 307);
            textBoxGroupId.Name = "textBoxGroupId";
            textBoxGroupId.Size = new Size(227, 35);
            textBoxGroupId.TabIndex = 9;
            // 
            // CreateNewStudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(573, 587);
            Controls.Add(textBoxGroupId);
            Controls.Add(label4);
            Controls.Add(textBoxStudentGroup);
            Controls.Add(label3);
            Controls.Add(buttonCancel);
            Controls.Add(buttonAddStudent);
            Controls.Add(textBoxLname);
            Controls.Add(textBoxFname);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CreateNewStudentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateNewStudentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxFname;
        private TextBox textBoxLname;
        private Button buttonAddStudent;
        private Button buttonCancel;
        private Label label3;
        private TextBox textBoxStudentGroup;
        private Label label4;
        private TextBox textBoxGroupId;
    }
}