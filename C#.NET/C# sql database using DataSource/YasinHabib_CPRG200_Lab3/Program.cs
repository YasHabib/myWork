using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YasinHabib_CPRG200_Lab3
{
    static class Program
    {
        //About: This program allow us to have a better understanding on adding database and error handling without loosing data.
        //Author: Yasin Habib
        //Creation date: April 23rd, 2020.
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmDatabaseViewer());
            }
            catch (NoNullAllowedException)  //This catches null values error if the user decides NOT to press save or delete 
                                            //and press any other button while adding product data.
            {
                MessageBox.Show("Please enter a non null value for 'Product Name' and 'Discontinued'", "Input Error");
                Application.Run(new frmDatabaseViewer());   //This will reopen the application automatically with any updated data
                                                            // after the user acknowledge the above error message.

            }
            catch (Exception ex) //Incase there are any other error
            {
                MessageBox.Show("Exception occurred while adding data: " +
                    ex.Message, ex.GetType().ToString());
                Application.Run(new frmDatabaseViewer());

            }
        }
    }
}

