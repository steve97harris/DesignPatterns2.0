using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._basicconcepts
{
    class Staff
    {
        private int staffID;
        private string staffName;
        public double salary {get; set;} 
        public int grade {get; set;}
        private string company = "IBM";

        IEmail email;

        public Staff(int staffID, string staffName, IEmail email)
        {
            this.staffID = staffID;
            this.staffName = staffName;
            this.email = email;
        }

        public void NotifyStaff()
        {
            email.SendEmail();
        }
    }

    class TestStaff
    { 
        static void MainOLD()
        {
            IEmail email = new OutlookEmail();
            Staff objectA = new Staff(100,"Jeff", email);
            // objectA.staffID = 100;
            // objectA.staffName = "Jeff";
            objectA.salary = 200000;
            objectA.NotifyStaff();

            email = new WebserviceEmail();
            Staff objectB = new Staff(200,"Steve", email);
            objectB.NotifyStaff();
        }
    }
}






