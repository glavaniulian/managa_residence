using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_1
{
    public partial class popupbackforesellproperties : Form
    {
        public popupbackforesellproperties()
        {
            InitializeComponent();
        }

        private void popupbackforesellproperties_Click(object sender, EventArgs e)
        {
            sellproperties sellprop = new sellproperties();
            sellprop.ShowDialog();
        }

        private void popupbackforesellproperties_DoubleClick(object sender, EventArgs e)
        {
            sellproperties selpropp = new sellproperties();
            selpropp.ShowDialog();
        }
    }
}
