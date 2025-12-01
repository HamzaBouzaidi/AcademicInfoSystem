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
            textBoxTeacherId = new TextBox();
            textBoxUserId = new TextBox();
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
            labelTeacherId.Size = new Size(164, 29);
            labelTeacherId.TabIndex = 0;
            labelTeacherId.Text = "Teacher ID :";
            // 
            // labelUserId
            // 
            labelUserId.AutoSize = true;
            labelUserId.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUserId.Location = new Point(68, 197);
            labelUserId.Name = "labelUserId";
            labelUserId.Size = new Size(123, 29);
            labelUserId.TabIndex = 1;
            labelUserId.Text = "User ID :";
            // 
            // textBoxTeacherId
            // 
            textBoxTeacherId.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxTeacherId.Location = new Point(313, 87);
            textBoxTeacherId.Name = "textBoxTeacherId";
            textBoxTeacherId.Size = new Size(129, 35);
            textBoxTeacherId.TabIndex = 2;
            // 
            // textBoxUserId
            // 
            textBoxUserId.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxUserId.Location = new Point(313, 197);
            textBoxUserId.Name = "textBoxUserId";
            textBoxUserId.Size = new Size(129, 35);
            textBoxUserId.TabIndex = 3;
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
            Controls.Add(textBoxUserId);
            Controls.Add(textBoxTeacherId);
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
        private TextBox textBoxTeacherId;
        private TextBox textBoxUserId;
        private Button buttonCancelTeacher;
        private Button buttonAddTeacher;
    }
}