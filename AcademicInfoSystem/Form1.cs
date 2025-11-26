using System.Data;
using System.Reflection;
using AcademicInfoSystem.Database;
using MySql.Data.MySqlClient;

namespace AcademicInfoSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxFirsname = new TextBox();
            textBoxLastname = new TextBox();
            label4 = new Label();
            textBoxUsername = new TextBox();
            label5 = new Label();
            textBoxPassword = new TextBox();
            label6 = new Label();
            buttonLogin = new Button();
            buttonCancel = new Button();
            comboBoxRole = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(93, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(92, 78);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(191, 82);
            label1.Name = "label1";
            label1.Size = new Size(192, 29);
            label1.TabIndex = 1;
            label1.Text = "Account Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(47, 180);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(151, 29);
            label2.TabIndex = 2;
            label2.Text = "first Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(47, 253);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(152, 29);
            label3.TabIndex = 3;
            label3.Text = "Last Name:";
            // 
            // textBoxFirsname
            // 
            textBoxFirsname.Cursor = Cursors.IBeam;
            textBoxFirsname.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxFirsname.Location = new Point(211, 180);
            textBoxFirsname.Name = "textBoxFirsname";
            textBoxFirsname.Size = new Size(206, 35);
            textBoxFirsname.TabIndex = 4;
            // 
            // textBoxLastname
            // 
            textBoxLastname.Cursor = Cursors.IBeam;
            textBoxLastname.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxLastname.Location = new Point(211, 247);
            textBoxLastname.Name = "textBoxLastname";
            textBoxLastname.Size = new Size(206, 35);
            textBoxLastname.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(47, 324);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(158, 29);
            label4.TabIndex = 6;
            label4.Text = "User Name:";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Cursor = Cursors.IBeam;
            textBoxUsername.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxUsername.Location = new Point(211, 318);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(206, 35);
            textBoxUsername.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(47, 390);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.No;
            label5.Size = new Size(147, 29);
            label5.TabIndex = 8;
            label5.Text = "Password :";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Cursor = Cursors.IBeam;
            textBoxPassword.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPassword.Location = new Point(211, 390);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(206, 35);
            textBoxPassword.TabIndex = 9;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(52, 473);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.No;
            label6.Size = new Size(84, 29);
            label6.TabIndex = 10;
            label6.Text = "Role :";
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.PaleTurquoise;
            buttonLogin.Cursor = Cursors.Hand;
            buttonLogin.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogin.Location = new Point(475, 573);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(139, 73);
            buttonLogin.TabIndex = 11;
            buttonLogin.Text = "Log in ";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.Red;
            buttonCancel.Cursor = Cursors.Hand;
            buttonCancel.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCancel.Location = new Point(330, 573);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(139, 73);
            buttonCancel.TabIndex = 12;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // comboBoxRole
            // 
            comboBoxRole.Cursor = Cursors.Hand;
            comboBoxRole.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRole.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Items.AddRange(new object[] { "Admin", "Teacher", "Student" });
            comboBoxRole.Location = new Point(211, 473);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(206, 37);
            comboBoxRole.TabIndex = 13;
            // 
            // Form1
            // 
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(669, 671);
            Controls.Add(comboBoxRole);
            Controls.Add(buttonCancel);
            Controls.Add(buttonLogin);
            Controls.Add(label6);
            Controls.Add(textBoxPassword);
            Controls.Add(label5);
            Controls.Add(textBoxUsername);
            Controls.Add(label4);
            Controls.Add(textBoxLastname);
            Controls.Add(textBoxFirsname);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "   ";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxFirsname;
        private TextBox textBoxLastname;
        private Label label4;
        private TextBox textBoxUsername;
        private Label label5;
        private TextBox textBoxPassword;
        private Label label6;
        private Button buttonLogin;
        private Button buttonCancel;
        private ComboBox comboBoxRole;
        private PictureBox pictureBox1;

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            DatabaseConnection dbCon = new DatabaseConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable dt = new DataTable();
            MySqlCommand command = new MySqlCommand("SELECT * FROM user WHERE firstname=@fn AND lastname=@ln AND Login=@lg AND password=@pw ANd Role=@role", DatabaseConnection.GetConnection());
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = textBoxFirsname.Text;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = textBoxLastname.Text;
            command.Parameters.Add("@lg", MySqlDbType.VarChar).Value = textBoxUsername.Text;
            command.Parameters.Add("@pw", MySqlDbType.VarChar).Value = textBoxPassword.Text;
            command.Parameters.Add("@role", MySqlDbType.VarChar).Value = comboBoxRole.SelectedItem.ToString();


            adapter.SelectCommand = command;
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
              this.DialogResult = DialogResult.OK;


            }
            else
            {
                MessageBox.Show("Invalid credentials. Please try again.", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
