using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YasinHabib_CPRG200_Lab1
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
                MessageBox.Show("Need to be a whole number", "Input Error 102");
                tbInput.SelectAll();
                tbInput.Focus();
            }
            else if (textValue < 0)      //Validating a negative value
            {
                valid = false;
                MessageBox.Show("Please enter a positive value","Input Error 101");
                tbInput.SelectAll();
                tbInput.Focus();
            }
            return valid;
        }
    }
}
