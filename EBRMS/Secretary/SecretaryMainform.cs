using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EBRMS.Priest
{
    public partial class frmMainSecretary : Form
    {
        public frmMainSecretary()
        {
            InitializeComponent();
        }


        private void btnUsers_Click(object sender, EventArgs e)
        {
            if (!panelModule.Controls.Contains(ucUserManagement.usersInstance))
            {
                panelModule.Controls.Add(ucUserManagement.usersInstance);
                ucUserManagement.usersInstance.Dock = DockStyle.Fill;
                ucUserManagement.usersInstance.BringToFront();
            }
            else
            {
                ucUserManagement.usersInstance.BringToFront();
            }
        }

        private void frmMainPriest_Load(object sender, EventArgs e)
        {
            lblUserName.Text = Login.GetUserName.ToString();
            lblUserRole.Text = Login.GetUserRole.ToString();
        }
    }
}
