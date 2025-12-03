namespace AcademicInfoSystem.teachermainform
{
    partial class EditDeleteGradeForm
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
            buttonRemoveGrade = new Button();
            buttonEditGrade = new Button();
            textBoxComment = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            textBoxValue = new TextBox();
            textBoxSubjectId = new TextBox();
            textBoxStudentId = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            buttonFindGrade = new Button();
            SuspendLayout();
            // 
            // buttonRemoveGrade
            // 
            buttonRemoveGrade.BackColor = Color.Red;
            buttonRemoveGrade.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonRemoveGrade.Location = new Point(172, 640);
            buttonRemoveGrade.Name = "buttonRemoveGrade";
            buttonRemoveGrade.Size = new Size(112, 46);
            buttonRemoveGrade.TabIndex = 23;
            buttonRemoveGrade.Text = "Remove";
            buttonRemoveGrade.UseVisualStyleBackColor = false;
            buttonRemoveGrade.Click += buttonRemoveGrade_Click;
            // 
            // buttonEditGrade
            // 
            buttonEditGrade.BackColor = SystemColors.GradientInactiveCaption;
            buttonEditGrade.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonEditGrade.Location = new Point(313, 640);
            buttonEditGrade.Name = "buttonEditGrade";
            buttonEditGrade.Size = new Size(112, 46);
            buttonEditGrade.TabIndex = 22;
            buttonEditGrade.Text = "Edit";
            buttonEditGrade.UseVisualStyleBackColor = false;
            buttonEditGrade.Click += buttonEditGrade_Click;
            // 
            // textBoxComment
            // 
            textBoxComment.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxComment.Location = new Point(361, 497);
            textBoxComment.Name = "textBoxComment";
            textBoxComment.Size = new Size(146, 35);
            textBoxComment.TabIndex = 21;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(361, 371);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(228, 21);
            dateTimePicker1.TabIndex = 20;
            // 
            // textBoxValue
            // 
            textBoxValue.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxValue.Location = new Point(361, 251);
            textBoxValue.Name = "textBoxValue";
            textBoxValue.Size = new Size(146, 35);
            textBoxValue.TabIndex = 19;
            // 
            // textBoxSubjectId
            // 
            textBoxSubjectId.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSubjectId.Location = new Point(361, 142);
            textBoxSubjectId.Name = "textBoxSubjectId";
            textBoxSubjectId.Size = new Size(146, 35);
            textBoxSubjectId.TabIndex = 18;
            // 
            // textBoxStudentId
            // 
            textBoxStudentId.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxStudentId.Location = new Point(361, 47);
            textBoxStudentId.Name = "textBoxStudentId";
            textBoxStudentId.Size = new Size(146, 35);
            textBoxStudentId.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(91, 497);
            label5.Name = "label5";
            label5.Size = new Size(149, 29);
            label5.TabIndex = 16;
            label5.Text = "Comment :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(91, 365);
            label4.Name = "label4";
            label4.Size = new Size(86, 29);
            label4.TabIndex = 15;
            label4.Text = "Date :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(91, 257);
            label3.Name = "label3";
            label3.Size = new Size(99, 29);
            label3.TabIndex = 14;
            label3.Text = "Value :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(91, 145);
            label2.Name = "label2";
            label2.Size = new Size(153, 29);
            label2.TabIndex = 13;
            label2.Text = "Subject ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(91, 53);
            label1.Name = "label1";
            label1.Size = new Size(165, 29);
            label1.TabIndex = 12;
            label1.Text = "Student ID :";
            // 
            // buttonFindGrade
            // 
            buttonFindGrade.BackColor = Color.Lime;
            buttonFindGrade.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonFindGrade.Location = new Point(534, 41);
            buttonFindGrade.Name = "buttonFindGrade";
            buttonFindGrade.Size = new Size(112, 46);
            buttonFindGrade.TabIndex = 24;
            buttonFindGrade.Text = "Find";
            buttonFindGrade.UseVisualStyleBackColor = false;
            buttonFindGrade.Click += buttonFindGrade_Click;
            // 
            // EditDeleteGradeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(681, 733);
            Controls.Add(buttonFindGrade);
            Controls.Add(buttonRemoveGrade);
            Controls.Add(buttonEditGrade);
            Controls.Add(textBoxComment);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBoxValue);
            Controls.Add(textBoxSubjectId);
            Controls.Add(textBoxStudentId);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EditDeleteGradeForm";
            Text = "EditDeleteGradeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal Button buttonRemoveGrade;
        internal Button buttonEditGrade;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        internal Button buttonFindGrade;
        internal TextBox textBoxStudentId;
        internal TextBox textBoxComment;
        internal DateTimePicker dateTimePicker1;
        internal TextBox textBoxValue;
        internal TextBox textBoxSubjectId;
    }
}