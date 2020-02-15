using System;

namespace DesignPatterns._Facade
{
    public class Customer
    {
        public string customerName;

        // Constructor
        public Customer(string customerName)
        {
            this.customerName = customerName;
        }

        // Gets the name
        public string CustomerName
        {
            get { return customerName; }
        }
    }
}