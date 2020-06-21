using Lab1_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Yasin_Habib_CPRG214_Lab1
{
    public partial class Registration : System.Web.UI.Page
    {
        //public bool IsRegistered { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            txtPhone.Visible = false;
            txtCity.Visible = false;
            lblCity.Visible = false;
            lblPhone.Visible = false;
            btnSubmit.Visible = false;

        }
        //Login
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            //Matching the name
            MarinaManager newMM = new MarinaManager();
            var FirstName = txtFirstName.Text;
            var LastName = txtLastName.Text;

            Customer cust = newMM.Authinticate(FirstName, LastName);
            if(cust != null)
            {
                //Creating session
                Session["FullName"] = FirstName + " " + LastName;
                Session["CustomerID"] = cust.ID;

                FormsAuthentication.RedirectFromLoginPage(FirstName + " " + LastName+ " ", false);
                Response.Redirect("~/Secure/LeaseSlip");
            }
            else
            {
                //Error if the user is not registered
                Response.Write("<script>alert('User does not exist, please register first.');</script>");
                //For registering
                txtPhone.Visible = true;
                txtCity.Visible = true;
                lblCity.Visible = true;
                lblPhone.Visible = true;
                btnSubmit.Visible = true;
            }
        }

        //Registering        
        protected void btnRegister_Click(object sender, EventArgs e)
        {
            //Making other field visible so the customer can register
            txtPhone.Visible = true;
            txtCity.Visible = true;
            lblCity.Visible = true;
            lblPhone.Visible = true;
            btnSubmit.Visible = true;
        }

        //Adding customer
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            var customer = new Customer
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                City = txtCity.Text,
                Phone = txtPhone.Text
            };

                var db = new MarinaEntities();
                db.Customers.Add(customer);
                db.SaveChanges();

            Response.Redirect("~/Registration");

        }
    }
}

