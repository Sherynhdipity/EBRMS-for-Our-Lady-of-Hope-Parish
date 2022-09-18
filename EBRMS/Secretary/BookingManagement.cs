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
    public partial class ucBookingManagement : UserControl
    {
        public ucBookingManagement()
        {
            InitializeComponent();
        }

        private static ucBookingManagement booking;

        public static ucBookingManagement bookingInstance
        {
            get
            {
                if (booking == null)
                    booking = new ucBookingManagement();
                return booking;
            }

        }

        private void cmbEventType_SelectedValueChanged(object sender, EventArgs e)
        {
            lblEventName.Text = cmbEventType.Text;
        }

        private void cmbEventType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbEventType.SelectedIndex == 0) 
            {
                pnlBaptism.Visible = true;
                pnlConfirmation.Visible = false;
                pnlWedding.Visible = false;
                pnlFuneral.Visible = false;
            }
            else if(cmbEventType.SelectedIndex == 1)
            {
                pnlBaptism.Visible = false;
                pnlConfirmation.Visible = true;
                pnlWedding.Visible = false;
                pnlFuneral.Visible = false;
            }
            else if (cmbEventType.SelectedIndex == 2)
            {
                pnlBaptism.Visible = false;
                pnlConfirmation.Visible = false;
                pnlWedding.Visible = true;
                pnlFuneral.Visible = false;
            }
            else if(cmbEventType.SelectedIndex == 3)
            {
                pnlBaptism.Visible = false;
                pnlConfirmation.Visible = false;
                pnlWedding.Visible = false;
                pnlFuneral.Visible = true;
            }
            else
            {
                pnlBaptism.Visible = false;
                pnlConfirmation.Visible = false;
                pnlWedding.Visible = false;
                pnlFuneral.Visible = false;
            }

        }
    }
}
