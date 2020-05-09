using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YasinHabib_CPRG200_lab2
{
    class Validation
    {
        public static bool ValidNegWhole(TextBox tbInput)
        {
            bool valid = true;
            int textValue;
            if (!Int32.TryParse(tbInput.Text, out textValue)) //Validating whole number
            {
                valid = false;
                MessageBox.Show("Need to be a whole number", "Invalid Input");
                tbInput.SelectAll();
                tbInput.Focus();
            }
            else if (textValue < 0)      //Validating a negative value
            {
                valid = false;
                MessageBox.Show("Please enter a positive value","Invalid Input");
                tbInput.SelectAll();
                tbInput.Focus();
            }
            return valid;
        }
    }
}
