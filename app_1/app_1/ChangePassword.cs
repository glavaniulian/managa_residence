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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
            
        }
        

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            
            
            this.Close();
            popupbackforechpass popupblack = new popupbackforechpass();
            popupbackforechpass closeshitpopup = (popupbackforechpass)Application.OpenForms["popupbackforechpass"];
            closeshitpopup.Hide();
        }

        private void editbutton_Click(object sender, EventArgs e)
        {
            //in this area you need to make update to database













            //in this area you need to make update to database
            
            this.Hide();
            popupbackforechpass popupblack = new popupbackforechpass();
            popupbackforechpass closeshitpopup = (popupbackforechpass)Application.OpenForms["popupbackforechpass"];
            closeshitpopup.Hide();
            
        }
    }
}
