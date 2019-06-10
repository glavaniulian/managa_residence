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
    public partial class sellproperties : Form
    {
        public sellproperties()
        {
            InitializeComponent();
            richTextBox1.TextChanged += new EventHandler(richTextBox1_TextChanged);
            label8.Visible = false;
            bunifuDropdown2.Visible = false;
            bunifuCustomLabel1.Visible = true;
            IDclient.Visible = true;
            clientname.Visible = true;
            telephone.Visible = true;
            CNP.Visible = true;
            clientpicksell.Visible = true;
            label1.Visible = false;
            pictureBox25.Visible = false;
            pictureBox3.Visible = false;
            label3.Visible = false;
            bunifuMetroTextbox1.Visible = false;
            label18.Visible = false;
            richTextBox1.Visible = false;
            label22.Visible = false;
            label32.Visible = false;
            editbutton.Visible = false;
            bunifuFlatButton1.Visible = false;
            label2.Visible = false;

        }

        private void bunifuTileButton1_Click(object sender, EventArgs e) //step1
        {
            label8.Visible = false;
            bunifuDropdown2.Visible = false;
            bunifuCustomLabel1.Visible = true;
            bunifuCustomLabel1.Text = "* Alegeți clientul căruia vreți să îi aociați proprietatea.";
            IDclient.Visible = true;
            clientname.Visible = true;
            telephone.Visible = true;
            CNP.Visible = true;
            clientpicksell.Visible = true;
            label1.Visible = false;
            pictureBox25.Visible = false;
            pictureBox3.Visible = false;
            label3.Visible = false;
            bunifuMetroTextbox1.Visible = false;
            label18.Visible = false;
            richTextBox1.Visible = false;
            label22.Visible = false;
            label32.Visible = false;
            editbutton.Visible = false;
            bunifuFlatButton1.Visible = false;
            label2.Visible = false;
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e) //step 2
        {
            label8.Visible = true;
            bunifuDropdown2.Visible = true;
            bunifuCustomLabel1.Visible = true;
            bunifuCustomLabel1.Text = "* Completați prețul de vânzare si descrierea vânzării.";
            IDclient.Visible = false;
            clientname.Visible = false;
            telephone.Visible = false;
            CNP.Visible = false;
            clientpicksell.Visible = false;
            label1.Visible = true;
            pictureBox25.Visible = true;
            pictureBox3.Visible = true;
            label3.Visible = true;
            bunifuMetroTextbox1.Visible = true;
            label18.Visible = true;
            richTextBox1.Visible = true;
            label22.Visible = true;
            label32.Visible = true;
            editbutton.Visible = false;
            bunifuFlatButton1.Visible = false;
            label2.Visible = false;
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e) //step 3
        {
            label8.Visible = false;
            bunifuDropdown2.Visible = false;
            bunifuCustomLabel1.Visible = true;
            bunifuCustomLabel1.Text = "* Completați tranșele de bani.";
            IDclient.Visible = false;
            clientname.Visible = false;
            telephone.Visible = false;
            CNP.Visible = false;
            clientpicksell.Visible = false;
            label1.Visible = false;
            pictureBox25.Visible = false;
            pictureBox3.Visible = false;
            label3.Visible = false;
            bunifuMetroTextbox1.Visible = false;
            label18.Visible = false;
            richTextBox1.Visible = false;
            label22.Visible = false;
            label32.Visible = false;
            editbutton.Visible = true;
            bunifuFlatButton1.Visible = true;
            label2.Visible = true;
        }
        private void clientpicksell_mousewheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0 && clientpicksell.FirstDisplayedScrollingRowIndex > 0)
            {
                clientpicksell.FirstDisplayedScrollingRowIndex--;
            }
            else if (e.Delta < 0)
            {
                clientpicksell.FirstDisplayedScrollingRowIndex++;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            label22.Text = "Caractere rămase: " + (1000 - richTextBox1.Text.Length).ToString();
        }
        private void focus()
        {
            propertiesinterogate focusepropp = new propertiesinterogate();
            propertiesinterogate focusedprop = (propertiesinterogate)Application.OpenForms["propertiesinterogate"];
            focusedprop.Focus();
        }
        private void editbutton_Click(object sender, EventArgs e)
        {
            //here you have to add in database

            //in this area
            this.Hide();
            popupbackforesellproperties popupblacksell = new popupbackforesellproperties();
            popupbackforesellproperties blackpopup = (popupbackforesellproperties)Application.OpenForms["popupbackforesellproperties"];
            focus();
            blackpopup.Close();
            
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            popupbackforesellproperties popupblacksell = new popupbackforesellproperties();
            popupbackforesellproperties blackpopup = (popupbackforesellproperties)Application.OpenForms["popupbackforesellproperties"];
            focus();
            blackpopup.Close();
            
        }
    }
}
