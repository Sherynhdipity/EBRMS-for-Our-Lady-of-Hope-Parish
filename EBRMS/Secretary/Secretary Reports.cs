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
    public partial class ucSecretaryReports : UserControl
    {
        public ucSecretaryReports()
        {
            InitializeComponent();
        }

        private static ucRecords records;

        public static ucRecords recordsInstance
        {
            get
            {
                if (records == null)
                    records = new ucRecords();
                return records;
            }

        }
    }
}
