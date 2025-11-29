namespace AcademicInfoSystem.Forms_Subject
{
    partial class CreateSubjectForm
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
            textBoxSubjectName = new TextBox();
            textBoxTeacherId = new TextBox();
            buttonCancelSubject = new Button();
            buttonAddSubject = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 51);
            label1.Name = "label1";
            label1.Size = new Size(200, 29);
            label1.TabIndex = 0;
            label1.Text = "Subject Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(41, 116);
            label2.Name = "label2";
            label2.Size = new Size(164, 29);
            label2.TabIndex = 1;
            label2.Text = "Teacher ID :";
            // 
            // textBoxSubjectName
            // 
            textBoxSubjectName.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSubjectName.Location = new Point(267, 45);
            textBoxSubjectName.Name = "textBoxSubjectName";
            textBoxSubjectName.Size = new Size(203, 35);
            textBoxSubjectName.TabIndex = 2;
            // 
            // textBoxTeacherId
            // 
            textBoxTeacherId.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxTeacherId.Location = new Point(267, 116);
            textBoxTeacherId.Name = "textBoxTeacherId";
            textBoxTeacherId.Size = new Size(203, 35);
            textBoxTeacherId.TabIndex = 3;
            // 
            // buttonCancelSubject
            // 
            buttonCancelSubject.BackColor = Color.Red;
            buttonCancelSubject.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCancelSubject.Location = new Point(126, 229);
            buttonCancelSubject.Name = "buttonCancelSubject";
            buttonCancelSubject.Size = new Size(112, 46);
            buttonCancelSubject.TabIndex = 7;
            buttonCancelSubject.Text = "Cancel";
            buttonCancelSubject.UseVisualStyleBackColor = false;
            buttonCancelSubject.Click += buttonCancelSubject_Click;
            // 
            // buttonAddSubject
            // 
            buttonAddSubject.BackColor = SystemColors.GradientInactiveCaption;
            buttonAddSubject.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAddSubject.Location = new Point(267, 229);
            buttonAddSubject.Name = "buttonAddSubject";
            buttonAddSubject.Size = new Size(112, 46);
            buttonAddSubject.TabIndex = 6;
            buttonAddSubject.Text = "Add";
            buttonAddSubject.UseVisualStyleBackColor = false;
            buttonAddSubject.Click += buttonAddSubject_Click;
            // 
            // CreateSubjectForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(584, 487);
            Controls.Add(buttonCancelSubject);
            Controls.Add(buttonAddSubject);
            Controls.Add(textBoxTeacherId);
            Controls.Add(textBoxSubjectName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CreateSubjectForm";
            Text = "AddSubjectForm";
            Load += this.CreateSubjectForm_Load;

            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Button buttonCancelSubject;
        private Button buttonAddSubject;
        internal TextBox textBoxSubjectName;
        internal TextBox textBoxTeacherId;


        private void CreateSubjectForm_Load(object sender, EventArgs e)
        {

        }
    }
}
