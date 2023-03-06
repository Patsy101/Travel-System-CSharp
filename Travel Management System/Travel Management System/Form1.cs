using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travel_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;

            iExit = MessageBox.Show("Confirm if you want to exit", "Travel System",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            rtReceipt.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            txtFirstname.Clear();
            txtPostcode.Clear();
            txtSurname.Clear();
            txtTelephone.Clear();

            lblSubtotal.Text = "";
            lblTax.Text = "";
            lblTotal.Text = "";

            cmbAccomodation.Text = "None";
            cmbDeparture.Text = "None";
            cmbDestination.Text = "None";

            chkAirMiles.Checked = true;
            chkAirportTax.Checked = true;
            chkExtLuggage.Checked = true;  
            ChkTravelInsurance.Checked = true;
            chkSingle.Checked = false;
            chkReturn.Checked = false;

            chkAdult.Checked = false;
            chkChild.Checked = false;


            rbStandard.Checked = false;
            rbBusiness.Checked = false;
            rbEconomy.Checked = false;
           



           
        }

        private void cmbDeparture_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            DollarPrice travelprice = new DollarPrice();
            iTax Airtax = new iTax();
            double[] TravelCost = new double[20];
            double[] TaxCost = new double[20];
            double Total;

            if (cmbDestination.Text =="Auckland")
            {
                TravelCost[0] = travelprice.Auckland + travelprice.Airport_Tax + travelprice.Air_Points +travelprice.Insurance + travelprice.Ext_Luggage; // Array starts at 0
                TaxCost[0] = Airtax.iFindTax(TravelCost[0]); // Tax
                Total = TravelCost[0] + TaxCost[0];
                lblSubtotal.Text = String.Format ( "{0:G}", TravelCost[0] );
                lblTax.Text = String.Format ("{0:G}", TaxCost[0]);
                lblTotal.Text = String.Format("{0:G}", Total);
            }
            if (cmbDestination.Text == "Christchurch");
            {
                TravelCost [0] = travelprice.Christchurch + travelprice.Airport_Tax + travelprice.Air_Points + travelprice.Insurance + travelprice.Ext_Luggage;
                TaxCost[0] = Airtax.iFindTax(TravelCost[0]);
                Total=TravelCost[0] + TaxCost[0];
                lblSubtotal.Text = String.Format ("{0:G}", TravelCost [0] );
                lblTax.Text = String.Format ("{0:G}", TaxCost [0]);
                lblTotal.Text = String.Format("{0:G}", Total); 
            }
            if (cmbDestination.Text == "Queenstown") ;
            {
                TravelCost[0] = travelprice.Queenstown + travelprice.Airport_Tax + travelprice.Air_Points + travelprice.Insurance + travelprice.Ext_Luggage; // Array starts at 0
                TaxCost[0] = Airtax.iFindTax(TravelCost[0]); // Tax
                Total = TravelCost[0] + TaxCost[0];
                lblSubtotal.Text = String.Format("{0:G}", TravelCost[0]);
                lblTax.Text = String.Format("{0:G}", TaxCost[0]);
                lblTotal.Text = String.Format("{0:G}", Total);
            }
            if (cmbDestination.Text == "Dunedin");
            {
                TravelCost[0] = travelprice.Dunedin + travelprice.Airport_Tax + travelprice.Air_Points + travelprice.Insurance + travelprice.Ext_Luggage; // Array starts at 0
                TaxCost[0] = Airtax.iFindTax(TravelCost[0]); // Tax
                Total = TravelCost[0] + TaxCost[0];
                lblSubtotal.Text = String.Format("{0:G}", TravelCost[0]);
                lblTax.Text = String.Format("{0:G}", TaxCost[0]);
                lblTotal.Text = String.Format("{0:G}", Total);
            }
            if (cmbDestination.Text == "Wellington");
            {
                TravelCost[0] = travelprice.Wellington + travelprice.Airport_Tax + travelprice.Air_Points + travelprice.Insurance + travelprice.Ext_Luggage; // Array starts at 0
                TaxCost[0] = Airtax.iFindTax(TravelCost[0]); // Tax
                Total = TravelCost[0] + TaxCost[0];
                lblSubtotal.Text = String.Format("{0:G}", TravelCost[0]); 
                lblTax.Text = String.Format("{0:G}", TaxCost[0]);
                lblTotal.Text = String.Format("{0:G}", Total);
            }


        }

        private void cmbDestination_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            int num1;
            Random rnd = new Random();
            num1 = rnd.Next(4238, 34238);
            num1 = 1325 + num1;
            String refs = Convert.ToString(num1);
           // String Firstname = (txtFirstname.Text);
           // String Surname = (txtSurname.Text);
            //String Address = (txtAddress.Text);
            //String PostCode = (txtPostcode.Text);
           // String Telephone = (txtTelephone.Text);
            //String Email = (txtEmail.Text);
            //String rTax = (lblTax.Text);
           // String SubTotal = (lblSubtotal.Text);
            //String rTotal = (lblTotal.Text);

            rtReceipt.AppendText(" \t Travel System: \n \n"
                + "Ref:\t\t\t\t\t" + refs
                + "\n--------------------------------------------"
                + "\nName:\t\t\t" + txtFirstname.Text
                + "\nSurname:\t\t\t" + txtSurname.Text
                + "\nAdress:\t\t\t" + txtAddress.Text
                + "\nPostCode:\t\t\t" + txtPostcode.Text
                + "\nTelephone: \t\t\t" + txtTelephone.Text
                + "\nEmail:\t\t\t" + txtEmail.Text
                + "\nSubtotal:\t\t\t" + lblSubtotal.Text
                + "\nTax:\t\t\t" + lblTax.Text
                + "\nTotal:\t\t\t" + lblTotal.Text
                );


        }

        private void chkAirportTax_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chkAirportTax.Checked = true;
            chkAirMiles.Checked = true;
            chkExtLuggage.Checked = true;
            ChkTravelInsurance.Checked = true;

        }
    }
}
