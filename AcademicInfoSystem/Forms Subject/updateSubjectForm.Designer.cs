namespace AcademicInfoSystem.Forms_Subject
{
    partial class updateSubjectForm
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
            SubjectId = new Label();
            buttonFind = new Button();
            SubjectName = new Label();
            textBoxSubjectName = new TextBox();
            label1 = new Label();
            textBoxTeacherId = new TextBox();
            buttonRemoveSubject = new Button();
            buttonEditSubject = new Button();
            textBoxSubjectId = new TextBox();
            SuspendLayout();
            // 
            // SubjectId
            // 
            SubjectId.AutoSize = true;
            SubjectId.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SubjectId.Location = new Point(44, 64);
            SubjectId.Name = "SubjectId";
            SubjectId.Size = new Size(159, 29);
            SubjectId.TabIndex = 0;
            SubjectId.Text = "Subject ID :";
            // 
            // buttonFind
            // 
            buttonFind.BackColor = Color.Lime;
            buttonFind.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonFind.Location = new Point(447, 64);
            buttonFind.Name = "buttonFind";
            buttonFind.Size = new Size(90, 35);
            buttonFind.TabIndex = 16;
            buttonFind.Text = "Find";
            buttonFind.UseVisualStyleBackColor = false;
            buttonFind.Click += buttonFind_Click;
            // 
            // SubjectName
            // 
            SubjectName.AutoSize = true;
            SubjectName.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SubjectName.Location = new Point(44, 158);
            SubjectName.Name = "SubjectName";
            SubjectName.Size = new Size(100, 29);
            SubjectName.TabIndex = 17;
            SubjectName.Text = "Name :";
            // 
            // textBoxSubjectName
            // 
            textBoxSubjectName.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSubjectName.Location = new Point(261, 158);
            textBoxSubjectName.Name = "textBoxSubjectName";
            textBoxSubjectName.Size = new Size(163, 35);
            textBoxSubjectName.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(44, 258);
            label1.Name = "label1";
            label1.Size = new Size(164, 29);
            label1.TabIndex = 19;
            label1.Text = "Teacher ID :";
            // 
            // textBoxTeacherId
            // 
            textBoxTeacherId.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxTeacherId.Location = new Point(261, 258);
            textBoxTeacherId.Name = "textBoxTeacherId";
            textBoxTeacherId.Size = new Size(163, 35);
            textBoxTeacherId.TabIndex = 20;
            // 
            // buttonRemoveSubject
            // 
            buttonRemoveSubject.BackColor = Color.Red;
            buttonRemoveSubject.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonRemoveSubject.Location = new Point(55, 429);
            buttonRemoveSubject.Name = "buttonRemoveSubject";
            buttonRemoveSubject.Size = new Size(168, 62);
            buttonRemoveSubject.TabIndex = 22;
            buttonRemoveSubject.Text = "Remove";
            buttonRemoveSubject.UseVisualStyleBackColor = false;
            buttonRemoveSubject.Click += buttonRemoveSubject_Click;
            // 
            // buttonEditSubject
            // 
            buttonEditSubject.BackColor = SystemColors.GradientInactiveCaption;
            buttonEditSubject.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonEditSubject.Location = new Point(258, 429);
            buttonEditSubject.Name = "buttonEditSubject";
            buttonEditSubject.Size = new Size(166, 62);
            buttonEditSubject.TabIndex = 21;
            buttonEditSubject.Text = "Edit";
            buttonEditSubject.UseVisualStyleBackColor = false;
            buttonEditSubject.Click += buttonEditSubject_Click;
            // 
            // textBoxSubjectId
            // 
            textBoxSubjectId.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSubjectId.Location = new Point(261, 61);
            textBoxSubjectId.Name = "textBoxSubjectId";
            textBoxSubjectId.Size = new Size(163, 35);
            textBoxSubjectId.TabIndex = 23;
            // 
            // updateSubjectForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(588, 590);
            Controls.Add(textBoxSubjectId);
            Controls.Add(buttonRemoveSubject);
            Controls.Add(buttonEditSubject);
            Controls.Add(textBoxTeacherId);
            Controls.Add(label1);
            Controls.Add(textBoxSubjectName);
            Controls.Add(SubjectName);
            Controls.Add(buttonFind);
            Controls.Add(SubjectId);
            Name = "updateSubjectForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateDeleteForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SubjectId;
        private Label SubjectName;
        private Label label1;
        internal Button buttonFind;
        internal TextBox textBoxSubjectName;
        internal TextBox textBoxTeacherId;
        internal Button buttonRemoveSubject;
        internal Button buttonEditSubject;
        internal TextBox textBoxSubjectId;
       

    }

    
}

