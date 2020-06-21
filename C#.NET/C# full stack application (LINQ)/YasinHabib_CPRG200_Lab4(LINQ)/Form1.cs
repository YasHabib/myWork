using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YasinHabib_CPRG200_Lab4_LINQ_
{
    public partial class Form1 : Form
    {
        private OrderDataClassDataContext db = new OrderDataClassDataContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //order_DetailsDataGridView.DataSource = db.Order_Details;
            //order_DetailsBindingSource.DataSource = db.Order_Details;
            orderBindingSource.DataSource = db.Orders;

            //customerIDTextBox.Text = db.CustomerID;
        }
    }
}
