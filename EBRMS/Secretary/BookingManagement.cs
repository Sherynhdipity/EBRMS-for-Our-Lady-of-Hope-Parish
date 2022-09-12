﻿using System;
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
    }
}
