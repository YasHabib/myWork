using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//About: This program allow us to have a better understanding on adding database and error handling without loosing data.
//Author: Yasin Habib
//Creation date: April 23rd, 2020.
namespace YasinHabib_CPRG200_Lab3
{
    public partial class frmDatabaseViewer : Form
    {
        public frmDatabaseViewer()
        {
            InitializeComponent();
        }

        //This catches concurrency errors and null values in a non null column while saving the data. 

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //try
            //{
                this.Validate();
                this.productsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.northWindDataSet);
            //}
            //catch (DBConcurrencyException) //Concurrency
            //{
            //    MessageBox.Show("The selected data has be modified/deleted by another user. \n Please try again.", "Concurrency Exception");
            //    this.productsTableAdapter.Fill(this.northWindDataSet.Products);
            //    this.order_DetailsTableAdapter.Fill(this.northWindDataSet.Order_Details);
            //}
            //catch (Exception ex) //Any other error, this catches null value errors
            //{
            //    MessageBox.Show("Exception occurred while saving data: " +
            //        ex.Message, ex.GetType().ToString());
            //}
        }


        private void Form1_Load(object sender, EventArgs e)
        {

                // TODO: This line of code loads data into the 'northWindDataSet.Order_Details' table. You can move, or remove it, as needed.
                this.order_DetailsTableAdapter.Fill(this.northWindDataSet.Order_Details);
                // TODO: This line of code loads data into the 'northWindDataSet.Categories' table. You can move, or remove it, as needed.
                this.categoriesTableAdapter.Fill(this.northWindDataSet.Categories);
                // TODO: This line of code loads data into the 'northWindDataSet.Suppliers' table. You can move, or remove it, as needed.
                this.suppliersTableAdapter.Fill(this.northWindDataSet.Suppliers);
                // TODO: This line of code loads data into the 'northWindDataSet.Products' table. You can move, or remove it, as needed.
                this.productsTableAdapter.Fill(this.northWindDataSet.Products);
        }

    }
}
