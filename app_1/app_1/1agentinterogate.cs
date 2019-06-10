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
    public partial class agentinterogate : Form
    {
        public agentinterogate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dashboard dash = new dashboard(); //next to app form 
            dash = new dashboard();
            dash.Show(); //show app form
            this.Hide(); //login form hide
        }

        private void agentinterogate_Load(object sender, EventArgs e)
        {

        }
    }
}
