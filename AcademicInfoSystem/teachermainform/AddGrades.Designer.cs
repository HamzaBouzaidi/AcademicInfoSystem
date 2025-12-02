using System;
using System.Windows.Forms;
using System.Drawing;

namespace AcademicInfoSystem.TeacherMainForm

{
    partial class AddGrades : Form
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBoxStudentId = new TextBox();
            textBoxSubjectId = new TextBox();
            textBoxValue = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            textBoxComment = new TextBox();
            buttonCancelGrade = new Button();
            buttonAddGrade = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(55, 63);
            label1.Name = "label1";
            label1.Size = new Size(165, 29);
            label1.TabIndex = 0;
            label1.Text = "Student ID :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(55, 155);
            label2.Name = "label2";
            label2.Size = new Size(153, 29);
            label2.TabIndex = 1;
            label2.Text = "Subject ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(55, 267);
            label3.Name = "label3";
            label3.Size = new Size(99, 29);
            label3.TabIndex = 2;
            label3.Text = "Value :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(55, 375);
            label4.Name = "label4";
            label4.Size = new Size(86, 29);
            label4.TabIndex = 3;
            label4.Text = "Date :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(55, 507);
            label5.Name = "label5";
            label5.Size = new Size(149, 29);
            label5.TabIndex = 4;
            label5.Text = "Comment :";
            // 
            // textBoxStudentId
            // 
            textBoxStudentId.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxStudentId.Location = new Point(325, 57);
            textBoxStudentId.Name = "textBoxStudentId";
            textBoxStudentId.Size = new Size(146, 35);
            textBoxStudentId.TabIndex = 5;
            // 
            // textBoxSubjectId
            // 
            textBoxSubjectId.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSubjectId.Location = new Point(325, 152);
            textBoxSubjectId.Name = "textBoxSubjectId";
            textBoxSubjectId.Size = new Size(146, 35);
            textBoxSubjectId.TabIndex = 6;
            // 
            // textBoxValue
            // 
            textBoxValue.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxValue.Location = new Point(325, 261);
            textBoxValue.Name = "textBoxValue";
            textBoxValue.Size = new Size(146, 35);
            textBoxValue.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(325, 381);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(228, 21);
            dateTimePicker1.TabIndex = 8;
            // 
            // textBoxComment
            // 
            textBoxComment.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxComment.Location = new Point(325, 507);
            textBoxComment.Name = "textBoxComment";
            textBoxComment.Size = new Size(146, 35);
            textBoxComment.TabIndex = 9;
            // 
            // buttonCancelGrade
            // 
            buttonCancelGrade.BackColor = Color.Red;
            buttonCancelGrade.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCancelGrade.Location = new Point(136, 650);
            buttonCancelGrade.Name = "buttonCancelGrade";
            buttonCancelGrade.Size = new Size(112, 46);
            buttonCancelGrade.TabIndex = 11;
            buttonCancelGrade.Text = "Cancel";
            buttonCancelGrade.UseVisualStyleBackColor = false;
           // buttonCancelGrade.Click += this.buttonCancelGrade_Click;
            // 
            // buttonAddGrade
            // 
            buttonAddGrade.BackColor = SystemColors.GradientInactiveCaption;
            buttonAddGrade.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAddGrade.Location = new Point(277, 650);
            buttonAddGrade.Name = "buttonAddGrade";
            buttonAddGrade.Size = new Size(112, 46);
            buttonAddGrade.TabIndex = 10;
            buttonAddGrade.Text = "Add";
            buttonAddGrade.UseVisualStyleBackColor = false;
            buttonAddGrade.Click += this.buttonAddGrade_Click;
            // 
            // AddGrades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(592, 791);
            Controls.Add(buttonCancelGrade);
            Controls.Add(buttonAddGrade);
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
            Name = "AddGrades";
            Text = "AddGrades";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBoxStudentId;
        private TextBox textBoxSubjectId;
        private TextBox textBoxValue;
        private DateTimePicker dateTimePicker1;
        private TextBox textBoxComment;
        internal Button buttonCancelGrade;
        internal Button buttonAddGrade;
    }
}