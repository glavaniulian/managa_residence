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
    public partial class Myprofile : Form
    {
        public Myprofile()
        {
            InitializeComponent();
            if (!panel2.Controls.Contains(myprofil_component.Instance))
            {
                panel2.Controls.Add(myprofil_component.Instance);
                myprofil_component.Instance.Dock = DockStyle.Fill;
                myprofil_component.Instance.BringToFront();
            }
            else
            {
                myprofil_component.Instance.BringToFront();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dashboard dash = new dashboard(); //go to login form
            dash.Show(); //show login form
            this.Hide(); //hide app form
        }
        
        
    }
}
