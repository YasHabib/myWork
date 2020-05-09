using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YasinHabib_CPRG200_lab2
{
    public partial class frmCustomerData : Form
    {
        const string path = "Customer.txt";
        List<Customer> customerdata = new List<Customer>();
        public frmCustomerData()
        {
            InitializeComponent();
        }
        //Form loads, creates/ re writes a file
        private void frmCustomerData_Load(object sender, EventArgs e)
        {
            FileStream fs;
            StreamReader sr = null;
            string line;
            string[] fields;
            Customer cust;
            int accNo;
            string custName;
            string custType;
            decimal charge;

            try
            {
                fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read); //Reading file
                sr = new StreamReader(fs);
                
                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine(); 
                    fields = line.Split(',');
                    accNo = Convert.ToInt32(fields[0]);
                    custName = fields[1];
                    custType = fields[2];
                    charge = Convert.ToDecimal(fields[3]);
                    cust = new Customer(accNo, custName, custType, charge);
                    customerdata.Add(cust);
                }
                DisplayCustomerData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while reading customer data from file: " +
                    ex.Message, ex.GetType().ToString());
            }
            finally
            {
                if (sr != null) sr.Close();
            }

        }//End of form load


        //Display method 
        private void DisplayCustomerData()
        {
            lstCustData.Items.Clear();
            foreach (Customer c in customerdata)
            {
                lstCustData.Items.Add(c);
            }
            //Display count
            txtCustomerCount.Text = customerdata.Count.ToString();
            //Display R C I charges
            //R
            decimal chargeR = TotalTypeRCharge();
            txtR.Text = chargeR.ToString("c");
            //C
            decimal chargeC = TotalTypeCCharge();
            txtC.Text = chargeC.ToString("c");
            //I
            decimal chargeI = TotalTypeICharge();
            txtI.Text = chargeI.ToString("c");

            //Display total charges
            decimal totalCharge = TotalCharge();
            txtTotCharge.Text = totalCharge.ToString("c");

        }//End of display method


        //Combo box (showing and hiding certain text box, labels and button)
        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnCalculate.Visible = true; //Button to calculate 

            if (cboType.SelectedIndex == 1) //R selected
            {
                txtTotKW.Visible = true;
                lblKWused.Visible = true;
                lblKWused.Text = "Total KW usage";
                lblOffpeak.Visible = false;
                txtOffPeak.Visible = false;
            }
            else if (cboType.SelectedIndex == 2) //C selected
            {
                txtTotKW.Visible = true;
                lblKWused.Visible = true;
                lblKWused.Text = "Total KW usage";
                lblOffpeak.Visible = false;
                txtOffPeak.Visible = false;
            }
            else if (cboType.SelectedIndex == 3) //I selected
            {
                txtOffPeak.Visible = true;
                txtTotKW.Visible = true;
                lblKWused.Visible = true;
                lblKWused.Text = "Total on peak usage";
                lblOffpeak.Visible = true;
            }
        }//End of combo box

        //Adding data to the list and saving
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Reading inputs and displaying data to listbox
                int accNo = Convert.ToInt32(txtAccNo.Text);
                string custName = txtCustName.Text;
                string custType = cboType.Text;
                decimal charge = Convert.ToDecimal(txtChargeAmount.Text); 
                                                                                        
                Customer newCust = new Customer(accNo, custName, custType, charge);
                customerdata.Add(newCust);
                DisplayCustomerData();
            
            


            //Saving the data

            FileStream fs;
            StreamWriter sw = null;
            string line;
            try
            {
                fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                sw = new StreamWriter(fs);

                foreach (Customer c in customerdata)
                {
                    line = c.AccNumber + "," + c.CustomerName + "," + c.CustomerType + "," + c.ChargeAmount; 
                    sw.WriteLine(line);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while writing customer data to file: " +
                    ex.Message, ex.GetType().ToString());
            }
            finally
            {
                if (sw != null) sw.Close();
            }
        }// END of button Add


        //                                          CALCULATIONS
        //Total charge
        private decimal TotalCharge()
        {
            decimal total = 0;
            foreach(Customer c in customerdata)
                total += c.ChargeAmount;
            return total;
        }//End of total charge


        //Calculating total charge for R, C, I
        
        //R
        public decimal TotalTypeRCharge() //For R
        {
            decimal total = 0;
            foreach(Customer c in customerdata)
            {
                if (c.CustomerType == "R")
                {
                    total += c.ChargeAmount;
                }
                    
            }
            return total;
        }

        //for C
        public decimal TotalTypeCCharge()
        {
            decimal total = 0;
            foreach (Customer c in customerdata)
            {
                if (c.CustomerType == "C")
                {
                    total += c.ChargeAmount;
                }
            }
            return total;
        }

        // for I
        public decimal TotalTypeICharge()
        {
            decimal total = 0;
            foreach (Customer c in customerdata)
            {
                if (c.CustomerType == "I")
                {
                    total += c.ChargeAmount;
                }
            }
            return total;
        }

        //.........................................↓↓↓↓↓↓↓↓↓↓↓↓...........
        //Calculate(Single general method)
        //private void btnCalculate_Click(object sender, EventArgs e)
        //{
        //    btnAdd.Enabled = true; // Enables adding after having values for ChargeAmount
        //    decimal chargeAmount; //    decimal chargeAmount;
        //    chargeAmount = Customer.ChargeTotal(cboType, txtTotKW, txtOffPeak);
        //    txtChargeAmount.Text = chargeAmount.ToString();
        //}


        //Clicking calculate (for 3 methods)
        private void btnCalculate_Click(object sender, EventArgs e)
        {
             
            decimal chargeAmount;

            if (cboType.SelectedIndex == 1)
            {
                if (Validation.ValidNegWhole(txtTotKW))
                {
                    chargeAmount = Customer.ChargeR(txtTotKW);
                    txtChargeAmount.Text = chargeAmount.ToString();
                    btnAdd.Enabled = true; // Enables adding after having the right values for corrosponding textbox 
                }

            }
            else if (cboType.SelectedIndex == 2)
            {
                if (Validation.ValidNegWhole(txtTotKW))
                {
                    chargeAmount = Customer.ChargeC(txtTotKW);
                    txtChargeAmount.Text = chargeAmount.ToString();
                    btnAdd.Enabled = true;
                }

            }
            else if (cboType.SelectedIndex == 3)
            {
                if (Validation.ValidNegWhole(txtTotKW) && Validation.ValidNegWhole(txtOffPeak))
                {
                    chargeAmount = Customer.ChargeI(txtTotKW, txtOffPeak);
                    txtChargeAmount.Text = chargeAmount.ToString();
                    btnAdd.Enabled = true;
                }
            }
            else
            {
                btnCalculate.Visible = false;
                txtOffPeak.Visible = false;
                lblKWused.Visible = false;
                lblOffpeak.Visible = false;
                txtTotKW.Visible = false;
                MessageBox.Show("Please chose a valid customer type","Invalid Input");
            }
        }//End of Calculate button

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAccNo.Text = "";
            txtCustName.Text = "";
            cboType.SelectedIndex = 0;
            txtChargeAmount.Text = "";
            btnCalculate.Visible = false;
            txtOffPeak.Visible = false;
            lblKWused.Visible = false;
            lblOffpeak.Visible = false;
            txtTotKW.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Clear button

    }//End of form1
}//End of namespace
