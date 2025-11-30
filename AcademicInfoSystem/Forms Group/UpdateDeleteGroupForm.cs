using AcademicInfoSystem.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademicInfoSystem.Forms_Group
{
    public partial class UpdateDeleteGroupForm : Form
    {
        public UpdateDeleteGroupForm()
        {
            InitializeComponent();
        }
        Group group = new Group();
        bool verify()
        {
            if ((textBoxGroupId.Text.Trim() == "") ||
                (textBoxGroupName.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;


            }
        }
        private void UpdateDeleteGroup_Load(object sender, EventArgs e)
        {

        }
        private void buttonFindGroup_Click(object sender, EventArgs e)
        {
            int GroupId = Convert.ToInt32(textBoxGroupId.Text);
            MySqlCommand command = new MySqlCommand("SELECT GroupId, Name FROM studentgroup Where GroupId = " + GroupId);
            DataTable table = group.GetGroupList(command);

            if (table.Rows.Count > 0)
            {
                textBoxGroupId.Text = table.Rows[0]["GroupId"].ToString();
                textBoxGroupName.Text = table.Rows[0]["Name"].ToString();
               
            }
            else
            {
                MessageBox.Show("Group  not found.");
            }
        }

        private void buttonEditGroup_Click(object sender, EventArgs e)
        { 
        }

        private void buttonRemoveGroup_Click(object sender, EventArgs e)
        {
        }




    }
}
