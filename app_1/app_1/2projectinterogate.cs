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
    public partial class projectinterogate : Form
    {
        
        public projectinterogate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            dashboard dashhhh = new dashboard();
            dashhhh.Show();
        }
        public int minpriceproject;
        public int maxpriceproject;

        private void priceinterval_RangeMinChanged(object sender, EventArgs e)
        {
            minpriceproject = priceinterval.RangeMin;
            minpriceinterval.Text = minpriceproject.ToString() + " €";
        }

        private void priceinterval_RangeMaxChanged(object sender, EventArgs e)
        {
            maxpriceproject = priceinterval.RangeMax;
            maxpriceinterval.Text = maxpriceproject.ToString() + " €";
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

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (clickpicture == true)
            {
                pictureBox1.Dock = DockStyle.Fill;
                pictureBox1.BringToFront();
                clickpicture = false;
            }
            else
            {
                pictureBox1.Dock = DockStyle.None;
                pictureBox1.SendToBack();
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
    }
}
