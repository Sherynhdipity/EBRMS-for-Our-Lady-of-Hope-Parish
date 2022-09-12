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
    }
}
