using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

using System.IO;    
namespace app_1
{
    
    public partial class myprofil_component : UserControl
    {
        public Image File; //storage for profile image
        private static myprofil_component _instance;
        public static myprofil_component Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new myprofil_component();
                return _instance;
            }
        }
        public myprofil_component()
        {
            InitializeComponent();
            b1.Visible = false;
            b2.Visible = false;
            b3.Visible = false;
            richTextBox1.TextChanged += new EventHandler(richTextBox1_TextChanged);

        }

        private void editbutton_Click(object sender, EventArgs e) /// save edit button
        {
            b1.Visible = false;b2.Visible = false;b3.Visible = false;b4.Visible = false;b5.Visible = false;b6.Visible = false;b7.Visible = false;
            richTextBox1.ReadOnly = true; addimagebutton.Visible = false;editbutton.Visible = false;firstname.Visible = true; telephone.Visible = true;
            firstname.Text = b1.Text;//label take information from textbox
            lastname.Visible = true;
            lastname.Text = b2.Text;//label take information from textbox
            telephone.Text = b7.Text;
            adress.Visible = true;
            adress.Text = b3.Text;//label take information from textbox
            birthday.Visible = true;
            label22.Visible = true;
            //birthday.Text = Convert.ToString(bunifuDatepicker1.Value.Date.ToString("MM-dd-YYYY"));
            //here you need to give information from database

            sex.Visible = true;
            //here you need to give information from database
            functionss.Visible = true;
            functionss.Text = b6.Text;
            //functionss.Text = bunifuDropdown2.selectedValue;
            //here you need to give information from database


            if (profilepictureedit.Image != null)
            {
                MemoryStream ms = new MemoryStream();
                profilepictureedit.Image.Save(ms, profilepictureedit.Image.RawFormat);
                byte[] a = ms.GetBuffer();
                ms.Close();

                try
                {
                    SqlConnection con = new SqlConnection(stringcon);
                    updt.Parameters.Clear();

                    updt.Connection = con;

                    updt.CommandText = "Update echipa set nume=@nume,prenume=@prenume,adresa=@adresa,sex=@sex,functie=@functie,telefon=@telefon,descriere=@desc,poza=@img where email=@EMAIL";

                    updt.Parameters.AddWithValue("@nume", b1.Text);
                    updt.Parameters.AddWithValue("@prenume", b2.Text);
                    updt.Parameters.AddWithValue("@adresa", b3.Text);
                    //updt.Parameters.AddWithValue("@data", bunifuDatepicker1.Value.Date);
                    updt.Parameters.AddWithValue("@sex", gender);
                    //updt.Parameters.AddWithValue("@functie", bunifuDropdown2.selectedValue);
                    updt.Parameters.AddWithValue("@desc", richTextBox1.Text);
                    updt.Parameters.AddWithValue("@functie", b6.Text);
                    updt.Parameters.AddWithValue("@telefon", b7.Text);

                    updt.Parameters.AddWithValue("@img", a);
                    updt.Parameters.AddWithValue("@EMAIL", loginform.Email);

                    con.Open();
                    updt.ExecuteNonQuery();
                    con.Close();
                   

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }

            }
        }

            
        
        private void addimagebutton_Click(object sender, EventArgs e) //add profile image button
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "JPG(*JPG)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";
            //DialogResult f2 = f.ShowDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {

                File = Image.FromFile(f.FileName);
                profilepictureedit.Image = File;

            }                   
        }
        
        private void bunifuFlatButton1_Click(object sender, EventArgs e) //my profile button
        {
            b1.Visible = false;
            b2.Visible = false;
            b3.Visible = false;
            b4.Visible = false;
            b5.Visible = false;
            b6.Visible = false;
            b7.Visible = false;
            richTextBox1.ReadOnly = true;
            addimagebutton.Visible = false;
            editbutton.Visible = false;
            firstname.Visible = true;
            lastname.Visible = true;
            adress.Visible = true;
            birthday.Visible = true;
            sex.Visible = true;
            functionss.Visible = true;
            label22.Visible = false;

            functionss.Text = b6.Text;
            telephone.Text = b7.ToString();
            
            

        }
        string stringcon = System.Configuration.ConfigurationManager.ConnectionStrings["residenceBDcon"].ConnectionString;
        SqlCommand updt = new SqlCommand();
        SqlCommand cmd1 = new SqlCommand();


        private void bunifuFlatButton2_Click(object sender, EventArgs e) //edit button
        {
            b1.Visible = true;
            b2.Visible = true;
            b3.Visible = true;
            b4.Visible = true;
            b5.Visible = true;
            b6.Visible = true;
            b7.Visible = true;
            richTextBox1.ReadOnly = false;
            addimagebutton.Visible = true;
            editbutton.Visible = true;
            firstname.Visible = false;
            lastname.Visible = false;
            adress.Visible = false;
            birthday.Visible = false;
            sex.Visible = false;
            functionss.Visible = false;
            telephone.Visible = false;
            label22.Visible = true;


             SqlConnection con = new SqlConnection(stringcon);

            SqlCommand cmd = new SqlCommand("select * from echipa where email=@EMAIL", con);
            cmd.Parameters.AddWithValue("@EMAIL", loginform.Email);

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            foreach(DataRow dr in dt.Rows)
            {

                functionss.Text = funtie;

                b1.Text = dr["nume"].ToString();
                b2.Text = dr["prenume"].ToString();
                b3.Text = dr["adresa"].ToString();
                richTextBox1.Text = dr["descriere"].ToString();
                b5.Text = dr["sex"].ToString();
                b6.Text = dr["functie"].ToString();
                b7.Text = dr["telefon"].ToString();

                //bunifuDropdown2.Text = dr["descriere"].ToString();
                
            }





            con.Close();



        }



        string gender, funtie;

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Feminin";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           gender = "Masculin";
        }

        private void b1_OnValueChanged(object sender, EventArgs e)
        {

        }
        private void blackscreen()
        {
            popupbackforechpass blackscreen = new popupbackforechpass();
            blackscreen.Show();
        }
        public bool justonetime = true;
        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            if (justonetime == true)
            {
                //popupbackfore blackscreen = new popupbackfore();
                ChangePassword chpass = new ChangePassword(); //go to login form
                //blackscreen.Show();
                blackscreen();
                chpass.ShowDialog(); //show login form
                chpass.Focus();

                justonetime = false;
            }
            else
            {
                bunifuCustomLabel6.Visible = true;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            label22.Text = "Caractere rămase: " + (200 - richTextBox1.Text.Length).ToString();
        }
        
        


        //private void loadpicture()
        //{

        //}

        private void myprofil_component_Load(object sender, EventArgs e)
        {
           

            SqlConnection con = new SqlConnection(stringcon);
            SqlCommand cmd = new SqlCommand("select nume from echipa where email=@EMAIL", con);
            SqlCommand cmd2 = new SqlCommand("select prenume from echipa where email=@EMAIL", con);
            SqlCommand cmd3 = new SqlCommand("select adresa from echipa where email=@EMAIL", con);
            SqlCommand cmd4 = new SqlCommand("select data_nasterii from echipa where email=@EMAIL", con);
            SqlCommand cmd5 = new SqlCommand("select functie from echipa where email=@EMAIL", con);
            SqlCommand cmd6 = new SqlCommand("select descriere from echipa where email=@EMAIL", con);
            SqlCommand cmd7 = new SqlCommand("select sex from echipa where email=@EMAIL", con);

            SqlCommand cmd8 = new SqlCommand("select poza from echipa where email=@EMAIL", con);
            SqlCommand cmd9 = new SqlCommand("select telefon from echipa where email=@EMAIL", con);


            cmd.Parameters.AddWithValue("@EMAIL", loginform.Email);
            cmd2.Parameters.AddWithValue("@EMAIL", loginform.Email);
            cmd3.Parameters.AddWithValue("@EMAIL", loginform.Email);
            cmd4.Parameters.AddWithValue("@EMAIL", loginform.Email);
            cmd5.Parameters.AddWithValue("@EMAIL", loginform.Email);
            cmd6.Parameters.AddWithValue("@EMAIL", loginform.Email);
            cmd7.Parameters.AddWithValue("@EMAIL", loginform.Email);
            cmd8.Parameters.AddWithValue("@EMAIL", loginform.Email);
            cmd9.Parameters.AddWithValue("@EMAIL", loginform.Email);



            // SqlDataAdapter dt = new SqlDataAdapter(cmd);
            SqlDataAdapter dt = new SqlDataAdapter(cmd8);

            DataSet ds = new DataSet();
            dt.Fill(ds);
            con.Open();

            Object temp = cmd.ExecuteScalar();
            firstname.Text = temp.ToString();

            Object temp2 = cmd2.ExecuteScalar();
            lastname.Text = temp2.ToString();

            Object temp3 = cmd3.ExecuteScalar();
            adress.Text = temp3.ToString();


            Object temp4 = cmd4.ExecuteScalar();
            DateTime d = DateTime.Parse(temp4.ToString());

            birthday.Text = d.ToString("dd-MMM-yyyy");

            Object temp5 = cmd5.ExecuteScalar();
            functionss.Text = temp5.ToString();

            Object temp6 = cmd6.ExecuteScalar();
            richTextBox1.Text = temp6.ToString();

            Object temp7 = cmd7.ExecuteScalar();
            sex.Text = temp7.ToString();

            Object temp8 = cmd9.ExecuteScalar();
            telephone.Text = temp8.ToString();



            con.Close();

            byte[] ap = (byte[])ds.Tables[0].Rows[0]["poza"];
            MemoryStream ms = new MemoryStream(ap);
            profilepictureedit.Image = Image.FromStream(ms);


           

        }
    }
}
