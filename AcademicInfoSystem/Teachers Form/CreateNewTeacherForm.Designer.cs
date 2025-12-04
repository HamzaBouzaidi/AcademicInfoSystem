namespace AcademicInfoSystem.Teachers_Form
{
    partial class CreateNewTeacherForm
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
            labelTeacherId = new Label();
            labelUserId = new Label();
            textBoxFirstName = new TextBox();
            textBoxLastName = new TextBox();
            buttonCancelTeacher = new Button();
            buttonAddTeacher = new Button();
            SuspendLayout();
            // 
            // labelTeacherId
            // 
            labelTeacherId.AutoSize = true;
            labelTeacherId.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTeacherId.Location = new Point(68, 93);
            labelTeacherId.Name = "labelTeacherId";
            labelTeacherId.Size = new Size(167, 29);
            labelTeacherId.TabIndex = 0;
            labelTeacherId.Text = " First name :";
            // 
            // labelUserId
            // 
            labelUserId.AutoSize = true;
            labelUserId.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUserId.Location = new Point(68, 197);
            labelUserId.Name = "labelUserId";
            labelUserId.Size = new Size(152, 29);
            labelUserId.TabIndex = 1;
            labelUserId.Text = "Last Name:";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxFirstName.Location = new Point(313, 87);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(129, 35);
            textBoxFirstName.TabIndex = 2;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxLastName.Location = new Point(313, 197);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(129, 35);
            textBoxLastName.TabIndex = 3;
            // 
            // buttonCancelTeacher
            // 
            buttonCancelTeacher.BackColor = Color.Red;
            buttonCancelTeacher.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCancelTeacher.Location = new Point(107, 314);
            buttonCancelTeacher.Name = "buttonCancelTeacher";
            buttonCancelTeacher.Size = new Size(112, 46);
            buttonCancelTeacher.TabIndex = 9;
            buttonCancelTeacher.Text = "Cancel";
            buttonCancelTeacher.UseVisualStyleBackColor = false;
            buttonCancelTeacher.Click += buttonCancelTeacher_Click;
            // 
            // buttonAddTeacher
            // 
            buttonAddTeacher.BackColor = SystemColors.GradientInactiveCaption;
            buttonAddTeacher.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAddTeacher.Location = new Point(248, 314);
            buttonAddTeacher.Name = "buttonAddTeacher";
            buttonAddTeacher.Size = new Size(112, 46);
            buttonAddTeacher.TabIndex = 8;
            buttonAddTeacher.Text = "Add";
            buttonAddTeacher.UseVisualStyleBackColor = false;
            buttonAddTeacher.Click += buttonAddTeacher_Click;
            // 
            // CreateNewTeacherForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(500, 534);
            Controls.Add(buttonCancelTeacher);
            Controls.Add(buttonAddTeacher);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxFirstName);
            Controls.Add(labelUserId);
            Controls.Add(labelTeacherId);
            Name = "CreateNewTeacherForm";
            Text = "CreateNewTeacherForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTeacherId;
        private Label labelUserId;
        private TextBox textBoxFirstName;
        private TextBox textBoxLastName;
        private Button buttonCancelTeacher;
        private Button buttonAddTeacher;
    }
}