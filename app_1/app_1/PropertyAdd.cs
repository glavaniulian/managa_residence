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
using System.Configuration;
using System.IO;


namespace app_1
{
    public partial class PropertyAdd : Form
    {
        public Image propertyimage1;
        public Image propertyimage2;
        public Image propertyimage3;
        public PropertyAdd()
        {
            InitializeComponent();
            richTextBox2.TextChanged += new EventHandler(richTextBox2_TextChanged);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dashboard dash = new dashboard(); //next to app form 
            dash = new dashboard();
            dash.Show(); //show app form
            this.Hide(); //login form hide
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "JPG(*JPG)|*.jpg";
            if (f.ShowDialog() == DialogResult.OK)
            {
                propertyimage1 = Image.FromFile(f.FileName);
                pictureBox4.Image = propertyimage1;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "JPG(*JPG)|*.jpg";
            if (f.ShowDialog() == DialogResult.OK)
            {
                propertyimage1 = Image.FromFile(f.FileName);
                pictureBox3.Image = propertyimage1;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "JPG(*JPG)|*.jpg";
            if (f.ShowDialog() == DialogResult.OK)
            {
                propertyimage1 = Image.FromFile(f.FileName);
                pictureBox2.Image = propertyimage1;
            }
        }

        private void bunifuMaterialTextbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char priceboxes = e.KeyChar;
            if (!Char.IsDigit(priceboxes) && priceboxes != 8 && priceboxes != 46)
            { e.Handled = true; }
        }

        private void bunifuMaterialTextbox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char totalsupraface = e.KeyChar;
            if (!Char.IsDigit(totalsupraface) && totalsupraface != 8 && totalsupraface != 46)
            { e.Handled = true; }
        }

        private void bunifuMaterialTextbox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            char buildsupraface = e.KeyChar;
            if (!Char.IsDigit(buildsupraface) && buildsupraface != 8 && buildsupraface != 46)
            { e.Handled = true; }
        }

        private void bunifuMaterialTextbox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char usedsupraface = e.KeyChar;
            if (!Char.IsDigit(usedsupraface) && usedsupraface != 8 && usedsupraface != 46)
            { e.Handled = true; }
        }

        private void bunifuMaterialTextbox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char outsupraface = e.KeyChar;
            if (!Char.IsDigit(outsupraface) && outsupraface != 8 && outsupraface != 46)
            { e.Handled = true; }
        }
        string stringcon = System.Configuration.ConfigurationManager.ConnectionStrings["residenceBDcon"].ConnectionString;
        SqlCommand cmd = new SqlCommand();
        SqlCommand cmd1 = new SqlCommand();


        private void editbutton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(stringcon);




            MemoryStream ms = new MemoryStream();
            pictureBox2.Image.Save(ms, pictureBox2.Image.RawFormat);
            byte[] a = ms.GetBuffer();
            ms.Close();

            MemoryStream ms1 = new MemoryStream();
            pictureBox3.Image.Save(ms1, pictureBox3.Image.RawFormat);
            byte[] a2 = ms1.GetBuffer();
            ms1.Close();

            MemoryStream ms2 = new MemoryStream();
            pictureBox4.Image.Save(ms2, pictureBox4.Image.RawFormat);
            byte[] a3 = ms2.GetBuffer();
            ms2.Close();


            cmd.Parameters.Clear();


            cmd.Connection = con;


            cmd.CommandText = "Insert into proprietati(numeproiect,numeproprietate,pretlista,moneda,data_ora,suprafatatotala,clasaenergetica,tipproprietate,numarbai,suprafataconstruita,suprafatautila,suprafatabalcon ,numarapartament,etaj,finisaje,compartimente,parcare,utilitati,descriere,img1,img2,img3,numeagent,id_proiecte)   values(@numeproiect,@numeproprietate,@pretlista,@moneda,@data_ora,@suprafatatotala,@clasaenergetica,@tipproprietate,@numarbai,@suprafataconstruita,@suprafatautila,@suprafatabalcon,@numarapartament,@etaj,@finisaje,@compartimente,@parcare,@utilitati,@descriere, @img1, @img2, @img3,(select CONCAT(nume,' ',prenume) from echipa where email=@EMAIL),(select proiecte.id_proiecte from proiecte inner join proprietati on proiecte.numeproiect = proprietati.numeproiect where proprietati.numeproiect = @b group by proiecte.id_proiecte))";

            cmd.Parameters.AddWithValue("@numeproiect", bunifuDropdown2.selectedValue);
            cmd.Parameters.AddWithValue("@numeproprietate", nameofproject.Text);
            cmd.Parameters.AddWithValue("@pretlista", bunifuMaterialTextbox1.Text);
            cmd.Parameters.AddWithValue("@suprafatatotala", bunifuMaterialTextbox2.Text);
            cmd.Parameters.AddWithValue("@clasaenergetica", bunifuMaterialTextbox3.Text);
            cmd.Parameters.AddWithValue("@tipproprietate", bunifuDropdown1.selectedValue);
            cmd.Parameters.AddWithValue("@numarbai", bunifuDropdown3.selectedValue);
            cmd.Parameters.AddWithValue("@suprafataconstruita", bunifuMaterialTextbox6.Text);
            cmd.Parameters.AddWithValue("@suprafatautila", bunifuMaterialTextbox5.Text);
            cmd.Parameters.AddWithValue("@suprafatabalcon", bunifuMaterialTextbox4.Text);
            cmd.Parameters.AddWithValue("@etaj", bunifuDropdown5.selectedValue);
            cmd.Parameters.AddWithValue("@finisaje", bunifuDropdown4.selectedValue);
            cmd.Parameters.AddWithValue("@compartimente", bunifuDropdown6.selectedValue);
            cmd.Parameters.AddWithValue("@parcare", bunifuDropdown7.selectedValue);
            cmd.Parameters.AddWithValue("@utilitati", bunifuDropdown8.selectedValue);
            cmd.Parameters.AddWithValue("@descriere", richTextBox2.Text);

            cmd.Parameters.AddWithValue("@data_ora", DateTime.Now.ToString("yyyy-MM-dd HH: mm:ss"));
            cmd.Parameters.AddWithValue("@numarapartament", bunifuMaterialTextbox7.Text);
            cmd.Parameters.AddWithValue("@EMAIL", loginform.Email);
            cmd.Parameters.AddWithValue("@b", bunifuDropdown2.selectedValue);
            cmd.Parameters.AddWithValue("@moneda", bunifuDropdown9.selectedValue);

            cmd.Parameters.AddWithValue("@img1", a);
            cmd.Parameters.AddWithValue("@img2", a2);
            cmd.Parameters.AddWithValue("@img3", a3);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            //Application.Exit(); // this is not good for this
            dashboard dash = new dashboard(); //next to app form 
            dash = new dashboard();
            dash.Show(); //show app form
            this.Hide(); //login form hide

            dash.bunifuCustomLabel6.Visible = true;
            dash.popupsuccesdatainsert.Start();

        }

        private void bunifuDropdown2_onItemSelected(object sender, EventArgs e)
        {

        }

        private void PropertyAdd_Load(object sender, EventArgs e)
        {
            try
            {

                SqlConnection con = new SqlConnection(stringcon);


                con.Open();
                cmd.Connection = con;

                cmd.CommandText = "select * from proiecte";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {

                    bunifuDropdown2.AddItem(dr["numeproiect"].ToString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bunifuDropdown5_onItemSelected(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            label22.Text = "Caractere rămase: " + (1000 - richTextBox2.Text.Length).ToString();
        }
    }
}