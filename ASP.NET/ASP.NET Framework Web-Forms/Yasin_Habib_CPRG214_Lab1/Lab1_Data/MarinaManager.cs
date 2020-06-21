using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Author: Yasin Habib
//Assisted by: Asim Ali(Classmate)
//Purpose: to bulild a dynamic full stack website where data can be added to the database from the website. 
//Date created: May 7th 2020

namespace Lab1_Data
{
    public class MarinaManager
    {
        //Dock
        public IList<Dock> GetDock()
        {
            var db = new MarinaEntities();
            var dock = db.Docks.ToList();
            return dock;
        }
        //Slip
        public IList<Slip> GetSlip ()
        {
            var db = new MarinaEntities();
            var slp = db.Slips.ToList();
            return slp;
        }
        //Lease slip
        public IList<Lease> GetLeaseSlip()
        {
            var db = new MarinaEntities();
            var lesSlp = db.Leases.ToList();
            return lesSlp;
        }

        //Saving lease
        public void SaveLease(int custId, int slipId)
        {
            var db = new MarinaEntities();

            Lease L = new Lease();
            L.CustomerID = custId;
            L.SlipID = slipId;
            db.Leases.Add(L);
            db.SaveChanges();
        }

        // for login (with matching name from the database)
        public Customer Authinticate(string firstName, string lastName)
        {
            var db = new MarinaEntities();
            var auth = db.Customers.FirstOrDefault(c => c.FirstName == firstName && c.LastName == lastName);
            return auth;
        }

    }
}
