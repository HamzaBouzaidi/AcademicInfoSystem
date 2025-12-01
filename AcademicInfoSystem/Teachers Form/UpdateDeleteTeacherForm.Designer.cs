namespace AcademicInfoSystem.Teachers_Form
{
    partial class UpdateDeleteTeacherForm
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
            textBoxTeacherId = new TextBox();
            textBoxUserId = new TextBox();
            buttonFindTeacherId = new Button();
            buttonRemoveTeacher = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(49, 70);
            label1.Name = "label1";
            label1.Size = new Size(164, 29);
            label1.TabIndex = 0;
            label1.Text = "Teacher ID :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(49, 201);
            label2.Name = "label2";
            label2.Size = new Size(123, 29);
            label2.TabIndex = 1;
            label2.Text = "User ID :";
            // 
            // textBoxTeacherId
            // 
            textBoxTeacherId.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxTeacherId.Location = new Point(246, 64);
            textBoxTeacherId.Name = "textBoxTeacherId";
            textBoxTeacherId.Size = new Size(85, 35);
            textBoxTeacherId.TabIndex = 2;
            // 
            // textBoxUserId
            // 
            textBoxUserId.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxUserId.Location = new Point(246, 195);
            textBoxUserId.Name = "textBoxUserId";
            textBoxUserId.Size = new Size(85, 35);
            textBoxUserId.TabIndex = 3;
            // 
            // buttonFindTeacherId
            // 
            buttonFindTeacherId.BackColor = Color.Lime;
            buttonFindTeacherId.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonFindTeacherId.Location = new Point(354, 64);
            buttonFindTeacherId.Name = "buttonFindTeacherId";
            buttonFindTeacherId.Size = new Size(90, 35);
            buttonFindTeacherId.TabIndex = 17;
            buttonFindTeacherId.Text = "Find";
            buttonFindTeacherId.UseVisualStyleBackColor = false;
            buttonFindTeacherId.Click += buttonFindTeacherId_Click;
            // 
            // buttonRemoveTeacher
            // 
            buttonRemoveTeacher.BackColor = Color.Red;
            buttonRemoveTeacher.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonRemoveTeacher.Location = new Point(172, 325);
            buttonRemoveTeacher.Name = "buttonRemoveTeacher";
            buttonRemoveTeacher.Size = new Size(168, 62);
            buttonRemoveTeacher.TabIndex = 23;
            buttonRemoveTeacher.Text = "Remove";
            buttonRemoveTeacher.UseVisualStyleBackColor = false;
            buttonRemoveTeacher.Click += this.buttonRemoveTeacher_Click;
            // 
            // UpdateDeleteTeacherForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(516, 517);
            Controls.Add(buttonRemoveTeacher);
            Controls.Add(buttonFindTeacherId);
            Controls.Add(textBoxUserId);
            Controls.Add(textBoxTeacherId);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UpdateDeleteTeacherForm";
            Text = "UpdateDeleteForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxTeacherId;
        private TextBox textBoxUserId;
        internal Button buttonFindTeacherId;
        internal Button buttonRemoveTeacher;
    }
}