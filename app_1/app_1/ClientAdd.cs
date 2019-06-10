using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
namespace app_1
{
    public partial class ClientAdd : Form
    {
        public ClientAdd()
        {
            InitializeComponent();
            richTextBox1.TextChanged += new EventHandler(richTextBox1_TextChanged);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized; //minimize dashboard form
        }

        string gender;
        string gender1;

        

        private void button1_Click(object sender, EventArgs e)
        {
            //Application.Exit(); // this is not good for this
            dashboard dash = new dashboard(); //next to app form 
            dash = new dashboard();
            dash.Show(); //show app form
            this.Hide(); //login form hide

            



        }

        string stringcon = System.Configuration.ConfigurationManager.ConnectionStrings["residenceBDcon"].ConnectionString;
        SqlCommand cmd = new SqlCommand();
        SqlCommand cmd2 = new SqlCommand();

        private void editbutton_Click(object sender, EventArgs e)
        {
            //Application.Exit(); // this is not good for this
            dashboard dash = new dashboard(); //next to app form 
            dash = new dashboard();
            dash.Show(); //show app form
            this.Hide(); //login form hide


            SqlConnection con = new SqlConnection(stringcon);


            Image img = Image.FromFile(@"C:\Users\IULIAN-DANIELGLAVAN\Desktop\Calculator\app_1\bd\verde.png");
            byte[] arr;
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                arr = ms.ToArray();
            }

            

            //  string select = "select CONCAT(nume,' ',prenume) from echipa where email=@EMAIL";

            cmd.Connection = con;

            if (bunifuCheckbox1.Checked == true)
            {
                con.Open();
                //cmd.CommandText = "Insert into clienti_fizici(nume,prenume,email,telefon,adresa,data_nasterii,data_ora,CNP,sex,judetprovenienta,temperamentclient,provenientaclient,descriere,numeagent)values('" + bunifuMaterialTextbox1.Text + "','" + bunifuMaterialTextbox2.Text + "','" + bunifuMaterialTextbox4.Text + "','" + bunifuMaterialTextbox8.Text + "','" + bunifuMaterialTextbox3.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd HH: mm:ss") + "','" + bunifuDatepicker1.Value.Date + "','" + bunifuMaterialTextbox11.Text + "','" + gender + "','" + bunifuMaterialTextbox12.Text + "','" + bunifuDropdown1.selectedValue + "','" + bunifuDropdown2.selectedValue + "','" + richTextBox1.Text + "','" + select + "')";
                cmd.CommandText = "Insert into clienti_fizici(nume,prenume,email,telefon,adresa,data_nasterii,data_ora,CNP,sex,judetprovenienta,temperamentclient,provenientaclient,statut,descriere,numeagent)values(@nume,@prenume,@email,@telefon,@adresa,@data_nasterii,@data_ora,@CNP,@sex,@judetprovenienta,@temperamentclient,@provenientaclient,@statut,@descriere,(select CONCAT(nume,' ',prenume) from echipa where email=@EMAIL2))";
                cmd.Parameters.AddWithValue("@nume", bunifuMaterialTextbox1.Text);
                cmd.Parameters.AddWithValue("@prenume", bunifuMaterialTextbox2.Text);
                cmd.Parameters.AddWithValue("@email", bunifuMaterialTextbox4.Text);
                cmd.Parameters.AddWithValue("@telefon", bunifuMaterialTextbox8.Text);
                cmd.Parameters.AddWithValue("@adresa", bunifuMaterialTextbox3.Text);
                cmd.Parameters.AddWithValue("@data_nasterii", bunifuDatepicker1.Value.Date);
                cmd.Parameters.AddWithValue("@data_ora", DateTime.Now.ToString("yyyy-MM-dd HH: mm:ss"));
                cmd.Parameters.AddWithValue("@CNP", bunifuMaterialTextbox11.Text);
                cmd.Parameters.AddWithValue("@sex", gender);
                cmd.Parameters.AddWithValue("@judetprovenienta", bunifuMaterialTextbox12.Text);
                cmd.Parameters.AddWithValue("@temperamentclient", bunifuDropdown1.selectedValue);
                cmd.Parameters.AddWithValue("@provenientaclient", bunifuDropdown2.selectedValue);
                cmd.Parameters.AddWithValue("@descriere", richTextBox1.Text);
                cmd.Parameters.AddWithValue("@statut",arr);

                cmd.Parameters.AddWithValue("@EMAIL2", loginform.Email);
                
                cmd.ExecuteNonQuery();
                con.Close();
                dash.bunifuCustomLabel6.Visible = true;
                dash.popupsuccesdatainsert.Start();
            }



            if (bunifuCheckbox2.Checked == true)
            {


                con.Open();
                cmd.CommandText = "Insert into clienti_juridici(numecompanie,CUI,replegal,telefoncompanie,emailcompanie,adresa,data_nasterii,data_ora,CNP,sex,judetprovenienta,statut,temperamentclient,provenientaclient,descriere,numeagent)values(@numecompanie,@CUI,@replegal,@telefoncompanie,@emailcompanie,@adresa,@data_nasterii,@data_ora,@CNP,@sex,@judetprovenienta,@statut,@temperamentclient,@provenientaclient,@descriere,(select CONCAT(nume,' ',prenume) from echipa where email=@EMAIL2))";
                cmd.Parameters.AddWithValue("@numecompanie", bunifuMaterialTextbox5.Text);
                cmd.Parameters.AddWithValue("@CUI", bunifuMaterialTextbox6.Text);
                cmd.Parameters.AddWithValue("@replegal", bunifuMaterialTextbox7.Text);
                cmd.Parameters.AddWithValue("@telefoncompanie", bunifuMaterialTextbox9.Text);
                cmd.Parameters.AddWithValue("@emailcompanie", bunifuMaterialTextbox10.Text);
                cmd.Parameters.AddWithValue("@adresa", bunifuMaterialTextbox3.Text);
                cmd.Parameters.AddWithValue("@data_nasterii", bunifuDatepicker1.Value.Date);
                cmd.Parameters.AddWithValue("@data_ora", DateTime.Now.ToString("yyyy-MM-dd HH: mm:ss"));
                cmd.Parameters.AddWithValue("@CNP", bunifuMaterialTextbox11.Text);
                cmd.Parameters.AddWithValue("@sex", gender);
                cmd.Parameters.AddWithValue("@judetprovenienta", bunifuMaterialTextbox12.Text);
                cmd.Parameters.AddWithValue("@temperamentclient", bunifuDropdown1.selectedValue);
                cmd.Parameters.AddWithValue("@provenientaclient", bunifuDropdown2.selectedValue);
                cmd.Parameters.AddWithValue("@descriere", richTextBox1.Text);
                cmd.Parameters.AddWithValue("@statut", arr);
                cmd.Parameters.AddWithValue("@EMAIL2", loginform.Email);
                
                cmd.ExecuteNonQuery();
                con.Close();
                dash.bunifuCustomLabel6.Visible = true;
                dash.popupsuccesdatainsert.Start();
            }

        }

        private void bunifuMaterialTextbox8_KeyPress(object sender, KeyPressEventArgs e) //have 2 reference
        {
            char telephonenumbercharacter = e.KeyChar;
            if (!Char.IsDigit(telephonenumbercharacter) && telephonenumbercharacter != 8 && telephonenumbercharacter != 46)
            { e.Handled = true; }
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            gender = "Masculin";
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            gender = "Feminin";
        }

        private void radioButton4_CheckedChanged_1(object sender, EventArgs e)
        {
             gender1 = "Masculin";
        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
                gender1 = "Feminin";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            label22.Text = "Caractere rămase: "+(1000 - richTextBox1.Text.Length).ToString();
        }

        private void bunifuCheckbox1_Click(object sender, EventArgs e)
        {
            if (bunifuCheckbox2.Checked == true)
            {
                bunifuCheckbox2.Checked = false;
                label6.Visible = true;
                label5.Visible = true;
                label1.Visible = true;
                label20.Visible = true;
                bunifuMaterialTextbox1.Visible = true;
                bunifuMaterialTextbox2.Visible = true;
                bunifuMaterialTextbox4.Visible = true;
                bunifuMaterialTextbox8.Visible = true;
                label12.Visible = false;
                label13.Visible = false;
                label14.Visible = false;
                label21.Visible = false;
                label15.Visible = false;
                bunifuMaterialTextbox5.Visible = false;
                bunifuMaterialTextbox6.Visible = false;
                bunifuMaterialTextbox7.Visible = false;
                bunifuMaterialTextbox9.Visible = false;
                bunifuMaterialTextbox10.Visible = false;

            }
            else
                {
                return;
                }
        }

        private void bunifuCheckbox2_Click(object sender, EventArgs e)
        {
            if (bunifuCheckbox1.Checked == true)
            {
                bunifuCheckbox1.Checked = false;
                label12.Visible = true;
                label13.Visible = true;
                label14.Visible = true;
                label21.Visible = true;
                label15.Visible = true;
                bunifuMaterialTextbox5.Visible = true;
                bunifuMaterialTextbox6.Visible = true;
                bunifuMaterialTextbox7.Visible = true;
                bunifuMaterialTextbox9.Visible = true;
                bunifuMaterialTextbox10.Visible = true;
                label6.Visible = false;
                label5.Visible = false;
                label1.Visible = false;
                label20.Visible = false;
                bunifuMaterialTextbox1.Visible = false;
                bunifuMaterialTextbox2.Visible = false;
                bunifuMaterialTextbox4.Visible = false;
                bunifuMaterialTextbox8.Visible = false;
            }
            else
                {
                return;
                }
        }
    }
}
