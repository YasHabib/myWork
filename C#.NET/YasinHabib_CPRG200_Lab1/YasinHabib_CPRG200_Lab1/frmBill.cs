using System;
using System.Windows.Forms;

namespace YasinHabib_CPRG200_Lab1
{
    /// <summary>
    /// This program will calculate the total charge of electricity for several types of customers (Lab 1)
    /// Author: Yasin Habib
    /// Date: April 9th, 2020
    /// </summary>

    public partial class frmBill : Form
    {
        //Constants
        const int RES_CONST = 6;
        const decimal RES_RATE = 0.052m;
        const int COMM_CONST = 60;
        const decimal COMM_RATE = 0.045m;
        const int IND_ON_PEAK = 76;
        const decimal IND_ON_PEAK_RATE = 0.065m;
        const int IND_OFF_PEAK = 40;
        const decimal IND_OFF_PEAK_RATE = 0.028m;

        public frmBill()
        {
            InitializeComponent();
        }

        //Calculation
        private void btnCalc_Click(object sender, EventArgs e)
        {
            lblTotalCost.Visible = true;
            txtTotalCost.Visible = true;
            decimal totalCharge;
            decimal usage = Convert.ToDecimal(txtUsage.Text);
            if (Validation.ValidNegWhole(txtUsage) || Validation.ValidNegWhole(txtOffPeak)) //Validation
            {

                if (radResidential.Checked == true) //Residential
                {
                    totalCharge = ResUseCharge(usage);
                    txtTotalCost.Text = totalCharge.ToString("c");
                }
                else if (radComm.Checked == true)   //commercial
                {
                    totalCharge = CommUseCharge(usage);
                    txtTotalCost.Text = totalCharge.ToString("c");
                }
                else                                //Industrial
                {
                    decimal offUsage = Convert.ToDecimal(txtOffPeak.Text);
                    totalCharge = IndUseCharge(usage, offUsage);
                    txtTotalCost.Text = totalCharge.ToString("c");
                }
            }
        }


        //                                                          RESIDENCIAL
        private void radResidential_CheckedChanged(object sender, EventArgs e)
        {
            //After clicking the corosponding radio button    
            lblUsage.Text = "Total electricity used (kWh)"; //If the uses goes back to commercial from Industrial
            lblOffPeak.Visible = false;
            txtOffPeak.Visible = false;
            txtUsage.Focus();
        }

        //Method for residential
        private decimal ResUseCharge(decimal usage)
        {
            decimal totalResCharge = Convert.ToDecimal(RES_CONST + (RES_RATE * usage));
            return totalResCharge;
        }

        //                                                       END OF RESIDENTIAL


        //                                                          COMMERCIAL
        private void radComm_CheckedChanged(object sender, EventArgs e)
        {
            //After clicking the corosponding radio button    
            lblUsage.Text = "Total electricity used (kWh)"; //If the uses goes back to commercial from Industrial.
            lblOffPeak.Visible = false;                     // they will automatically reset any previous data 
            txtOffPeak.Visible = false;                     //   written from previous customer type
            txtTotalCost.Visible = false;
            txtUsage.Text = "";
            txtUsage.Focus();
        }
        //Method for commercial
        private decimal CommUseCharge(decimal usage)
        {
            decimal totalCommCharge;
            if ((usage >= 0) && (usage <= 1000))
            {
                totalCommCharge = COMM_CONST;
            }
            else
                totalCommCharge = COMM_CONST + Convert.ToDecimal(COMM_RATE* usage);
            return totalCommCharge;
        }
        //                                                      END OF COMMERCIAL



        //                                                          INDUSTRIAL
        private void radIndust_CheckedChanged(object sender, EventArgs e)
        {
            //After clicking the corosponding radio button    
            lblUsage.Text = "On peak-hour usage (kWh)";
            lblOffPeak.Visible = true;
            txtOffPeak.Visible = true;
            txtUsage.Focus();
        }

        //method for industrial
        private decimal IndUseCharge(decimal onPeakUsage, decimal offPeakUsage)
        {
            decimal totalIndCharge;
            decimal totalOnPeakCharge = Convert.ToDecimal(IND_ON_PEAK_RATE * onPeakUsage); //On peak use
            decimal totalOffPeakCharge = Convert.ToDecimal(IND_OFF_PEAK_RATE * offPeakUsage); //off peak use

            if (((onPeakUsage <= 1000) && (onPeakUsage >= 0)) && ((offPeakUsage <= 1000) && (offPeakUsage >= 0)))
            {
                totalIndCharge = IND_ON_PEAK + IND_OFF_PEAK;
            }
            else if ((onPeakUsage > 1000) && (offPeakUsage <= 1000))
            {
                totalIndCharge = totalOnPeakCharge + IND_OFF_PEAK;
            }
            else if ((onPeakUsage <= 1000) && (offPeakUsage > 1000))
            {
                totalIndCharge = IND_ON_PEAK + totalOffPeakCharge;
            }
            else
            {
                totalIndCharge = totalOnPeakCharge + totalOffPeakCharge;
            }
            return totalIndCharge;
        }

        //                                                      END OF INDUSTRIAL

        // Reset

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblTotalCost.Visible = false;
            txtTotalCost.Visible = false;
            txtOffPeak.Text = "";
            txtUsage.Text = "";
        }

        //Exit

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
