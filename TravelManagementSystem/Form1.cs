using System;
using System.Windows.Forms;

namespace TravelManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime iTime = DateTime.Now;
            lblTime.Text = iTime.ToLongTimeString();

            DateTime iDate = DateTime.Now;
            lblDate.Text = iDate.ToLongDateString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkAirportTax.Checked = true;
            checkAirMiles.Checked = true;
            checkTravelInsurance.Checked = true; ;
            checkExitLagguage.Checked = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you want to exit", "Travel Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
            txtFname.Clear();
            txtPostalCode.Clear();
            txtSname.Clear();
            txtTelephone.Clear();

            txtTax.Text = "";
            txtTotal.Text = "";
            txtSubtotal.Text = "";

            ddlDeparture.Text = "None";
            ddlDestination.Text = "None";
            ddlOrganization.Text = "None";


            checkAirportTax.Checked = true;
            checkAirMiles.Checked = true;
            checkTravelInsurance.Checked = true; ;
            checkExitLagguage.Checked = true;

            checkAdult.Checked = false;
            checkChild.Checked = false;
            checkSingle.Checked = false;
            checkReturn.Checked = false;
            checkSpecialNeeds.Checked = false;

            radioEconomy.Checked = false; ;
            radioFirstClass.Checked = false;
            radioStandard.Checked = false;

        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            cPrice TravelPrice = new cPrice();
            iTax AirTax = new iTax();
            double[] TravelCost = new double[20];
            double[] TaxCost = new double[20];
            double Total;
            if (ddlDestination.Text == "Dubai, 1.5 hours")
            {
                TravelCost[0] = TravelPrice.Dubai + TravelPrice.air_Miles + TravelPrice.airport_Tax + TravelPrice.Insurance + TravelPrice.ext_luggage;
                TaxCost[0] = AirTax.iFindTax(TravelCost[0]);
                Total = TravelCost[0] + TaxCost[0];

                txtSubtotal.Text = String.Format("{0:C}", TravelCost[0]);
                txtTax.Text = String.Format("{0:C}", TaxCost[0]);
                txtTotal.Text = String.Format("{0:C}", Total);

            }
            else if (ddlDestination.Text == "Jedda,  2 hours")
            {
                TravelCost[0] = TravelPrice.Jedda + TravelPrice.air_Miles + TravelPrice.airport_Tax + TravelPrice.Insurance + TravelPrice.ext_luggage;
                TaxCost[0] = AirTax.iFindTax(TravelCost[0]);
                Total = TravelCost[0] + TaxCost[0];

                txtSubtotal.Text = String.Format("{0:C}", TravelCost[0]);
                txtTax.Text = String.Format("{0:C}", TaxCost[0]);
                txtTotal.Text = String.Format("{0:C}", Total);

            }
            else if (ddlDestination.Text == "Cairo,   3 hours")
            {
                TravelCost[0] = TravelPrice.Cairo + TravelPrice.air_Miles + TravelPrice.airport_Tax + TravelPrice.Insurance + TravelPrice.ext_luggage;
                TaxCost[0] = AirTax.iFindTax(TravelCost[0]);
                Total = TravelCost[0] + TaxCost[0];

                txtSubtotal.Text = String.Format("{0:C}", TravelCost[0]);
                txtTax.Text = String.Format("{0:C}", TaxCost[0]);
                txtTotal.Text = String.Format("{0:C}", Total);
            }
            else if (ddlDestination.Text == "Newyork, 12 hours")
            {
                TravelCost[0] = TravelPrice.Newyork + TravelPrice.air_Miles + TravelPrice.airport_Tax + TravelPrice.Insurance + TravelPrice.ext_luggage;
                TaxCost[0] = AirTax.iFindTax(TravelCost[0]);
                Total = TravelCost[0] + TaxCost[0];

                txtSubtotal.Text = String.Format("{0:C}", TravelCost[0]);
                txtTax.Text = String.Format("{0:C}", TaxCost[0]);
                txtTotal.Text = String.Format("{0:C}", Total);
            }
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {

            int num1;
            Random rnd = new Random();
            num1 = rnd.Next(4238, 32123);
            num1 = 1235 + num1;
            String refs = Convert.ToString(num1);

            String Firstname = (txtFname.Text);
            String Surname = (txtSname.Text);
            String Address = (txtAddress.Text);
            String PostalCode = (txtPostalCode.Text);
            String Telephone = (txtTelephone.Text);
            String Email = (txtEmail.Text);
            String rTax = (txtTax.Text);
            String sTotal = (txtSubtotal.Text);
            String Total = (txtTotal.Text);


            rtReceipt.AppendText("\tTravel Management System: \n\n "
                + " \nRef Number :\t\t\t" + refs
                + "\n-----------------------------------------------------------------------------"
                + " \nName :\t\t\t" + Firstname
                + "\nSurname :\t\t\t" + Surname
                + "\nAddress :\t\t\t" + Address
                + "\nPostalCode :\t\t\t" + PostalCode
                + "\nTelephone :\t\t\t" + Telephone
                + "\nEmail :\t\t\t" + Email
                + "\nDestianation :\t\t\t" + ddlDestination.Text
                + "\n-----------------------------------------------------------------------------"
                + "\nTax      :" + rTax
                + "\nSubTotal :" + sTotal
                + "\nTotal    :" + Total
                + "\n-----------------------------------------------------------------------------"
                + "\nDate :" + lblDate.Text
                + "\nTime :" + lblTime.Text
                + "\n-----------------------------------------------------------------------------"
                + "Thankyou for using :\t\t\t\t" +"Travel Management System"

                   );
        }
    }
}
