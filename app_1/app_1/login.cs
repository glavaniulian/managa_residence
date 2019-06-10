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

namespace app_1
{
    public partial class loginform : Form
        
    {
        public static class GlobalVariables //class for globalvariables
        {
          //  public static string Email=""; //public static string for username because we need for use in another form
            public static string Password=""; //public static string because i don't know, i think for database :))
             
        }


        public static string Email = "";
        public int countererrorseconds = 0;
        public loginform()
        {
            InitializeComponent(); //initialize form1 component
            //this.ActiveControl = bunifuMaterialTextbox1;
            //bunifuMaterialTextbox1.Focus();

            
            
        }

        private void button1_Click(object sender, EventArgs e) // button 'X' top form
        {
            Application.Exit(); //this app close
        }

        private void button2_Click(object sender, EventArgs e) // button '_' top form
        {
            WindowState = FormWindowState.Minimized; // ths app minimized
        }
        
        private void loginloginlogin()
        {
            
            try
            {

                if (bunifuMaterialTextbox1.Text == string.Empty && bunifuMaterialTextbox2.Text == string.Empty)
                {
                    
                    bunifuCustomLabel8.Visible = true;
                    bunifuCustomLabel6.Visible = true;
                    bunifuCustomLabel7.Visible = true;
                    timer1.Start();


                }
                else
                {

                    //bunifuCircleProgressbar1.Visible = true;
                    string stringcon = System.Configuration.ConfigurationManager.ConnectionStrings["residenceBDcon"].ConnectionString;
                    SqlConnection con = new SqlConnection(stringcon);
                    SqlCommand cmd = new SqlCommand("select * from echipa where email=@LEMAIL and parola=@LPAROLA", con);
                    cmd.Parameters.AddWithValue("@LEMAIL", bunifuMaterialTextbox1.Text);
                    cmd.Parameters.AddWithValue("@LPAROLA", bunifuMaterialTextbox2.Text);


                    Email = bunifuMaterialTextbox1.Text;


                    SqlDataAdapter dt = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    dt.Fill(ds);



                    int count = ds.Tables[0].Rows.Count;
                    if (count == 1)
                    {
                        bunifuCircleProgressbar1.Visible = true;
                        dashboard dash = new dashboard(); //next to app form 
                        dash = new dashboard();
                        dash.Show(); //show app form
                        this.Hide(); //login form hide
                        //bunifuCircleProgressbar1.Visible = false;


                    }
                    else
                    {
                        
                        bunifuCustomLabel8.Visible = true;
                        bunifuCustomLabel6.Visible = true;
                        bunifuCustomLabel7.Visible = true;
                        bunifuCircleProgressbar1.Visible = false;
                        timer1.Start();
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void bunifuFlatButton1_Click(object sender, EventArgs e) //login button
        {

            //afecteaza logarea!!
            //bunifuMaterialTextbox1.Text = GlobalVariables.Email.ToString(); //read variable Email in textbox
            //bunifuMaterialTextbox2.Text = GlobalVariables.Password.ToString(); //read variable password in textbox


            // check if Email and Password it's ok and go in another form


            loginloginlogin();
           



            

            //if (GlobalVariables.Email == "" && GlobalVariables.Password == "") //if is true next to app form
            //{
                
            //    dashboard dash = new dashboard(); //next to app form 
            //    dash = new dashboard();
            //    dash.Show(); //show app form
            //    this.Hide(); //login form hide
                
                    
                
            //}
            //else //if is not true show error message
            //{
            //    bunifuCustomLabel6.Visible = true;
            //    bunifuCustomLabel7.Visible = true;
            //    bunifuCustomLabel8.Visible = true;
            //}
            
        }
       
        private void bunifuMaterialTextbox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                bunifuMaterialTextbox2.Focus();
            }
        }

        private void bunifuMaterialTextbox2_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                loginloginlogin();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            countererrorseconds = countererrorseconds + 100;
            if (countererrorseconds == 4000)
            {
                bunifuCustomLabel8.Visible = false;
                bunifuCustomLabel6.Visible = false;
                bunifuCustomLabel7.Visible = false;
                timer1.Stop();
                countererrorseconds = 0;

            }
            else
                return;
            

            
        }
    }
}
