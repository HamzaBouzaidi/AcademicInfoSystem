namespace AcademicInfoSystem.Forms_Group
{
    partial class CreateNewGroupForm
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
            GroupId = new Label();
            GroupName = new Label();
            textBoxGroupId = new TextBox();
            textBoxGroupName = new TextBox();
            buttonCancel = new Button();
            buttonAddGroup = new Button();
            SuspendLayout();
            // 
            // GroupId
            // 
            GroupId.AutoSize = true;
            GroupId.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GroupId.Location = new Point(60, 50);
            GroupId.Margin = new Padding(4, 0, 4, 0);
            GroupId.Name = "GroupId";
            GroupId.Size = new Size(144, 29);
            GroupId.TabIndex = 0;
            GroupId.Text = "Group ID :";
            // 
            // GroupName
            // 
            GroupName.AutoSize = true;
            GroupName.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GroupName.Location = new Point(60, 141);
            GroupName.Margin = new Padding(4, 0, 4, 0);
            GroupName.Name = "GroupName";
            GroupName.Size = new Size(185, 29);
            GroupName.TabIndex = 1;
            GroupName.Text = "Group Name :";
            // 
            // textBoxGroupId
            // 
            textBoxGroupId.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxGroupId.Location = new Point(318, 47);
            textBoxGroupId.Name = "textBoxGroupId";
            textBoxGroupId.Size = new Size(178, 35);
            textBoxGroupId.TabIndex = 2;
            // 
            // textBoxGroupName
            // 
            textBoxGroupName.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxGroupName.Location = new Point(318, 138);
            textBoxGroupName.Name = "textBoxGroupName";
            textBoxGroupName.Size = new Size(178, 35);
            textBoxGroupName.TabIndex = 3;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.Red;
            buttonCancel.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCancel.Location = new Point(177, 288);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(112, 46);
            buttonCancel.TabIndex = 7;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonAddGroup
            // 
            buttonAddGroup.BackColor = SystemColors.GradientInactiveCaption;
            buttonAddGroup.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAddGroup.Location = new Point(318, 288);
            buttonAddGroup.Name = "buttonAddGroup";
            buttonAddGroup.Size = new Size(112, 46);
            buttonAddGroup.TabIndex = 6;
            buttonAddGroup.Text = "Add";
            buttonAddGroup.UseVisualStyleBackColor = false;
            buttonAddGroup.Click += buttonAddGroup_Click;
            // 
            // CreateNewGroupForm
            // 
            AutoScaleDimensions = new SizeF(9F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(545, 574);
            Controls.Add(buttonCancel);
            Controls.Add(buttonAddGroup);
            Controls.Add(textBoxGroupName);
            Controls.Add(textBoxGroupId);
            Controls.Add(GroupName);
            Controls.Add(GroupId);
            Font = new Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "CreateNewGroupForm";
            Text = "AddGroupForm";
            Load += CreateNewGroupForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label GroupId;
        private Label GroupName;
        internal TextBox textBoxGroupId;
        internal TextBox textBoxGroupName;
        internal Button buttonCancel;
        internal Button buttonAddGroup;
        public void CreateNewGroupForm_Load(object sender, EventArgs e)
        {

        }
    }
}