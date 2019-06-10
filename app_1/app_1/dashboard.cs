using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
namespace app_1
{
    
    public partial class dashboard : Form
    {

        
        public dashboard()
        {

            InitializeComponent();
            {
                
                this.projecttable.ScrollBars = ScrollBars.None;
                this.projecttable.MouseWheel += new MouseEventHandler(projecttable_mousewheel);
                this.memberstable.ScrollBars = ScrollBars.None;
                this.memberstable.MouseWheel += new MouseEventHandler(memberstable_mousewheel);
                this.propertiestable.ScrollBars = ScrollBars.None;
                this.propertiestable.MouseWheel += new MouseEventHandler(propertiestable_mousewheel);
                this.clientstabel.ScrollBars = ScrollBars.None;
                this.clientstabel.MouseWheel += new MouseEventHandler(clientstabel_mousewheel);
                this.clientstable2.ScrollBars = ScrollBars.None;
                this.clientstable2.MouseWheel += new MouseEventHandler(clientstable2_mousewheel);

                pictureBox2.Visible = true; pictureBox3.Visible = true; pictureBox4.Visible = true;
                pictureBox5.Visible = true; pictureBox1.Visible = true; label1.Visible = true; label2.Visible = true;

                functionagent.Visible = false; telephoneagent.Visible = false; adressagent.Visible = false; agentnameagent.Visible = false; cityproject.Visible = false; agentnamefilter.Visible = false; projectnamefilter.Visible = false; minpriceinterval.Visible = false;
                maxpriceinterval.Visible = false; pricelabel.Visible = false; priceinterval.Visible = false; propertiestype.Visible = false; projectnameproperties.Visible = false; infolabel1.Visible = false; clientsprovide.Visible = false;
                CNP.Visible = false; telephone.Visible = false; clientname.Visible = false; IDagent.Visible = false; IDproject.Visible = false; IDproperties.Visible = false; IDclient.Visible = false; logocompany.Visible = true;
                companyname.Visible = true; welcomeface.Visible = true; membername.Visible = true; weeklystatistics.Visible = true; weeklystatisticslabel.Visible = true; clientspicture.Visible = true; propertyespicture.Visible = true;
                projectpicture.Visible = true; pin1.Visible = true; pin2.Visible = true; pin3.Visible = true; pin4.Visible = true; pin5.Visible = true; pin6.Visible = true; pin7.Visible = true; clientslabel.Visible = true;
                propertyeslabel.Visible = true; projectlabel.Visible = true; addlabel1.Visible = true; addlabel2.Visible = true; addlabel3.Visible = true; addlabel4.Visible = true; addlabel5.Visible = true; addlabel6.Visible = true; addlabel7.Visible = true;
                addnumberclients.Visible = true; neglectedclients.Visible = true; contactedclients.Visible = true; numberofaddproperties.Visible = true; numberofsellproperties.Visible = true; numberofdisponibilityproperties.Visible = true;
                numberofaddprojects.Visible = true;clientstabel.Visible = false;clientstable2.Visible = false;addnewclient.Visible = false;propertiestable.Visible = false;addnewproperties.Visible = false;projecttable.Visible = false;addnewproject.Visible = false;
                tabelstatisticslabel.Visible = false; apartmentsstatisticlabel.Visible = false;clientsstatisticlabel.Visible = false;clientscomesstatisticlabel.Visible = false;financialstatisticlabel.Visible = false;
                statistic1.Visible = false; statistic2.Visible = false; statistic3.Visible = false; statistic4.Visible = false;memberstable.Visible = false;coomingsoonlabel.Visible = false;slidebaritem.Text = "Dashboard";slidebaritem.Visible = true;bunifuCustomLabel2.Visible = false;bunifuCustomLabel4.Visible = false; infolabel.Visible = false;
            }
            //profilepicture.Image = //here take picture from database
            popuplogout.SetToolTip(logoutbutton, "Deloghează-te.");//tooltrip for logout button when mouse hover on him(500ms)
            
            //#################################################################################################################
            //here need to take value from database(labelname.text= value from db)


            //#################################################################################################################
            /* if (!container.Controls.Contains(dashboard_component.Instance))
             {
                 container.Controls.Add(dashboard_component.Instance);
                 dashboard_component.Instance.Dock = DockStyle.Fill;
                 dashboard_component.Instance.BringToFront();
                 slidebaritem.Text = "Dashboard";

             }
             else
             {
                 dashboard_component.Instance.BringToFront();
                 slidebaritem.Text = "Dashboard";

             }*/
            //##################################################################################################################
        }

        public void sqlconn()
        {
            
        }


        private void button1_Click(object sender, EventArgs e) //this close all form and exit environment
            
        {
            Application.Exit(); // close entire aplication
        }

        private void button2_Click(object sender, EventArgs e) //this minimize app form
        {
            WindowState = FormWindowState.Minimized; //minimize dashboard form
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e) //this logout from the application
        {
            loginform logout = new loginform(); //go to login form
            logout.Show(); //show login form
            this.Hide(); //hide app form
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e) //dashboard panel button
        {
            pictureBox2.Visible = true; pictureBox3.Visible = true; pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox1.Visible = true; label1.Visible = true; label2.Visible = true;
            functionagent.Visible = false;telephoneagent.Visible = false;adressagent.Visible = false;agentnameagent.Visible = false;cityproject.Visible = false;agentnamefilter.Visible = false;projectnamefilter.Visible = false;minpriceinterval.Visible = false;
            maxpriceinterval.Visible = false;pricelabel.Visible = false;priceinterval.Visible = false;floor.Visible = false;propertiestype.Visible = false;projectnameproperties.Visible = false;infolabel1.Visible = false; clientsprovide.Visible = false;
            CNP.Visible = false; telephone.Visible = false; clientname.Visible = false;IDagent.Visible = false;IDproject.Visible = false;IDproperties.Visible = false;IDclient.Visible = false;logocompany.Visible = true;companyname.Visible = true;
            welcomeface.Visible = true; membername.Visible  = true;weeklystatistics.Visible = true;weeklystatisticslabel.Visible = true;clientspicture.Visible = true;propertyespicture.Visible = true;projectpicture.Visible = true;
            pin1.Visible = true; pin2.Visible = true; pin3.Visible = true; pin4.Visible = true; pin5.Visible = true; pin6.Visible = true; pin7.Visible = true;clientslabel.Visible = true;propertyeslabel.Visible = true;projectlabel.Visible = true;
            addlabel1.Visible = true; addlabel2.Visible = true; addlabel3.Visible = true; addlabel4.Visible = true; addlabel5.Visible = true; addlabel6.Visible = true; addlabel7.Visible = true;addnumberclients.Visible = true;
            neglectedclients.Visible = true;contactedclients.Visible = true;numberofaddproperties.Visible = true;numberofsellproperties.Visible = true;numberofdisponibilityproperties.Visible = true;numberofaddprojects.Visible = true;clientstabel.Visible = false;clientstable2.Visible = false;
            addnewclient.Visible = false;propertiestable.Visible = false;addnewproperties.Visible = false;projecttable.Visible = false;addnewproject.Visible = false;tabelstatisticslabel.Visible = false;apartmentsstatisticlabel.Visible = false; clientsstatisticlabel.Visible = false;clientscomesstatisticlabel.Visible = false;
            financialstatisticlabel.Visible = false;statistic1.Visible = false; statistic2.Visible = false; statistic3.Visible = false; statistic4.Visible = false;memberstable.Visible = false;coomingsoonlabel.Visible = false;
            slidebaritem.Text = "Dashboard";slidebaritem.Visible = true;bunifuCustomLabel2.Visible = false;bunifuCustomLabel4.Visible = false;infolabel.Visible = false;
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e) //clients panel button
        {
            pictureBox2.Visible = false; pictureBox3.Visible = false; pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox1.Visible = false; label1.Visible = false; label2.Visible = false;

            functionagent.Visible = false;
            telephoneagent.Visible = false;
            adressagent.Visible = false;
            agentnameagent.Visible = false;
            cityproject.Visible = false;
            agentnamefilter.Visible = false;
            projectnamefilter.Visible = false;
            minpriceinterval.Visible = false;
            maxpriceinterval.Visible = false;
            pricelabel.Visible = false;
            priceinterval.Visible = false;
            floor.Visible = false;
            propertiestype.Visible = false;
            projectnameproperties.Visible = false;
            infolabel1.Visible = true;
            clientsprovide.Visible = true;
            CNP.Visible = true;
            telephone.Visible = true;
            clientname.Visible = true;
            IDagent.Visible = false;
            IDagent.Visible = false;
            IDproject.Visible = false;
            IDproperties.Visible = false;
            IDclient.Visible = true;
            logocompany.Visible = false;
            companyname.Visible = false;
            welcomeface.Visible = false;
            membername.Visible = false;
            weeklystatistics.Visible = false;
            weeklystatisticslabel.Visible = false;
            clientspicture.Visible = false;
            propertyespicture.Visible = false;
            projectpicture.Visible = false;
            pin1.Visible = false; pin2.Visible = false; pin3.Visible = false; pin4.Visible = false; pin5.Visible = false; pin6.Visible = false; pin7.Visible = false;
            clientslabel.Visible = false;
            propertyeslabel.Visible = false;
            projectlabel.Visible = false;
            addlabel1.Visible = false; addlabel2.Visible = false; addlabel3.Visible = false; addlabel4.Visible = false; addlabel5.Visible = false; addlabel6.Visible = false; addlabel7.Visible = false;
            addnumberclients.Visible = false;
            neglectedclients.Visible = false;
            contactedclients.Visible = false;
            numberofaddproperties.Visible = false;
            numberofsellproperties.Visible = false;
            numberofdisponibilityproperties.Visible = false;
            numberofaddprojects.Visible = false;
            clientstabel.Visible = true;
            clientstable2.Visible = true;
            addnewclient.Visible = true;
            propertiestable.Visible = false;
            addnewproperties.Visible = false;
            projecttable.Visible = false;
            addnewproject.Visible = false;
            tabelstatisticslabel.Visible = false;
            apartmentsstatisticlabel.Visible = false;
            clientsstatisticlabel.Visible = false;
            clientscomesstatisticlabel.Visible = false;
            financialstatisticlabel.Visible = false;
            statistic1.Visible = false; statistic2.Visible = false; statistic3.Visible = false; statistic4.Visible = false;
            memberstable.Visible = false;
            coomingsoonlabel.Visible = false;
            slidebaritem.Text = "Clienți";
            slidebaritem.Visible = true;
            bunifuCustomLabel2.Visible = true;
            bunifuCustomLabel4.Visible = true;
            infolabel.Visible = true;


        }
        private void bunifuFlatButton3_Click(object sender, EventArgs e) // properties panel button
        {
            pictureBox2.Visible = false; pictureBox3.Visible = false; pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox1.Visible = false; label1.Visible = false; label2.Visible = false;

            functionagent.Visible = false;
            telephoneagent.Visible = false;
            adressagent.Visible = false;
            agentnameagent.Visible = false;
            cityproject.Visible = false;
            agentnamefilter.Visible = false;
            projectnamefilter.Visible = false;
            minpriceinterval.Visible = true;
            maxpriceinterval.Visible = true;
            pricelabel.Visible = true;
            priceinterval.Visible = true;
            floor.Visible = true;
            propertiestype.Visible = true;
            projectnameproperties.Visible = true;
            infolabel1.Visible = true;
            clientsprovide.Visible = false;
            CNP.Visible = false;
            telephone.Visible = false;
            clientname.Visible = false;
            IDagent.Visible = false;
            IDproject.Visible = false;
            IDproperties.Visible = true;
            IDclient.Visible = false;
            logocompany.Visible = false;
            companyname.Visible = false;
            welcomeface.Visible = false;
            membername.Visible = false;
            weeklystatistics.Visible = false;
            weeklystatisticslabel.Visible = false;
            clientspicture.Visible = false;
            propertyespicture.Visible = false;
            projectpicture.Visible = false;
            pin1.Visible = false; pin2.Visible = false; pin3.Visible = false; pin4.Visible = false; pin5.Visible = false; pin6.Visible = false; pin7.Visible = false;
            clientslabel.Visible = false;
            clientstable2.Visible = false;
            propertyeslabel.Visible = false;
            projectlabel.Visible = false;
            addlabel1.Visible = false; addlabel2.Visible = false; addlabel3.Visible = false; addlabel4.Visible = false; addlabel5.Visible = false; addlabel6.Visible = false; addlabel7.Visible = false;
            addnumberclients.Visible = false;
            neglectedclients.Visible = false;
            contactedclients.Visible = false;
            numberofaddproperties.Visible = false;
            numberofsellproperties.Visible = false;
            numberofdisponibilityproperties.Visible = false;
            numberofaddprojects.Visible = false;
            clientstabel.Visible = false;
            addnewclient.Visible = false;
            propertiestable.Visible = true;
            addnewproperties.Visible = true;
            projecttable.Visible = false;
            addnewproject.Visible = false;
            tabelstatisticslabel.Visible = false;
            apartmentsstatisticlabel.Visible = false;
            clientsstatisticlabel.Visible = false;
            clientscomesstatisticlabel.Visible = false;
            financialstatisticlabel.Visible = false;
            statistic1.Visible = false; statistic2.Visible = false; statistic3.Visible = false; statistic4.Visible = false;
            memberstable.Visible = false;
            coomingsoonlabel.Visible = false;
            slidebaritem.Text = "Proprietăți";
            slidebaritem.Visible = true;
            bunifuCustomLabel2.Visible = false;
            bunifuCustomLabel4.Visible = false;
            infolabel.Visible = true;
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e) //projects panel button
        {
            pictureBox2.Visible = false; pictureBox3.Visible = false; pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox1.Visible = false; label1.Visible = false; label2.Visible = false;

            functionagent.Visible = false;
            telephoneagent.Visible = false;
            adressagent.Visible = false;
            agentnameagent.Visible = false;
            cityproject.Visible = true;
            agentnamefilter.Visible = true;
            projectnamefilter.Visible = true;
            minpriceinterval.Visible = false;
            maxpriceinterval.Visible = false;
            pricelabel.Visible = false;
            priceinterval.Visible = false;
            floor.Visible = false;
            propertiestype.Visible = false;
            projectnameproperties.Visible = false;
            infolabel1.Visible = true;
            clientsprovide.Visible = false;
            CNP.Visible = false;
            telephone.Visible = false;
            clientname.Visible = false;
            IDagent.Visible = false;
            IDproject.Visible = true;
            IDproperties.Visible = false;
            IDclient.Visible = false;
            coomingsoonlabel.Visible = false;
            apartmentsstatisticlabel.Visible = false;
            clientsstatisticlabel.Visible = false;
            clientscomesstatisticlabel.Visible = false;
            financialstatisticlabel.Visible = false;
            statistic1.Visible = false; statistic2.Visible = false; statistic3.Visible = false; statistic4.Visible = false;
            bunifuCustomLabel4.Visible = false;
            logocompany.Visible = false;
            companyname.Visible = false;
            welcomeface.Visible = false;
            membername.Visible = false;
            weeklystatistics.Visible = false;
            weeklystatisticslabel.Visible = false;
            clientspicture.Visible = false;
            propertyespicture.Visible = false;
            projectpicture.Visible = false;
            pin1.Visible = false; pin2.Visible = false; pin3.Visible = false; pin4.Visible = false; pin5.Visible = false; pin6.Visible = false; pin7.Visible = false;
            clientslabel.Visible = false;
            clientstable2.Visible = false;
            propertyeslabel.Visible = false;
            projectlabel.Visible = false;
            addlabel1.Visible = false; addlabel2.Visible = false; addlabel3.Visible = false; addlabel4.Visible = false; addlabel5.Visible = false; addlabel6.Visible = false; addlabel7.Visible = false;
            addnumberclients.Visible = false;
            neglectedclients.Visible = false;
            contactedclients.Visible = false;
            numberofaddproperties.Visible = false;
            numberofsellproperties.Visible = false;
            numberofdisponibilityproperties.Visible = false;
            numberofaddprojects.Visible = false;
            clientstabel.Visible = false;
            addnewclient.Visible = false;
            propertiestable.Visible = false;
            addnewproperties.Visible = false;
            projecttable.Visible = true;
            addnewproject.Visible = true;
            tabelstatisticslabel.Visible = false; 
            memberstable.Visible = false;           
            slidebaritem.Text = "Proiecte";
            slidebaritem.Visible = true;
            bunifuCustomLabel2.Visible = false;            
            infolabel.Visible = true;
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e) //statistics panel button
        {
            pictureBox2.Visible = false; pictureBox3.Visible = false; pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox1.Visible = false; label1.Visible = false; label2.Visible = false;

            functionagent.Visible = false;
            telephoneagent.Visible = false;
            adressagent.Visible = false;
            agentnameagent.Visible = false;
            cityproject.Visible = false;
            agentnamefilter.Visible = false;
            projectnamefilter.Visible = false;
            minpriceinterval.Visible = false;
            maxpriceinterval.Visible = false;
            pricelabel.Visible = false;
            priceinterval.Visible = false;
            floor.Visible = false;
            propertiestype.Visible = false;
            projectnameproperties.Visible = false;
            infolabel1.Visible = false;
            clientsprovide.Visible = false;
            CNP.Visible = false;
            telephone.Visible = false;
            clientname.Visible = false;
            IDagent.Visible = false;
            IDproject.Visible = false;
            IDproperties.Visible = false;
            IDclient.Visible = false;
            logocompany.Visible = false;
            companyname.Visible = false;
            welcomeface.Visible = false;
            membername.Visible = false;
            weeklystatistics.Visible = false;
            weeklystatisticslabel.Visible = false;
            clientspicture.Visible = false;
            propertyespicture.Visible = false;
            projectpicture.Visible = false;
            pin1.Visible = false; pin2.Visible = false; pin3.Visible = false; pin4.Visible = false; pin5.Visible = false; pin6.Visible = false; pin7.Visible = false;
            clientslabel.Visible = false;
            clientstable2.Visible = false;
            propertyeslabel.Visible = false;
            projectlabel.Visible = false;
            addlabel1.Visible = false; addlabel2.Visible = false; addlabel3.Visible = false; addlabel4.Visible = false; addlabel5.Visible = false; addlabel6.Visible = false; addlabel7.Visible = false;
            addnumberclients.Visible = false;
            neglectedclients.Visible = false;
            contactedclients.Visible = false;
            numberofaddproperties.Visible = false;
            numberofsellproperties.Visible = false;
            numberofdisponibilityproperties.Visible = false;
            numberofaddprojects.Visible = false;
            clientstabel.Visible = false;
            addnewclient.Visible = false;
            propertiestable.Visible = false;
            addnewproperties.Visible = false;
            projecttable.Visible = false;
            addnewproject.Visible = false;
            tabelstatisticslabel.Visible = true;
            apartmentsstatisticlabel.Visible = true;
            clientsstatisticlabel.Visible = true;
            clientscomesstatisticlabel.Visible = true;
            financialstatisticlabel.Visible = true;
            statistic1.Visible = true; statistic2.Visible = true; statistic3.Visible = true; statistic4.Visible = true;
            memberstable.Visible = false;
            coomingsoonlabel.Visible = false;
            slidebaritem.Text = "Statistici";
            slidebaritem.Visible = true;
            bunifuCustomLabel2.Visible = false;
            bunifuCustomLabel4.Visible = false;
            infolabel.Visible = false;
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e) //team panel button
        {
            pictureBox2.Visible = false; pictureBox3.Visible = false; pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox1.Visible = false; label1.Visible = false; label2.Visible = false;

            functionagent.Visible = true;
            telephoneagent.Visible = true;
            adressagent.Visible = true;
            agentnameagent.Visible = true;
            cityproject.Visible = false;
            agentnamefilter.Visible = false;
            projectnamefilter.Visible = false;
            minpriceinterval.Visible = false;
            maxpriceinterval.Visible = false;
            pricelabel.Visible = false;
            priceinterval.Visible = false;
            floor.Visible = false;
            propertiestype.Visible = false;
            projectnameproperties.Visible = false;
            infolabel1.Visible = true;
            clientsprovide.Visible = false;
            CNP.Visible = false;
            telephone.Visible = false;
            clientname.Visible = false;
            IDagent.Visible = true;
            IDproject.Visible = false;
            IDproperties.Visible = false;
            IDclient.Visible = false;
            logocompany.Visible = false;
            companyname.Visible = false;
            welcomeface.Visible = false;
            membername.Visible = false;
            weeklystatistics.Visible = false;
            weeklystatisticslabel.Visible = false;
            clientspicture.Visible = false;
            propertyespicture.Visible = false;
            projectpicture.Visible = false;
            pin1.Visible = false; pin2.Visible = false; pin3.Visible = false; pin4.Visible = false; pin5.Visible = false; pin6.Visible = false; pin7.Visible = false;
            clientslabel.Visible = false;
            clientstable2.Visible = false;
            propertyeslabel.Visible = false;
            projectlabel.Visible = false;
            addlabel1.Visible = false; addlabel2.Visible = false; addlabel3.Visible = false; addlabel4.Visible = false; addlabel5.Visible = false; addlabel6.Visible = false; addlabel7.Visible = false;
            addnumberclients.Visible = false;
            neglectedclients.Visible = false;
            contactedclients.Visible = false;
            numberofaddproperties.Visible = false;
            numberofsellproperties.Visible = false;
            numberofdisponibilityproperties.Visible = false;
            numberofaddprojects.Visible = false;
            clientstabel.Visible = false;
            addnewclient.Visible = false;
            propertiestable.Visible = false;
            addnewproperties.Visible = false;
            projecttable.Visible = false;
            addnewproject.Visible = false;
            tabelstatisticslabel.Visible = false;
            apartmentsstatisticlabel.Visible = false;
            clientsstatisticlabel.Visible = false;
            clientscomesstatisticlabel.Visible = false;
            financialstatisticlabel.Visible = false;
            statistic1.Visible = false; statistic2.Visible = false; statistic3.Visible = false; statistic4.Visible = false;
            memberstable.Visible = true;

            coomingsoonlabel.Visible = false;
            slidebaritem.Text = "Echipă";
            slidebaritem.Visible = true;
            bunifuCustomLabel2.Visible = false;
            bunifuCustomLabel4.Visible = false;
            infolabel.Visible = true;
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e) //website panel button
        {
            pictureBox2.Visible = false; pictureBox3.Visible = false; pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox1.Visible = false; label1.Visible = false; label2.Visible = false;

            cityproject.Visible = false;
            agentnamefilter.Visible = false;
            projectnamefilter.Visible = false;
            functionagent.Visible = false;
            telephoneagent.Visible = false;
            adressagent.Visible = false;
            agentnameagent.Visible = false;
            minpriceinterval.Visible = false;
            maxpriceinterval.Visible = false;
            pricelabel.Visible = false;
            priceinterval.Visible = false;
            floor.Visible = false;
            propertiestype.Visible = false;
            projectnameproperties.Visible = false;
            infolabel1.Visible = false;
            clientsprovide.Visible = false;
            CNP.Visible = false;
            telephone.Visible = false;
            clientname.Visible = false;
            IDagent.Visible = false;
            IDproject.Visible = false;
            IDproperties.Visible = false;
            IDclient.Visible = false;
            logocompany.Visible = false;
            companyname.Visible = false;
            welcomeface.Visible = false;
            membername.Visible = false;
            weeklystatistics.Visible = false;
            weeklystatisticslabel.Visible = false;
            clientspicture.Visible = false;
            propertyespicture.Visible = false;
            projectpicture.Visible = false;
            pin1.Visible = false; pin2.Visible = false; pin3.Visible = false; pin4.Visible = false; pin5.Visible = false; pin6.Visible = false; pin7.Visible = false;
            clientslabel.Visible = false;
            clientstable2.Visible = false;
            propertyeslabel.Visible = false;
            projectlabel.Visible = false;
            addlabel1.Visible = false; addlabel2.Visible = false; addlabel3.Visible = false; addlabel4.Visible = false; addlabel5.Visible = false; addlabel6.Visible = false; addlabel7.Visible = false;
            addnumberclients.Visible = false;
            neglectedclients.Visible = false;
            contactedclients.Visible = false;
            numberofaddproperties.Visible = false;
            numberofsellproperties.Visible = false;
            numberofdisponibilityproperties.Visible = false;
            numberofaddprojects.Visible = false;
            clientstabel.Visible = false;
            addnewclient.Visible = false;
            propertiestable.Visible = false;
            addnewproperties.Visible = false;
            projecttable.Visible = false;
            addnewproject.Visible = false;
            tabelstatisticslabel.Visible = false;
            apartmentsstatisticlabel.Visible = false;
            clientsstatisticlabel.Visible = false;
            clientscomesstatisticlabel.Visible = false;
            financialstatisticlabel.Visible = false;
            statistic1.Visible = false; statistic2.Visible = false; statistic3.Visible = false; statistic4.Visible = false;
            memberstable.Visible = false;
            coomingsoonlabel.Visible = true;
            slidebaritem.Text = "Website";
            slidebaritem.Visible = true;
            bunifuCustomLabel2.Visible = false;
            bunifuCustomLabel4.Visible = false;
            infolabel.Visible = false;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e) // myprofil_edit button
        {
            Myprofile myprofile = new Myprofile(); //go to login form
            myprofile.Show(); //show login form
            this.Hide(); //hide app form
        }

        private void addnewclient_Click(object sender, EventArgs e)
        {
            ClientAdd addnewclient = new ClientAdd(); //go to login form
            addnewclient.Show(); //show login form
            this.Hide(); //hide app form
        }

        private void addnewproperties_Click(object sender, EventArgs e)
        {
            PropertyAdd addnewproperty = new PropertyAdd(); //go to login form
            addnewproperty.Show(); //show login form
            this.Hide(); //hide app form
        }

        private void addnewproject_Click(object sender, EventArgs e)
        {
            ProjectAdd addnewproject = new ProjectAdd(); //go to login form
            addnewproject.Show(); //show login form
            this.Hide(); //hide app form

            
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            


            string agentname;// take this from database
            string agentpremane;// take this from database


            string stringcon = System.Configuration.ConfigurationManager.ConnectionStrings["residenceBDcon"].ConnectionString;
            SqlConnection con = new SqlConnection(stringcon);


            SqlCommand cmd = new SqlCommand("select poza from echipa where email=@EMAIL", con);
            SqlCommand cmd2 = new SqlCommand("select prenume from echipa where email=@EMAIL", con);
            SqlCommand cmd3 = new SqlCommand("select functie from echipa where email=@EMAIL", con);
            SqlCommand cmd4 = new SqlCommand("select nume from echipa where email=@EMAIL", con);
            SqlCommand cmd5 = new SqlCommand("select dezvoltator.nume from dezvoltator inner join echipa on echipa.id_dezvoltator=dezvoltator.id_dezvoltator where email=@email",con);
            SqlCommand cmd6 = new SqlCommand("select dezvoltator.logo from dezvoltator inner join echipa on echipa.id_dezvoltator=dezvoltator.id_dezvoltator where email=@email", con);

            

            cmd.Parameters.AddWithValue("@EMAIL", loginform.Email);
            cmd2.Parameters.AddWithValue("@EMAIL", loginform.Email);
            cmd3.Parameters.AddWithValue("@EMAIL", loginform.Email);
            cmd4.Parameters.AddWithValue("@EMAIL", loginform.Email);
            cmd5.Parameters.AddWithValue("@EMAIL", loginform.Email);
            cmd6.Parameters.AddWithValue("@EMAIL", loginform.Email);







            SqlDataAdapter dt = new SqlDataAdapter(cmd);
            SqlDataAdapter dt12 = new SqlDataAdapter(cmd6);
           
            DataSet ds = new DataSet();
            DataSet ds12 = new DataSet();

            dt.Fill(ds);
            dt12.Fill(ds12);

            con.Open();




            Object temp = cmd5.ExecuteScalar();
            companyname.Text = temp.ToString();



            Object temp_dash = cmd2.ExecuteScalar();
            agentfullnamevieww.Text = temp_dash.ToString();
            agentpremane = temp_dash.ToString();

            Object temp_dash1 = cmd4.ExecuteScalar();
            agentfullnamevieww.Text = temp_dash.ToString();
            agentname = temp_dash1.ToString();

            string agentfullname = agentname + " " + agentpremane;

            agentfullnamevieww.Text = agentfullname;
            membername.Text = "Bun venit " + agentfullname + " !";


            Object temp_dash2 = cmd3.ExecuteScalar();
            bunifuCustomLabel3.Text = temp_dash2.ToString();

           



            con.Close();
            byte[] ap = (byte[])ds.Tables[0].Rows[0]["poza"];
            MemoryStream ms = new MemoryStream(ap);
            profilepicture.Image = Image.FromStream(ms);

            byte[] ap1 = (byte[])ds12.Tables[0].Rows[0]["logo"];
            MemoryStream ms1 = new MemoryStream(ap1);
            logocompany.Image = Image.FromStream(ms1);


            //show datagridview columns
            con.Open();


            SqlCommand cmdread = new SqlCommand("Select id_echipa as ID,CONCAT(nume,' ',prenume)as[NUME AGENT],adresa as ADRESĂ,telefon as TELEFON,functie as FUNCȚIE,email as EMAIL,poza as PROFIL from echipa", con);
            cmdread.ExecuteNonQuery();
            DataTable dtt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmdread);
            da.Fill(dtt);
            memberstable.DataSource = dtt;

            con.Close();



            con.Open();
            SqlCommand cmdread1 = new SqlCommand("Select statut as[ ],id_client as ID,numeagent as [AGENT],CONCAT(nume,' ',prenume)as [CLIENT],email as EMAIL,telefon as TELEFON,CNP,temperamentclient AS [TEMPERAMENT] from clienti_fizici", con);
            cmdread1.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmdread1);
            sda.Fill(dt1);
            clientstabel.DataSource = dt1;           
            con.Close();

            con.Open();
            SqlCommand cmdread4 = new SqlCommand("Select statut as[ ],id as ID,numeagent as [AGENT],numecompanie AS COMPANIE,replegal as [CLIENT],telefoncompanie as TELEFON,emailcompanie as EMAIL,CNP,temperamentclient AS [TEMPERAMENT] from clienti_juridici", con);
            cmdread4.ExecuteNonQuery();
            DataTable dt4 = new DataTable();
            SqlDataAdapter sda4 = new SqlDataAdapter(cmdread4);
            sda4.Fill(dt4);
            clientstable2.DataSource = dt4;
            con.Close();

            con.Open();
            SqlCommand cmdread2 = new SqlCommand("Select id_proiecte AS ID,numeagent as [AGENT],numeproiect as [PROIECT],oras as ORAȘ,strada as STRADĂ,numaretajeimobil as [ETAJE IMOBIL],img1 as GALERIE from proiecte", con);
            cmdread2.ExecuteNonQuery();
            DataTable dt2 = new DataTable();
            SqlDataAdapter sda1 = new SqlDataAdapter(cmdread2);
            sda1.Fill(dt2);
            projecttable.DataSource = dt2;
            con.Close();

            con.Open();
            SqlCommand cmdread3 = new SqlCommand("Select id as ID,numeagent as [AGENT],numeproiect as [PROIECT],numeproprietate as [PROPRIETATE],CONCAT(pretlista,' ',moneda) as [PREȚ LISTĂ] ,tipproprietate as [TIP PROP.],etaj as [ETAJ],numarapartament as [NR. APT.],img1 as GALERIE from proprietati", con);
            cmdread3.ExecuteNonQuery();
            DataTable dt3 = new DataTable();
            SqlDataAdapter sda2 = new SqlDataAdapter(cmdread3);
            sda2.Fill(dt3);
            propertiestable.DataSource = dt3;
            con.Close();
            //_______________________________________________________________________________________________________________________________________

            try
            {

                


                con.Open();
                cmd.Connection = con;

                cmd.CommandText = "select * from proiecte";
                cmd.ExecuteNonQuery();
                DataTable dt7 = new DataTable();
                SqlDataAdapter da7 = new SqlDataAdapter(cmd);
                da7.Fill(dt7);
                foreach (DataRow dr in dt7.Rows)
                {

                    projectnameproperties.AddItem(dr["numeproiect"].ToString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }





            //numar clienti
            try
            {
                cmd.Connection = con;

                cmd.CommandText = "select COUNT(*) from clienti_fizici where numeagent = (select numeagent from echipa where email=@EMAIL2)";
                cmd.Parameters.AddWithValue("@EMAIL2", loginform.Email);     
                cmd.ExecuteNonQuery();
             
                Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
                addnumberclients.Text = Convert.ToString(count.ToString())+" clienți fizici.";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //Image img = Image.FromFile(@"F:\Recover CRUZER STICK\AICI FISIERE\app_1\bd\rosu.png");
            //byte[] arr;
            //using (MemoryStream ms0 = new MemoryStream())
            {
                img.Save(ms0, System.Drawing.Imaging.ImageFormat.Png);
                arr = ms0.ToArray();
            }
            try
            {
                cmd.Connection = con;

                cmd.CommandText = "select COUNT(*) from clienti_juridici where numeagent = (select numeagent from echipa where email=@EMAIL3)";
                cmd.Parameters.AddWithValue("@EMAIL3", loginform.Email);
                cmd.ExecuteNonQuery();

                Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
                label1.Text = Convert.ToString(count.ToString())+" clienți juridici.";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //numar neglijenti

            try
            {
                cmd.Connection = con;

                cmd.CommandText = "Select count(*)+(select count(*) from clienti_juridici where clienti_fizici.c_n = clienti_juridici.c_n) as 'Total',clienti_fizici.c_n As 'nnn' from clienti_fizici where c_n = 'Necontactat' group by clienti_fizici.c_n";
                
              
                cmd.ExecuteNonQuery();

                Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
                neglectedclients.Text = Convert.ToString(count.ToString()) + " clienți fizici necontactati.";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                cmd.Connection = con;

                cmd.CommandText = "Select count(*)+(select count(*) from clienti_juridici where clienti_fizici.c_n = clienti_juridici.c_n) as 'Total',clienti_fizici.c_n As 'nnn' from clienti_fizici where c_n = 'Contactat' group by clienti_fizici.c_n";


                cmd.ExecuteNonQuery();

                Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
                contactedclients.Text = Convert.ToString(count.ToString()) + " clienți fizici contactati.";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //numar proiecte adaugate
            try
            {
               
                cmd.Connection = con;

                cmd.CommandText = "select COUNT(*) from proiecte where numeagent = (select numeagent from echipa where email=@EMAIL4)";
                cmd.Parameters.AddWithValue("@EMAIL4", loginform.Email);

                cmd.ExecuteNonQuery();

                Int32 count = Convert.ToInt32(cmd.ExecuteScalar());


                numberofaddprojects.Text = Convert.ToString(count.ToString()+" proiecte.");
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //proprietati

            try
            {
                
                cmd.Connection = con;

                cmd.CommandText = "select COUNT(*) from proprietati where numeagent = (select numeagent from echipa where email=@EMAIL5)";
                cmd.Parameters.AddWithValue("@EMAIL5", loginform.Email);

                cmd.ExecuteNonQuery();

                Int32 count = Convert.ToInt32(cmd.ExecuteScalar());


                numberofaddproperties.Text = Convert.ToString(count.ToString()+" proprietăți.");
            

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            //chart

            loaddata();

            //------- update procedure
            loadupdate();
           
            


        }
          

        private void timer1_Tick(object sender, EventArgs e)
        {
            string currenttime = DateTime.Now.ToLongTimeString();          
            string currentdate = DateTime.Now.ToLongDateString();
            dateandtime.Text = currenttime + " - " + currentdate;
        }
//--------------------------
        private void loadupdate()
        {
            string stringcon = System.Configuration.ConfigurationManager.ConnectionStrings["residenceBDcon"].ConnectionString;
            SqlConnection con = new SqlConnection(stringcon);

            SqlCommand cmd0 = new SqlCommand("update_necontactati", con);
            cmd0.CommandType = CommandType.StoredProcedure;
            SqlCommand cmd01 = new SqlCommand("update_necontactati_j", con);
            cmd01.CommandType = CommandType.StoredProcedure;
            
            SqlCommand cmd02 = new SqlCommand("update_nec", con);
            cmd02.CommandType = CommandType.StoredProcedure;
            SqlCommand cmd03 = new SqlCommand("update_nec2", con);
            cmd03.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd0.ExecuteNonQuery();
            cmd01.ExecuteNonQuery();
            cmd02.ExecuteNonQuery();
            cmd03.ExecuteNonQuery();

            con.Close();
        }

        private void loaddata()
        {
            try
            {
                statistic4.DataSource = GetData();
                statistic4.Series["Series1"].XValueMember = "Provenienta";
                statistic4.Series["Series1"].YValueMembers = "Total";

                statistic1.DataSource = GetData2();
                statistic1.Series["Series1"].XValueMember = "Proprietate";
                statistic1.Series["Series1"].YValueMembers = "Total";

                statistic3.DataSource = GetData3();
                statistic3.Series["Series1"].XValueMember = "POP";
                statistic3.Series["Series1"].YValueMembers = "Total";
            }
            catch(Exception ex)
            {

            }
        }

        private  DataTable GetData()
        {
            DataTable dt2 = new DataTable();
            DataTable dt3 = new DataTable();


            string stringcon = System.Configuration.ConfigurationManager.ConnectionStrings["residenceBDcon"].ConnectionString;
            SqlConnection con = new SqlConnection(stringcon);
            SqlCommand cmd2 = new SqlCommand("usp_chart", con);
            
            con.Open();
            SqlDataReader reader2 = cmd2.ExecuteReader();
            dt2.Load(reader2);


            return dt2;
         
        }
        private DataTable GetData2()
        {
            DataTable dt2 = new DataTable();
            DataTable dt3 = new DataTable();


            string stringcon = System.Configuration.ConfigurationManager.ConnectionStrings["residenceBDcon"].ConnectionString;
            SqlConnection con = new SqlConnection(stringcon);
            SqlCommand cmd2 = new SqlCommand("usp_chart2", con);

            con.Open();
            SqlDataReader reader2 = cmd2.ExecuteReader();
            dt2.Load(reader2);


            return dt2;

        }
        private DataTable GetData3()
        {
            DataTable dt2 = new DataTable();
            DataTable dt3 = new DataTable();


            string stringcon = System.Configuration.ConfigurationManager.ConnectionStrings["residenceBDcon"].ConnectionString;
            SqlConnection con = new SqlConnection(stringcon);
            SqlCommand cmd2 = new SqlCommand("char_s", con);

            con.Open();
            SqlDataReader reader2 = cmd2.ExecuteReader();
            dt2.Load(reader2);


            return dt2;

        }

        //-----------------------------
        private void memberstable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            agentinterogate ag = new agentinterogate();
            this.Hide();

            


            int id;
            id = Convert.ToInt32(memberstable.Rows[e.RowIndex].Cells["id"].Value.ToString());

            string stringcon = System.Configuration.ConfigurationManager.ConnectionStrings["residenceBDcon"].ConnectionString;
            SqlConnection con = new SqlConnection(stringcon);
            con.Open();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandText = "select * from echipa where id_echipa=" + id + "";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da1.Fill(ds);
            da.Fill(dt);

            


            foreach (DataRow dr in dt.Rows)
            {
                ag.label6.Text = dr["nume"].ToString();
                ag.label3.Text = dr["prenume"].ToString();
                ag.label5.Text = dr["adresa"].ToString();
                ag.label8.Text = Convert.ToDateTime(dr["data_nasterii"]).ToString("dd-mm-yyyy");
                ag.label11.Text = dr["sex"].ToString();
                ag.label33.Text = dr["email"].ToString();
                ag.label13.Text = dr["telefon"].ToString();
                ag.label36.Text = dr["functie"].ToString();
                ag.label15.Text = dr["descriere"].ToString();

                byte[] ap = (byte[])ds.Tables[0].Rows[0]["poza"];
                MemoryStream ms = new MemoryStream(ap);
                ag.profilepictureagent.Image = Image.FromStream(ms);
            }
            con.Close();

            ag.ShowDialog();



           



        }
        private void projecttable_mousewheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0 && projecttable.FirstDisplayedScrollingRowIndex > 0)
            {
                projecttable.FirstDisplayedScrollingRowIndex--;
            }
            else if (e.Delta < 0)
            {
                projecttable.FirstDisplayedScrollingRowIndex++;
            }
        }
        private void propertiestable_mousewheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0 && propertiestable.FirstDisplayedScrollingRowIndex > 0)
            {
                propertiestable.FirstDisplayedScrollingRowIndex--;
            }
            else if (e.Delta < 0)
            {
                propertiestable.FirstDisplayedScrollingRowIndex++;
            }
        }
        private void memberstable_mousewheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0 && memberstable.FirstDisplayedScrollingRowIndex > 0)
            {
                memberstable.FirstDisplayedScrollingRowIndex--;
            }
            else if (e.Delta < 0)
            {
                memberstable.FirstDisplayedScrollingRowIndex++;
            }
        }
        private void clientstabel_mousewheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0 && clientstabel.FirstDisplayedScrollingRowIndex > 0)
            {
                clientstabel.FirstDisplayedScrollingRowIndex--;
            }
            else if (e.Delta < 0)
            {
                clientstabel.FirstDisplayedScrollingRowIndex++;
            }
        }
        private void clientstable2_mousewheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0 && clientstable2.FirstDisplayedScrollingRowIndex > 0)
            {
                clientstable2.FirstDisplayedScrollingRowIndex--;
            }
            else if (e.Delta < 0)
            {
                clientstable2.FirstDisplayedScrollingRowIndex++;
            }
        }

        private void projecttable_MouseHover(object sender, EventArgs e)
        {
            projecttable.Focus();
        }

        private void memberstable_MouseHover(object sender, EventArgs e)
        {
            memberstable.Focus();
        }

        private void propertiestable_MouseHover(object sender, EventArgs e)
        {
            propertiestable.Focus();
        }

        private void clientstabel_MouseHover(object sender, EventArgs e)
        {
            clientstabel.Focus();
        }

        private void clientstable2_MouseHover(object sender, EventArgs e)
        {
            clientstable2.Focus();
        }

        private void projecttable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            projectinterogate ag = new projectinterogate();
            this.Hide();

           

            int id;
            id = Convert.ToInt32(projecttable.Rows[e.RowIndex].Cells["id"].Value.ToString());

            string stringcon = System.Configuration.ConfigurationManager.ConnectionStrings["residenceBDcon"].ConnectionString;
            SqlConnection con = new SqlConnection(stringcon);
            con.Open();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandText = "select * from proiecte where id_proiecte=" + id + "";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            da.Fill(dt);


            



            foreach (DataRow dr in dt.Rows)
            {
                ag.label14.Text = dr["numeproiect"].ToString();
                ag.label15.Text = dr["judet"].ToString();
                ag.label22.Text = dr["oras"].ToString();
                ag.label21.Text = dr["strada"].ToString();
                ag.label18.Text = dr["data_ora"].ToString();
                ag.label17.Text = dr["numaretajeimobil"].ToString();
                ag.label16.Text = dr["clasaenergetica"].ToString();
                ag.label26.Text = dr["parcare"].ToString();
                ag.label25.Text = dr["mezanin"].ToString();
                ag.label24.Text = dr["demisol"].ToString();
                ag.label23.Text = dr["mansarda"].ToString();
                ag.label27.Text = dr["descriereproiect"].ToString();

                byte[] ap = (byte[])ds.Tables[0].Rows[0]["img1"];
                MemoryStream ms = new MemoryStream(ap);
                ag.pictureBox2.Image = Image.FromStream(ms);

                byte[] ap1 = (byte[])ds.Tables[0].Rows[0]["img2"];
                MemoryStream ms1 = new MemoryStream(ap1);
                ag.pictureBox1.Image = Image.FromStream(ms1);

                byte[] ap2 = (byte[])ds.Tables[0].Rows[0]["img3"];
                MemoryStream ms2 = new MemoryStream(ap2);
                ag.pictureBox3.Image = Image.FromStream(ms2);

                byte[] ap3 = (byte[])ds.Tables[0].Rows[0]["img4"];
                MemoryStream ms3 = new MemoryStream(ap3);
                ag.pictureBox4.Image = Image.FromStream(ms3);
            }
            con.Close();


            ag.Show();

        }
        public string coinsicon;
        private void propertiestable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            propertiesinterogate ag = new propertiesinterogate();
            this.Hide();

            int id;
            id = Convert.ToInt32(propertiestable.Rows[e.RowIndex].Cells["id"].Value.ToString());

            string stringcon = System.Configuration.ConfigurationManager.ConnectionStrings["residenceBDcon"].ConnectionString;
            SqlConnection con = new SqlConnection(stringcon);
            con.Open();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandText = "select * from proprietati where id=" + id + "";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            da.Fill(dt);






            foreach (DataRow dr in dt.Rows)
            {
                ag.label34.Text = dr["numeproiect"].ToString();
                ag.label33.Text = dr["numeproprietate"].ToString();               
                coinsicon = dr["moneda"].ToString();
                ag.label32.Text = dr["pretlista"].ToString() + " " + coinsicon;
                ag.label30.Text = dr["suprafatatotala"].ToString();
                ag.label31.Text = dr["clasaenergetica"].ToString();
                ag.label29.Text = dr["tipproprietate"].ToString();
                ag.label25.Text = dr["suprafatautila"].ToString();
                ag.label21.Text = dr["data_ora"].ToString();
                ag.label28.Text = dr["numarbai"].ToString();
                ag.label26.Text = dr["suprafataconstruita"].ToString();
                ag.label24.Text = dr["suprafatabalcon"].ToString();
                ag.label23.Text = dr["numarapartament"].ToString();
                ag.label35.Text = dr["etaj"].ToString();
                ag.label39.Text = dr["compartimente"].ToString();
                ag.label38.Text = dr["parcare"].ToString();
                ag.label37.Text = dr["utilitati"].ToString();
                ag.label36.Text = dr["finisaje"].ToString();
                ag.label27.Text = dr["descriere"].ToString();




                byte[] ap = (byte[])ds.Tables[0].Rows[0]["img1"];
                MemoryStream ms = new MemoryStream(ap);
                ag.pictureBox2.Image = Image.FromStream(ms);

                byte[] ap1 = (byte[])ds.Tables[0].Rows[0]["img2"];
                MemoryStream ms1 = new MemoryStream(ap1);
                ag.pictureBox3.Image = Image.FromStream(ms1);

                byte[] ap2 = (byte[])ds.Tables[0].Rows[0]["img3"];
                MemoryStream ms2 = new MemoryStream(ap2);
                ag.pictureBox4.Image = Image.FromStream(ms2);

               
            }
            con.Close();


            ag.Show();
        }

        private void clientstabel_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            customersphysical ag = new customersphysical();
            this.Hide();

            int id;
            id = Convert.ToInt32(clientstabel.Rows[e.RowIndex].Cells["ID"].Value.ToString());

            string stringcon = System.Configuration.ConfigurationManager.ConnectionStrings["residenceBDcon"].ConnectionString;
            SqlConnection con = new SqlConnection(stringcon);
            con.Open();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandText = "select * from clienti_fizici where id_client=" + id + "";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da1.Fill(ds);
            da.Fill(dt);




            foreach (DataRow dr in dt.Rows)
            {
                ag.label31.Text = dr["nume"].ToString();
                ag.label30.Text = dr["prenume"].ToString();
                ag.label29.Text = dr["email"].ToString();
                ag.label28.Text = dr["telefon"].ToString();
                ag.label26.Text = dr["adresa"].ToString();
                ag.label25.Text = Convert.ToDateTime(dr["data_nasterii"]).ToString("dd-mm-yyyy");
                ag.label11.Text = dr["data_ora"].ToString();
                ag.label22.Text = dr["CNP"].ToString();
                ag.label24.Text = dr["sex"].ToString();
                ag.label21.Text = dr["judetprovenienta"].ToString();
                ag.label23.Text = dr["temperamentclient"].ToString();
                ag.label15.Text = dr["provenientaclient"].ToString();
                ag.label27.Text = dr["descriere"].ToString();


            }
            con.Close();

            ag.ShowDialog();


        }

        private void clientstable2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            customerslegal ag = new customerslegal();
            this.Hide();

            int id;
            id = Convert.ToInt32(clientstable2.Rows[e.RowIndex].Cells["ID"].Value.ToString());

            string stringcon = System.Configuration.ConfigurationManager.ConnectionStrings["residenceBDcon"].ConnectionString;
            SqlConnection con = new SqlConnection(stringcon);
            con.Open();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandText = "select * from clienti_juridici where id=" + id + "";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da1.Fill(ds);
            da.Fill(dt);




            foreach (DataRow dr in dt.Rows)
            {
                ag.label28.Text = dr["numecompanie"].ToString();
                ag.label20.Text = dr["CUI"].ToString();
                ag.label9.Text = dr["replegal"].ToString();
                ag.label6.Text = dr["telefoncompanie"].ToString();
                ag.label31.Text = dr["emailcompanie"].ToString();
                ag.label26.Text = dr["adresa"].ToString();
                ag.label25.Text = Convert.ToDateTime(dr["data_nasterii"]).ToString("dd-mm-yyyy");
                ag.label29.Text = dr["data_ora"].ToString();
                ag.label22.Text = dr["CNP"].ToString();
                ag.label24.Text = dr["sex"].ToString();
                ag.label21.Text = dr["judetprovenienta"].ToString();
                ag.label23.Text = dr["temperamentclient"].ToString();
                ag.label15.Text = dr["provenientaclient"].ToString();
                ag.label27.Text = dr["descriere"].ToString();


            }
            con.Close();

            ag.ShowDialog();

        }

        private void CNP_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        public int minprice;
        public int maxprice;
        private void priceinterval_RangeMinChanged(object sender, EventArgs e)
        {
            //priceinterval.RangeMin.GetTypeCode();
            minprice = priceinterval.RangeMin;
            minpriceinterval.Text = minprice.ToString()+ " u.m.";

        }

        private void priceinterval_RangeMaxChanged(object sender, EventArgs e)
        {
            maxprice = priceinterval.RangeMax;
            maxpriceinterval.Text = maxprice.ToString()+ " u.m.";
        }

        private void dashboard_KeyPress(object sender, KeyPressEventArgs e)
        {
            char priceboxes = e.KeyChar;
            if (!Char.IsDigit(priceboxes) && priceboxes != 8 && priceboxes != 46)
            { e.Handled = true; }

     

            
        }


        private void agentnameagent_OnValueChanged(object sender, EventArgs e)
        {

            string stringcon = System.Configuration.ConfigurationManager.ConnectionStrings["residenceBDcon"].ConnectionString;
            SqlConnection con = new SqlConnection(stringcon);

            con.Open();

            SqlDataAdapter ecch = new SqlDataAdapter("Select id_echipa as ID,CONCAT(nume,' ',prenume)as[NUME AGENT],adresa as ADRESA,telefon as TELEFON,functie as FUNTIE,email as EMAIL,descriere as DESCRIERE,poza as PROFIL from echipa where nume LIKE'" + agentnameagent.Text + "%'", con);
            DataTable d = new DataTable();
            ecch.Fill(d);
            memberstable.DataSource = d;
            con.Close();
        }

       

        private void IDagent_OnValueChanged(object sender, EventArgs e)
        {
            string stringcon = System.Configuration.ConfigurationManager.ConnectionStrings["residenceBDcon"].ConnectionString;
            SqlConnection con = new SqlConnection(stringcon);

            con.Open();

            SqlDataAdapter ecch = new SqlDataAdapter("Select id_echipa as ID,CONCAT(nume,' ',prenume)as[NUME AGENT],adresa as ADRESA,telefon as TELEFON,functie as FUNTIE,email as EMAIL,descriere as DESCRIERE,poza as PROFIL from echipa where id_echipa LIKE'" + IDagent.Text + "%'", con);
            DataTable d = new DataTable();
            ecch.Fill(d);
            memberstable.DataSource = d;
            con.Close();
        }

        private void adressagent_OnValueChanged(object sender, EventArgs e)
        {
            string stringcon = System.Configuration.ConfigurationManager.ConnectionStrings["residenceBDcon"].ConnectionString;
            SqlConnection con = new SqlConnection(stringcon);

            con.Open();

            SqlDataAdapter ecch = new SqlDataAdapter("Select id_echipa as ID,CONCAT(nume,' ',prenume)as[NUME AGENT],adresa as ADRESA,telefon as TELEFON,functie as FUNTIE,email as EMAIL,descriere as DESCRIERE,poza as PROFIL from echipa where adresa LIKE'" + adressagent.Text + "%'", con);
            DataTable d = new DataTable();
            ecch.Fill(d);
            memberstable.DataSource = d;
            con.Close();
        }

        private void telephoneagent_OnValueChanged(object sender, EventArgs e)
        {
            string stringcon = System.Configuration.ConfigurationManager.ConnectionStrings["residenceBDcon"].ConnectionString;
            SqlConnection con = new SqlConnection(stringcon);

            con.Open();

            SqlDataAdapter ecch = new SqlDataAdapter("Select id_echipa as ID,CONCAT(nume,' ',prenume)as[NUME AGENT],adresa as ADRESA,telefon as TELEFON,functie as FUNTIE,email as EMAIL,descriere as DESCRIERE,poza as PROFIL from echipa where telefon LIKE'" + telephoneagent.Text + "%'", con);
            DataTable d = new DataTable();
            ecch.Fill(d);
            memberstable.DataSource = d;
            con.Close();
        }

        private void functionagent_OnValueChanged(object sender, EventArgs e)
        {
            string stringcon = System.Configuration.ConfigurationManager.ConnectionStrings["residenceBDcon"].ConnectionString;
            SqlConnection con = new SqlConnection(stringcon);

            con.Open();

            SqlDataAdapter ecch = new SqlDataAdapter("Select id_echipa as ID,CONCAT(nume,' ',prenume)as[NUME AGENT],adresa as ADRESA,telefon as TELEFON,functie as FUNTIE,email as EMAIL,descriere as DESCRIERE,poza as PROFIL from echipa where functie LIKE'" + functionagent.Text + "%'", con);
            DataTable d = new DataTable();
            ecch.Fill(d);
            memberstable.DataSource = d;
            con.Close();
        }

        private void IDproject_OnValueChanged(object sender, EventArgs e)
        {
            string stringcon = System.Configuration.ConfigurationManager.ConnectionStrings["residenceBDcon"].ConnectionString;
            SqlConnection con = new SqlConnection(stringcon);

            con.Open();

            SqlDataAdapter ecch = new SqlDataAdapter("Select id_proiecte AS ID,numeagent as [NUME AGENT],numeproiect as [PROIECT],oras as ORAS,strada as STRADA,numaretajeimobil as [ETAJE IMOBIL],img1 as GALERIE from proiecte where id_proiecte LIKE'" + IDproject.Text + "%'", con);
            DataTable d = new DataTable();
            ecch.Fill(d);
            projecttable.DataSource = d;
            con.Close();
        }

        private void projectnamefilter_OnValueChanged(object sender, EventArgs e)
        {
            string stringcon = System.Configuration.ConfigurationManager.ConnectionStrings["residenceBDcon"].ConnectionString;
            SqlConnection con = new SqlConnection(stringcon);

            con.Open();

            SqlDataAdapter ecch = new SqlDataAdapter("Select id_proiecte AS ID,numeagent as [NUME AGENT],numeproiect as [PROIECT],oras as ORAS,strada as STRADA,numaretajeimobil as [ETAJE IMOBIL],img1 as GALERIE from proiecte where numeproiect LIKE'" + projectnamefilter.Text + "%'", con);
            DataTable d = new DataTable();
            ecch.Fill(d);
            projecttable.DataSource = d;
            con.Close();
        }

        private void cityproject_OnValueChanged(object sender, EventArgs e)
        {
            string stringcon = System.Configuration.ConfigurationManager.ConnectionStrings["residenceBDcon"].ConnectionString;
            SqlConnection con = new SqlConnection(stringcon);

            con.Open();

            SqlDataAdapter ecch = new SqlDataAdapter("Select id_proiecte AS ID,numeagent as [NUME AGENT],numeproiect as [PROIECT],oras as ORAS,strada as STRADA,numaretajeimobil as [ETAJE IMOBIL],img1 as GALERIE from proiecte where oras LIKE'" + cityproject.Text + "%'", con);
            DataTable d = new DataTable();
            ecch.Fill(d);
            projecttable.DataSource = d;
            con.Close();
        }

        private void agentnamefilter_OnValueChanged(object sender, EventArgs e)
        {
            string stringcon = System.Configuration.ConfigurationManager.ConnectionStrings["residenceBDcon"].ConnectionString;
            SqlConnection con = new SqlConnection(stringcon);

            con.Open();

            SqlDataAdapter ecch = new SqlDataAdapter("Select id_proiecte AS ID,numeagent as [NUME AGENT],numeproiect as [PROIECT],oras as ORAS,strada as STRADA,numaretajeimobil as [ETAJE IMOBIL],img1 as GALERIE from proiecte where numeagent LIKE'" + agentnamefilter.Text + "%'", con);
            DataTable d = new DataTable();
            ecch.Fill(d);
            projecttable.DataSource = d;
            con.Close();
        }

        private void IDproperties_OnValueChanged(object sender, EventArgs e)
        {
            string stringcon = System.Configuration.ConfigurationManager.ConnectionStrings["residenceBDcon"].ConnectionString;
            SqlConnection con = new SqlConnection(stringcon);

            con.Open();

            SqlDataAdapter ecch = new SqlDataAdapter("Select id as ID,numeagent as [AGENT],numeproiect as [PROIECT],numeproprietate as [PROPRIETATE],CONCAT(pretlista,' ',moneda) as [PREȚ LISTĂ] ,tipproprietate as [TIP PROP.],etaj as [ETAJ],numarapartament as [NR. APT.],img1 as GALERIE from proprietati where id LIKE'" + IDproperties.Text + "%'", con);
            DataTable d = new DataTable();
            ecch.Fill(d);
            propertiestable.DataSource = d;
            con.Close();
        }

        private void projectnameproperties_onItemSelected(object sender, EventArgs e)
        {
            string stringcon = System.Configuration.ConfigurationManager.ConnectionStrings["residenceBDcon"].ConnectionString;
            SqlConnection con = new SqlConnection(stringcon);

            if (projectnameproperties.selectedValue == "Nume proiect - Toate")
            {
                con.Open();
                SqlCommand cmdread3 = new SqlCommand("Select id as ID,numeagent as [AGENT],numeproiect as [PROIECT],numeproprietate as [PROPRIETATE],CONCAT(pretlista,' ',moneda) as [PREȚ LISTĂ] ,tipproprietate as [TIP PROP.],etaj as [ETAJ],numarapartament as [NR. APT.],img1 as GALERIE from proprietati", con);
                cmdread3.ExecuteNonQuery();
                DataTable dt3 = new DataTable();
                SqlDataAdapter sda2 = new SqlDataAdapter(cmdread3);
                sda2.Fill(dt3);
                propertiestable.DataSource = dt3;
                con.Close();

            }

            else
            {
                con.Open();

                SqlDataAdapter ecch = new SqlDataAdapter("Select id as ID,numeagent as [AGENT],numeproiect as [PROIECT],numeproprietate as [PROPRIETATE],CONCAT(pretlista,' ',moneda) as [PREȚ LISTĂ] ,tipproprietate as [TIP PROP.],etaj as [ETAJ],numarapartament as [NR. APT.],img1 as GALERIE from proprietati where numeproiect LIKE'" + projectnameproperties.selectedValue + "%'", con);
                DataTable d = new DataTable();
                ecch.Fill(d);
                propertiestable.DataSource = d;

                con.Close();
            }
        }

        private void projectnameproperties_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void propertiestype_onItemSelected(object sender, EventArgs e)
        {
            string stringcon = System.Configuration.ConfigurationManager.ConnectionStrings["residenceBDcon"].ConnectionString;
            SqlConnection con = new SqlConnection(stringcon);

            if (propertiestype.selectedValue == "Tip proprietate - Toate")
            {
                con.Open();
                SqlCommand cmdread3 = new SqlCommand("Select id as ID,numeagent as [AGENT],numeproiect as [PROIECT],numeproprietate as [PROPRIETATE],CONCAT(pretlista,' ',moneda) as [PREȚ LISTĂ] ,tipproprietate as [TIP PROP.],etaj as [ETAJ],numarapartament as [NR. APT.],img1 as GALERIE from proprietati", con);
                cmdread3.ExecuteNonQuery();
                DataTable dt3 = new DataTable();
                SqlDataAdapter sda2 = new SqlDataAdapter(cmdread3);
                sda2.Fill(dt3);
                propertiestable.DataSource = dt3;
                con.Close();

            }

            else
            {
                con.Open();

                SqlDataAdapter ecch = new SqlDataAdapter("Select id as ID,numeagent as [AGENT],numeproiect as [PROIECT],numeproprietate as [PROPRIETATE],CONCAT(pretlista,' ',moneda) as [PREȚ LISTĂ] ,tipproprietate as [TIP PROP.],etaj as [ETAJ],numarapartament as [NR. APT.],img1 as GALERIE from proprietati where tipproprietate LIKE'" + propertiestype.selectedValue + "%'", con);
                DataTable d = new DataTable();
                ecch.Fill(d);
                propertiestable.DataSource = d;

                con.Close();
            }
        }

        private void floor_onItemSelected(object sender, EventArgs e)
        {
            string stringcon = System.Configuration.ConfigurationManager.ConnectionStrings["residenceBDcon"].ConnectionString;
            SqlConnection con = new SqlConnection(stringcon);

            if (floor.selectedValue == "Etaj - Toate")
            {
                con.Open();
                SqlCommand cmdread3 = new SqlCommand("Select id as ID,numeagent as [AGENT],numeproiect as [PROIECT],numeproprietate as [PROPRIETATE],CONCAT(pretlista,' ',moneda) as [PREȚ LISTĂ] ,tipproprietate as [TIP PROP.],etaj as [ETAJ],numarapartament as [NR. APT.],img1 as GALERIE from proprietati", con);
                cmdread3.ExecuteNonQuery();
                DataTable dt3 = new DataTable();
                SqlDataAdapter sda2 = new SqlDataAdapter(cmdread3);
                sda2.Fill(dt3);
                propertiestable.DataSource = dt3;
                con.Close();

            }

            else
            {
                con.Open();

                SqlDataAdapter ecch = new SqlDataAdapter("Select id as ID,numeagent as [AGENT],numeproiect as [PROIECT],numeproprietate as [PROPRIETATE],CONCAT(pretlista,' ',moneda) as [PREȚ LISTĂ] ,tipproprietate as [TIP PROP.],etaj as [ETAJ],numarapartament as [NR. APT.],img1 as GALERIE from proprietati where etaj LIKE'" + floor.selectedValue + "%'", con);
                DataTable d = new DataTable();
                ecch.Fill(d);
                propertiestable.DataSource = d;

                con.Close();
            }
        }

        private void priceinterval_RangeChanged(object sender, EventArgs e)
        {
            string stringcon = System.Configuration.ConfigurationManager.ConnectionStrings["residenceBDcon"].ConnectionString;
            SqlConnection con = new SqlConnection(stringcon);

            con.Open();

            SqlDataAdapter ecch = new SqlDataAdapter("Select id as ID,numeagent as [AGENT],numeproiect as [PROIECT],numeproprietate as [PROPRIETATE],CONCAT(pretlista,' ',moneda) as [PREȚ LISTĂ] ,tipproprietate as [TIP PROP.],etaj as [ETAJ],numarapartament as [NR. APT.],img1 as GALERIE from proprietati where pretlista between  @fw and  @gw", con);
            ecch.SelectCommand.Parameters.AddWithValue("@fw", minprice);
            ecch.SelectCommand.Parameters.AddWithValue("@gw", maxprice);
            DataTable d = new DataTable();
            ecch.Fill(d);
            propertiestable.DataSource = d;

            con.Close();
        }

        private void IDclient_OnValueChanged(object sender, EventArgs e)
        {
            string stringcon = System.Configuration.ConfigurationManager.ConnectionStrings["residenceBDcon"].ConnectionString;
            SqlConnection con = new SqlConnection(stringcon);

            con.Open();

            SqlDataAdapter ecch = new SqlDataAdapter("Select statut as[ ],id_client as ID,numeagent as [AGENT],CONCAT(nume,' ',prenume)as [CLIENT],email as EMAIL,telefon as TELEFON,CNP,temperamentclient AS [TEMPERAMENT] from clienti_fizici where id_client LIKE'" + IDclient.Text + "%'", con);

            DataTable d = new DataTable();
            ecch.Fill(d);
            clientstabel.DataSource = d;

            con.Close();

            con.Open();

            SqlDataAdapter ecch1 = new SqlDataAdapter("Select statut as[ ],id as ID,numeagent as [AGENT],numecompanie AS COMPANIE,replegal as [CLIENT],telefoncompanie as TELEFON,emailcompanie as EMAIL,CNP,temperamentclient AS [TEMPERAMENT] from clienti_juridici where id LIKE'" + IDclient.Text + "%'", con);

            DataTable d1 = new DataTable();
            ecch1.Fill(d1);
            clientstable2.DataSource = d1;

            con.Close();
        }

        private void clientname_OnValueChanged(object sender, EventArgs e)
        {
            string stringcon = System.Configuration.ConfigurationManager.ConnectionStrings["residenceBDcon"].ConnectionString;
            SqlConnection con = new SqlConnection(stringcon);

            con.Open();

            SqlDataAdapter ecch = new SqlDataAdapter("Select statut as[ ],id_client as ID,numeagent as [AGENT],CONCAT(nume,' ',prenume)as [CLIENT],email as EMAIL,telefon as TELEFON,CNP,temperamentclient AS [TEMPERAMENT] from clienti_fizici where CONCAT(nume,' ',prenume) LIKE '" + clientname.Text + "%'", con);
            

            DataTable d = new DataTable();
            ecch.Fill(d);
            clientstabel.DataSource = d;

            con.Close();

            con.Open();

            SqlDataAdapter ecch1 = new SqlDataAdapter("Select statut as[ ],id as ID,numeagent as [AGENT],numecompanie AS COMPANIE,replegal as [CLIENT],telefoncompanie as TELEFON,emailcompanie as EMAIL,CNP,temperamentclient AS [TEMPERAMENT] from clienti_juridici where replegal LIKE'" + clientname.Text + "%'", con);

            DataTable d1 = new DataTable();
            ecch1.Fill(d1);
            clientstable2.DataSource = d1;

            con.Close();
        }
        public int counterpopupinserttime = 0;
        private void popupsuccesdatainsert_Tick(object sender, EventArgs e)
        {
            counterpopupinserttime = counterpopupinserttime + 100;
            if (counterpopupinserttime == 4000)
            {
                bunifuCustomLabel6.Visible = false;

                popupsuccesdatainsert.Stop();
                counterpopupinserttime = 0;
            }
            else
                return;
        }

        private void clientsprovide_onItemSelected(object sender, EventArgs e)
        {
            //string stringcon = System.Configuration.ConfigurationManager.ConnectionStrings["residenceBDcon"].ConnectionString;
            //SqlConnection con = new SqlConnection(stringcon);

            //if (clientsprovide.selectedValue == "Toate")
            //{
            //    con.Open();
            //    SqlCommand cmdread3 = new SqlCommand("Select statut as[ ],id_client as ID,numeagent as [AGENT],CONCAT(nume,' ',prenume)as [CLIENT],email as EMAIL,telefon as TELEFON,CNP,temperamentclient AS [TEMPERAMENT] from clienti_fizici", con);
            //    cmdread3.ExecuteNonQuery();
            //    DataTable dt3 = new DataTable();
            //    SqlDataAdapter sda2 = new SqlDataAdapter(cmdread3);
            //    sda2.Fill(dt3);
            //    propertiestable.DataSource = dt3;
            //    con.Close();

            //}


            //con.Open();

            //SqlDataAdapter ecch = new SqlDataAdapter("Select statut as[ ],id_client as ID,numeagent as [AGENT],CONCAT(nume,' ',prenume)as [CLIENT],email as EMAIL,telefon as TELEFON,CNP,temperamentclient AS [TEMPERAMENT] from clienti_fizici where temperamentclient LIKE '" + clientsprovide.selectedValue + "%'", con);


            //DataTable d = new DataTable();
            //ecch.Fill(d);
            //clientstabel.DataSource = d;

            //con.Close();

            //con.Open();

            //SqlDataAdapter ecch1 = new SqlDataAdapter("Select statut as[ ],id as ID,numeagent as [AGENT],numecompanie AS COMPANIE,replegal as [CLIENT],telefoncompanie as TELEFON,emailcompanie as EMAIL,CNP,temperamentclient AS [TEMPERAMENT] from clienti_juridici where temperamentclient LIKE'" + clientsprovide.selectedValue + "%'", con);

            //DataTable d1 = new DataTable();
            //ecch1.Fill(d1);
            //clientstable2.DataSource = d1;

            //con.Close();
        }
    }


}
