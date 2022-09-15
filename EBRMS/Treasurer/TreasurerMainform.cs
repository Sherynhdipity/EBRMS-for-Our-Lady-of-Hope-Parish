using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EBRMS.Treasurer
{
    public partial class frmMainTreasurer : Form
    {
        public frmMainTreasurer()
        {
            InitializeComponent();
        }

        private void btnCollections_Click(object sender, EventArgs e)
        {
            if (!panelModule.Controls.Contains(ucCollections.collectionsInstance))
            {
                panelModule.Controls.Add(ucCollections.collectionsInstance);
                ucCollections.collectionsInstance.Dock = DockStyle.Fill;
                ucCollections.collectionsInstance.BringToFront();
            }
            else
            {
                ucCollections.collectionsInstance.BringToFront();
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
