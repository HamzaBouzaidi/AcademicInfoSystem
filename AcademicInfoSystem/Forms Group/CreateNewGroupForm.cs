using AcademicInfoSystem.Models;
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
    public partial class CreateNewGroupForm : Form
    {
        public CreateNewGroupForm()
        {
            InitializeComponent();
        }
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

        private void buttonAddGroup_Click(object sender, EventArgs e)
        {
            if (!verify())
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            Group group = new Group();
            int GroupId = textBoxGroupId.Text.Trim()==  "" ? 0 : int.Parse(textBoxGroupId.Text.Trim()); ;
            string Name = textBoxGroupName.Text.Trim();
            



            bool success = group.AddGroup(GroupId, Name);
            if (success)
                MessageBox.Show("Group added successfully!");
            else
                MessageBox.Show("Failed to add Group. Check foreign keys or database connection.");
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
    
}
