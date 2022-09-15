using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EBRMS.Secretary
{
    public partial class frmMainSecretary : Form
    {
        public frmMainSecretary()
        {
            InitializeComponent();
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            if (!panelModule.Controls.Contains(ucBookingManagement.bookingInstance))
            {
                panelModule.Controls.Add(ucBookingManagement.bookingInstance);
                ucBookingManagement.bookingInstance.Dock = DockStyle.Fill;
                ucBookingManagement.bookingInstance.BringToFront();
            }
            else
            {
                ucBookingManagement.bookingInstance.BringToFront();
            }
        }

        private void btnSearchRecords_Click(object sender, EventArgs e)
        {
            if (!panelModule.Controls.Contains(ucRecords.recordsInstance))
            {
                panelModule.Controls.Add(ucRecords.recordsInstance);
                ucRecords.recordsInstance.Dock = DockStyle.Fill;
                ucRecords.recordsInstance.BringToFront();
            }
            else
            {
                ucRecords.recordsInstance.BringToFront();
            }
        }

        private void pbLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to Logout?", "Log-out", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                frmLogin login = new frmLogin();
                this.Hide();
                login.Show();

            }
        }
    }
}
