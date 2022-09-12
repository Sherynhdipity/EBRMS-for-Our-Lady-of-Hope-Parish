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
    public partial class ucCollections : UserControl
    {
        public ucCollections()
        {
            InitializeComponent();
        }

        private static ucCollections collections;

        public static ucCollections collectionsInstance
        {
            get
            {
                if (collections == null)
                    collections = new ucCollections();
                return collections;
            }

        }
    }
}
