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
    
    public partial class ProjectAdd : Form
    {
        public Image projectimage1;
        public Image projectimage2;
        public Image projectimage3;
        public Image projectimage4;
        public ProjectAdd()
        {
            InitializeComponent();

            richTextBox1.TextChanged += new EventHandler(richTextBox1_TextChanged);
            //webBrowser1.Navigate("https://www.google.ro/maps/@44.4267672,26.1023027,17z?hl=en", null, null,"aaaa");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dashboard dash = new dashboard(); //next to app form 
            dash = new dashboard();
            dash.Show(); //show app form
            this.Hide(); //login form hide
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "JPG(*JPG)|*.jpg";
            if (f.ShowDialog() == DialogResult.OK)
            {
                projectimage1 = Image.FromFile(f.FileName);
                pictureBox1.Image = projectimage1;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "JPG(*JPG)|*.jpg";
            if (f.ShowDialog() == DialogResult.OK)
            {
                projectimage2 = Image.FromFile(f.FileName);
                pictureBox2.Image = projectimage2;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "JPG(*JPG)|*.jpg";
            if (f.ShowDialog() == DialogResult.OK)
            {
                projectimage3 = Image.FromFile(f.FileName);
                pictureBox3.Image = projectimage3;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "JPG(*JPG)|*.jpg";
            if (f.ShowDialog() == DialogResult.OK)
            {
                projectimage4 = Image.FromFile(f.FileName);
                pictureBox4.Image = projectimage4;
            }
        }




        string stringcon = System.Configuration.ConfigurationManager.ConnectionStrings["residenceBDcon"].ConnectionString;
      

        SqlCommand cmd = new SqlCommand();
        SqlCommand cmd1 = new SqlCommand();

        private void editbutton_Click(object sender, EventArgs e)
        {

            dashboard dh = new dashboard();
            SqlConnection con = new SqlConnection(stringcon);

            if (pictureBox1.Image != null)
            {
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                byte[] a = ms.GetBuffer();
                ms.Close();

                MemoryStream ms1 = new MemoryStream();
                pictureBox2.Image.Save(ms1, pictureBox2.Image.RawFormat);
                byte[] a2 = ms1.GetBuffer();
                ms1.Close();

                MemoryStream ms2 = new MemoryStream();
                pictureBox3.Image.Save(ms2, pictureBox3.Image.RawFormat);
                byte[] a3 = ms2.GetBuffer();
                ms2.Close();

                MemoryStream ms3 = new MemoryStream();
                pictureBox4.Image.Save(ms3, pictureBox4.Image.RawFormat);
                byte[] a4 = ms3.GetBuffer();
                ms3.Close();



                cmd.Parameters.Clear();
          



                cmd.Connection = con;

                cmd.CommandText = "Insert into proiecte(numeproiect,judet,oras,strada,data_ora,numaretajeimobil,clasaenergetica,parcare,mezanin,demisol,mansarda ,descriereproiect ,img1,img2,img3,img4,id_echipa,numeagent)   values(@numeproiect , @judet  , @oras    , @strada  , @data_ora , @numaretajeimobil, @clasaenergetica, @parcare  , @mezanin , @demisol , @mansarda  , @descriereproiect  , @img1  , @img2    , @img3     , @img4,(select id_echipa from echipa where email=@email),(select CONCAT(nume,' ',prenume) from echipa where email=@email))";
              


                cmd.Parameters.AddWithValue("@numeproiect", nameofproject.Text);
                cmd.Parameters.AddWithValue("@judet", district_text.Text);
                cmd.Parameters.AddWithValue("@oras", city_text.Text);
                cmd.Parameters.AddWithValue("@strada", street_text.Text);
                cmd.Parameters.AddWithValue("@data_ora", DateTime.Now.ToString("yyyy-MM-dd HH: mm:ss"));
                cmd.Parameters.AddWithValue("@numaretajeimobil", bunifuDropdown2.selectedValue);
                cmd.Parameters.AddWithValue("@clasaenergetica", bunifuMaterialTextbox1.Text);
                cmd.Parameters.AddWithValue("@parcare", bunifuMaterialTextbox1.Text);
                cmd.Parameters.AddWithValue("@mezanin", mezanine);
                cmd.Parameters.AddWithValue("@demisol", semibasement);
                cmd.Parameters.AddWithValue("@mansarda", mansard);
                cmd.Parameters.AddWithValue("@descriereproiect", richTextBox1.Text);
                


                cmd.Parameters.AddWithValue("@img1", a);
                cmd.Parameters.AddWithValue("@img2", a2);
                cmd.Parameters.AddWithValue("@img3", a3);
                cmd.Parameters.AddWithValue("@img4", a4);
                cmd.Parameters.AddWithValue("@EMAIL", loginform.Email);
                con.Open();
               cmd.ExecuteNonQuery();
                con.Close();
                
            }


            //Application.Exit(); // this is not good for this
            dashboard dash = new dashboard(); //next to app form 
            dash = new dashboard();
            dash.Show(); //show app form
            this.Hide(); //login form hide
            dash.bunifuCustomLabel6.Visible = true;
            dash.popupsuccesdatainsert.Start();
        }

     

        string mezanine;
        private void bunifuiOSSwitch1_Click(object sender, EventArgs e)
        {
            mezanine = "Nu";            
         }
       

      
        private void bunifuiOSSwitch1_Load(object sender, EventArgs e)
        {
            mezanine = "Da";
        }

        string semibasement;
       
        private void bunifuiOSSwitch2_Load_1(object sender, EventArgs e)
        {
            semibasement = "Da";
        }

        private void bunifuiOSSwitch2_Click_1(object sender, EventArgs e)
        {
            semibasement = "Nu";
        }
        string mansard;
        private void bunifuiOSSwitch3_Load(object sender, EventArgs e)
        {
            mansard = "Da";
        }

        private void bunifuiOSSwitch3_Click(object sender, EventArgs e)
        {
            mansard = "Nu";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            label22.Text = "Caractere rămase: " + (1000 - richTextBox1.Text.Length).ToString();
        }
    }
}
