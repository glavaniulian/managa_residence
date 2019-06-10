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
    public partial class propertiesinterogate : Form
    {
        public propertiesinterogate()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            dashboard dashhhhhh = new dashboard();
            dashhhhhh.Show();
        }
        public bool clickpicture = true;
        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (clickpicture == true)
            {
                pictureBox2.Dock = DockStyle.Fill;
                pictureBox2.BringToFront();
                clickpicture = false;
            }
            else
            {
                pictureBox2.Dock = DockStyle.None;
                pictureBox2.SendToBack();
                clickpicture = true;
            }
        }

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            if (clickpicture == true)
            {
                pictureBox3.Dock = DockStyle.Fill;
                pictureBox3.BringToFront();
                clickpicture = false;
            }
            else
            {
                pictureBox3.Dock = DockStyle.None;
                pictureBox3.SendToBack();
                clickpicture = true;
            }
        }

        private void pictureBox4_MouseClick(object sender, MouseEventArgs e)
        {
            if (clickpicture == true)
            {
                pictureBox4.Dock = DockStyle.Fill;
                pictureBox4.BringToFront();
                clickpicture = false;
            }
            else
            {
                pictureBox4.Dock = DockStyle.None;
                pictureBox4.SendToBack();
                clickpicture = true;
            }
        }
        private void blackscreensell()
        {
            popupbackforesellproperties popupblack = new popupbackforesellproperties();
            popupblack.Show();
        }
        private void addnewproject_Click(object sender, EventArgs e)
        {
            sellproperties sellproppp = new sellproperties();
            
            blackscreensell();
            sellproppp.ShowDialog();
            sellproppp.Focus();
            
        }
    }
}
