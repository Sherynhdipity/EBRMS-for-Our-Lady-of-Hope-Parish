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
    public partial class frmMainPriest : Form
    {
        public frmMainPriest()
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
            lblUserName.Text = frmLogin.GetUserName.ToString();
            lblUserRole.Text = frmLogin.GetUserRole.ToString();
        }

        private void pbLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to Logout?", "Log-out", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                frmLogin login = new frmLogin();
                this.Hide();
                login.Show();

                frmAddUser addUser = new frmAddUser();
                frmUpdateUser updateUser = new frmUpdateUser();

            }
        }

        private void btnSchedules_Click(object sender, EventArgs e)
        {
            if (!panelModule.Controls.Contains(ucScheduleManagement.scheduleInstance))
            {
                panelModule.Controls.Add(ucScheduleManagement.scheduleInstance);
                ucScheduleManagement.scheduleInstance.Dock = DockStyle.Fill;
                ucScheduleManagement.scheduleInstance.BringToFront();
            }
            else
            {
                ucScheduleManagement.scheduleInstance.BringToFront();
            }
        }
    }
}
