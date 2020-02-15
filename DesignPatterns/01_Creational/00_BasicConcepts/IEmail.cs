using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._basicconcepts
{
    interface IEmail
    {
        void SendEmail();
    }

    class OutlookEmail : IEmail
    {
        public void SendEmail()
        {
            Console.WriteLine("Outlook Email Sent");               
        }
    }

    class WebserviceEmail : IEmail
    {
        public void SendEmail()
        {
            Console.WriteLine("Webservice Email Sent");               
        }
    }
}