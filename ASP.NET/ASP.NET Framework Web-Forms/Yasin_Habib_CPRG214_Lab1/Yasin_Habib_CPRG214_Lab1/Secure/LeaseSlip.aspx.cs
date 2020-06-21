using Lab1_Data;
using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Yasin_Habib_CPRG214_Lab1.Secure
{
    public partial class LeaseSlip : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Context.User.Identity.IsAuthenticated)
            {
                lblWelcome.Text = $"Welcome {Context.User.Identity.Name}";
            }

            //Binding data to the dropdown box
            if (!IsPostBack)
            {
                var manager = new MarinaManager();
                cboDock.DataSource = manager.GetDock();
                cboDock.DataTextField = "Name";
                cboDock.DataValueField = "ID";
                cboDock.DataBind();
                //binding slip to grid
                grdSlip.DataSource = manager.GetSlip();
                grdSlip.DataBind();
                //binding lease slip
                grdLesSlp.DataSource = manager.GetLeaseSlip();
                grdLesSlp.DataBind();
            }
        }

        //Binding the dropdown with the grid
        protected void cboDock_SelectedIndexChanged(object sender, EventArgs e)
        {
            var db = new MarinaEntities();
            int dockID = Convert.ToInt32(cboDock.SelectedValue);
            grdSlip.DataSource = db.Slips.Where(s => s.DockID == dockID).ToList();
            grdSlip.DataBind();
        }
        //for saving lease
        protected void btnLease_Click(object sender, EventArgs e)
        {
            MarinaManager mm = new MarinaManager();
            int custID = int.Parse(Session["CustomerID"].ToString());
            int spId = int.Parse(txtSlipLease.Text);
            mm.SaveLease(custID, spId);
            //Shows the updated leased slip list
            grdLesSlp.DataSource = mm.GetLeaseSlip();
            grdLesSlp.DataBind();
        }
    }//Class
}//Namespace