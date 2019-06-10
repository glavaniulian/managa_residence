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
    public partial class customersphysical : Form
    {
        public customersphysical()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dashboard dashhi = new dashboard();
            this.Hide();
            dashhi.Show();
        }
    }
}
