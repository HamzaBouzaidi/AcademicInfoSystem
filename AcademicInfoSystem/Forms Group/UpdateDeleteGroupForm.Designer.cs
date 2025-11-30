namespace AcademicInfoSystem.Forms_Group
{
    partial class UpdateDeleteGroupForm
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
            textBoxGroupId = new TextBox();
            textBoxGroupName = new TextBox();
            buttonFindGroup = new Button();
            buttonRemoveGroup = new Button();
            buttonEditGroup = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(55, 68);
            label1.Name = "label1";
            label1.Size = new Size(150, 29);
            label1.TabIndex = 0;
            label1.Text = "Group ID : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(55, 182);
            label2.Name = "label2";
            label2.Size = new Size(191, 29);
            label2.TabIndex = 1;
            label2.Text = "Group Name : ";
            // 
            // textBoxGroupId
            // 
            textBoxGroupId.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxGroupId.Location = new Point(317, 65);
            textBoxGroupId.Name = "textBoxGroupId";
            textBoxGroupId.Size = new Size(100, 35);
            textBoxGroupId.TabIndex = 2;
            // 
            // textBoxGroupName
            // 
            textBoxGroupName.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxGroupName.Location = new Point(317, 179);
            textBoxGroupName.Name = "textBoxGroupName";
            textBoxGroupName.Size = new Size(186, 35);
            textBoxGroupName.TabIndex = 3;
            // 
            // buttonFindGroup
            // 
            buttonFindGroup.BackColor = Color.Lime;
            buttonFindGroup.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonFindGroup.Location = new Point(436, 65);
            buttonFindGroup.Name = "buttonFindGroup";
            buttonFindGroup.Size = new Size(90, 35);
            buttonFindGroup.TabIndex = 16;
            buttonFindGroup.Text = "Find";
            buttonFindGroup.UseVisualStyleBackColor = false;
            buttonFindGroup.Click += buttonFindGroup_Click;
            // 
            // buttonRemoveGroup
            // 
            buttonRemoveGroup.BackColor = Color.Red;
            buttonRemoveGroup.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonRemoveGroup.Location = new Point(90, 359);
            buttonRemoveGroup.Name = "buttonRemoveGroup";
            buttonRemoveGroup.Size = new Size(168, 62);
            buttonRemoveGroup.TabIndex = 18;
            buttonRemoveGroup.Text = "Remove";
            buttonRemoveGroup.UseVisualStyleBackColor = false;
            buttonRemoveGroup.Click += buttonRemoveGroup_Click;
            // 
            // buttonEditGroup
            // 
            buttonEditGroup.BackColor = SystemColors.GradientInactiveCaption;
            buttonEditGroup.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonEditGroup.Location = new Point(293, 359);
            buttonEditGroup.Name = "buttonEditGroup";
            buttonEditGroup.Size = new Size(166, 62);
            buttonEditGroup.TabIndex = 17;
            buttonEditGroup.Text = "Edit";
            buttonEditGroup.UseVisualStyleBackColor = false;
            buttonEditGroup.Click += buttonEditGroup_Click;
            // 
            // UpdateDeleteGroupForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(593, 584);
            Controls.Add(buttonRemoveGroup);
            Controls.Add(buttonEditGroup);
            Controls.Add(buttonFindGroup);
            Controls.Add(textBoxGroupName);
            Controls.Add(textBoxGroupId);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UpdateDeleteGroupForm";
            Text = "UpdateDeleteGroup";
            Load += UpdateDeleteGroup_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxGroupId;
        private TextBox textBoxGroupName;
        private Button buttonFindGroup;
        private Button buttonEditGroup;
        internal Button buttonRemoveGroup;
    }
}