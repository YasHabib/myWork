using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YasinHabib_CPRG200_lab2
{
    public class Customer
    {
        //from lab 1
        const int THRESHOLD = 1000;
        const decimal RES_CONST = 6;
        const decimal RES_RATE = 0.052m;
        const decimal COMM_CONST = 60;
        const decimal COMM_RATE = 0.045m;
        const decimal IND_ON_PEAK = 76;
        const decimal IND_ON_PEAK_RATE = 0.065m;
        const decimal IND_OFF_PEAK = 40;
        const decimal IND_OFF_PEAK_RATE = 0.028m;

        //data for lab 2
        private int accNo;
        //string custName;
        //string custType;
        //private decimal charge;

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
                    MessageBox.Show("The negative value you have entered for Account number has been converted to positive");
                }
                    accNo = value;
                
            }
        }//END of AccNumber

        public string CustomerName
        { get; set; }

        public string CustomerType
        { get; set;}

        public decimal ChargeAmount
        { get;  set; }

        //Constructor
        public Customer(int acc = 0, string cn = "N/A", string ct = "N/A", decimal ch = 0.0m)
        {
            AccNumber = acc;
            CustomerName = cn;
            CustomerType = ct;
            ChargeAmount = ch;
        }

        //Charge amount calculation


        //public static decimal ChargeTotal(ComboBox cbo, TextBox tb1, TextBox tb2)
        //{
        //    //from lab 1
        //    const int THRESHOLD = 1000;
        //    const decimal RES_CONST = 6;
        //    const decimal RES_RATE = 0.052m;
        //    const decimal COMM_CONST = 60;
        //    const decimal COMM_RATE = 0.045m;
        //    const decimal IND_ON_PEAK = 76;
        //    const decimal IND_ON_PEAK_RATE = 0.065m;
        //    const decimal IND_OFF_PEAK = 40;
        //    const decimal IND_OFF_PEAK_RATE = 0.028m;
        //    decimal kw = Convert.ToDecimal(tb1.Text);
        //    decimal offPeak = Convert.ToDecimal(tb2.Text);
        //    decimal totalCharge = 0;

        //    switch (cbo.SelectedIndex)
        //    {
        //        //For type R
        //        case 1:
        //            offPeak = 0;
        //            totalCharge = Convert.ToDecimal(RES_CONST + (RES_RATE * kw));
        //        break;
        //        //for type C
        //        case 2:
        //            offPeak = 0;
        //            totalCharge = COMM_CONST;
        //            if (kw > THRESHOLD)
        //            {
        //                totalCharge += (kw - THRESHOLD) * COMM_RATE;
        //            }
        //        break;
        //        //for type I
        //        case 3:
        //            //On peak
        //            decimal onPeakCharge = IND_ON_PEAK;
        //            if (kw > THRESHOLD)
        //            {
        //                onPeakCharge += (kw - THRESHOLD) * IND_ON_PEAK_RATE;
        //            }
        //            //off peak
        //            decimal offPeakCharge = IND_OFF_PEAK;
        //            if (offPeak > THRESHOLD)
        //            {
        //                offPeakCharge += (offPeak - THRESHOLD) * IND_OFF_PEAK_RATE;
        //            }
        //            totalCharge = onPeakCharge + offPeakCharge;
        //        break;
        //        default:
        //            cbo.SelectedIndex = 0;
        //        break;
     
        //    }
        //    return totalCharge;
        //}
        ////End of ChargeAmount


        //For type R
    public static decimal ChargeR(TextBox tbKW)
    {
        decimal kw = Convert.ToDecimal(tbKW.Text);
        decimal totalRCharge = Convert.ToDecimal(RES_CONST + (RES_RATE * kw)); 
        return totalRCharge;
    }

    //for type C
    public static decimal ChargeC(TextBox tbKW)
    {
        decimal kw = Convert.ToDecimal(tbKW.Text); 
        decimal totalCCharge;
        if (kw > THRESHOLD)
        {
            totalCCharge = Convert.ToDecimal(COMM_CONST + (kw - THRESHOLD) * COMM_RATE);
        }
        else
            totalCCharge = COMM_CONST;
        return totalCCharge;
    }

    //for Type I
    public static decimal ChargeI(TextBox onKW, TextBox offKW)
    {
        decimal onKW1 = Convert.ToDecimal(onKW.Text);
        decimal offKW1 = Convert.ToDecimal(offKW.Text);
        decimal totalICharge;

            //On peak
            decimal onPeakCharge = IND_ON_PEAK;
            if (onKW1 > THRESHOLD)
            {
                onPeakCharge += (onKW1 - THRESHOLD) * IND_ON_PEAK_RATE;
            }
            //off peak
            decimal offPeakCharge = IND_OFF_PEAK;
            if (offKW1 > THRESHOLD)
            {
                offPeakCharge += (offKW1 - THRESHOLD) * IND_OFF_PEAK_RATE;
            }
            totalICharge = onPeakCharge + offPeakCharge;
            return totalICharge;
    }


        public override string ToString()
        {
            return AccNumber.ToString() + ": " + CustomerName + ", " + CustomerType + " , "  + ChargeAmount.ToString("c");
        }

    } //End of Customer class
}// End of nameSpace

