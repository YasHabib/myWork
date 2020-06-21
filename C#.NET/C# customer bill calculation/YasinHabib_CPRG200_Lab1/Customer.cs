using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YasinHabib_CPRG200_Lab1
{
    public class Customer
    {
        private int accNo;
        //string custName;
        //string custType;
        private decimal charge;
        private decimal total;

        public int AccNumber
        {
            get
            {
                return accNo;
            }
            set
            {
                if (value < 0)
                {
                    value = -value;
                    MessageBox.Show("The negative value you have entered has been converted to positive");
                    accNo = value;
                }
            }
        }//END of AccNumber

        public string CustomerName
        {
            get; set;
        }

        public string CustomerType
        {
            get; set;
        }

        public decimal ChargeAmount
        {
            get { return charge; }
            set
            {
                if (value < 0)
                {
                    value = -value;
                    MessageBox.Show("The negative value you have entered has been converted to positive");
                    charge = value;
                }
            }
        }

        //Constructor
        public Customer(int acc = 0, string cn = "N/A", string ct = "N/A", decimal ch = 0.0m)
        {
            AccNumber = acc;
            CustomerName = cn;
            CustomerType = ct;
            ChargeAmount = ch;
        }
        //Calculation
        //public decimal TotalTypeRCharge(ComboBox typeCust)
        //{
        //    if (typeCust.Text == "R")
        //    {
        //        decimal total = 0;
        //        foreach (Customer c in customerData)
        //            total += Convert.ToDecimal(txtChargeAmount.Text);
                
        //    }
        //    return total;
        //}
        //public decimal TotalTypeCCharge(ComboBox typeCust)
        //{
        //    if (typeCust.Text == "C")
        //    {
        //        decimal total = 0;
        //        foreach (Customer c in customerData)
        //            total += Convert.ToDecimal(txtChargeAmount.Text);
        //    }
        //    return total;
        //}
        //public decimal TotalTypeICharge(ComboBox typeCust)
        //{ 
        //    if (typeCust.Text == "I")
        //    {
        //        decimal total = 0;
        //        foreach (Customer c in customerData)
        //            total += Convert.ToDecimal(txtChargeAmount.Text);
        //        return total;
        //    }
        //}

        //// Total OVERALL charge (Method)
        //public decimal TotalCharge(Customer customerData, TextBox tbCharge)
        //{
        //    decimal total = 0;
        //    foreach (Customer c in customerData)
        //    {
        //        total += Convert.ToDecimal(txtChargeAmount.Text);
        //    }

        //    return total;
        //}

        public override string ToString()
        {
            return AccNumber.ToString() + ": " + CustomerName + ", " + CustomerType + " , "  + ChargeAmount.ToString("c");
        }

    } //End of Customer class
}// End of nameSpace

