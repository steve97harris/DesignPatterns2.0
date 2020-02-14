using System;

namespace DesignPatterns._Facade
{
    public class Customer
    {
        public string customerName;

        public Customer(string customerName)
        {
            this.customerName = customerName;
        }

        public string CustomerName
        {
            get { return customerName; }
        }
    }
}