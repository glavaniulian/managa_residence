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
    public partial class popupbackforechpass : Form
    {
        public bool onetime = false;
        
        public popupbackforechpass()
        {
            InitializeComponent();
        }

        //private void popupbackfore_MouseEnter(object sender, EventArgs e)
        //{
            //ChangePassword chpassss = new ChangePassword();
            //chpassss.ShowDialog();
        //}

        private void popupbackfore_Click(object sender, EventArgs e)
        {
            ChangePassword chpassss = new ChangePassword();
            chpassss.ShowDialog();
        }

        private void popupbackfore_DoubleClick(object sender, EventArgs e)
        {
            ChangePassword chpassss = new ChangePassword();
            chpassss.ShowDialog();

        }
    }
}
