namespace AcademicInfoSystem.StudentMainForm
{
    partial class ViewGradesForm
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
            textBoxStudentId = new TextBox();
            textBoxSubjectId = new TextBox();
            buttonEnter = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 116);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(204, 29);
            label1.TabIndex = 0;
            label1.Text = "Enter your ID : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 222);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(310, 29);
            label2.TabIndex = 1;
            label2.Text = "Enter your  Subject ID : ";
            // 
            // textBoxStudentId
            // 
            textBoxStudentId.Location = new Point(416, 110);
            textBoxStudentId.Margin = new Padding(6);
            textBoxStudentId.Name = "textBoxStudentId";
            textBoxStudentId.Size = new Size(196, 35);
            textBoxStudentId.TabIndex = 2;
            // 
            // textBoxSubjectId
            // 
            textBoxSubjectId.Location = new Point(416, 216);
            textBoxSubjectId.Margin = new Padding(6);
            textBoxSubjectId.Name = "textBoxSubjectId";
            textBoxSubjectId.Size = new Size(196, 35);
            textBoxSubjectId.TabIndex = 3;
            // 
            // buttonEnter
            // 
            buttonEnter.BackColor = SystemColors.ActiveCaption;
            buttonEnter.Location = new Point(370, 373);
            buttonEnter.Name = "buttonEnter";
            buttonEnter.Size = new Size(148, 64);
            buttonEnter.TabIndex = 4;
            buttonEnter.Text = "Enter";
            buttonEnter.UseVisualStyleBackColor = false;
            buttonEnter.Click += buttonEnter_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Location = new Point(177, 373);
            button2.Name = "button2";
            button2.Size = new Size(148, 64);
            button2.TabIndex = 5;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // ViewGradesForm
            // 
            AutoScaleDimensions = new SizeF(14F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(733, 640);
            Controls.Add(button2);
            Controls.Add(buttonEnter);
            Controls.Add(textBoxSubjectId);
            Controls.Add(textBoxStudentId);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "ViewGradesForm";
            Text = "ViewGradesForm";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxStudentId;
        private TextBox textBoxSubjectId;
        private Button buttonEnter;
        private Button button2;
    }
}