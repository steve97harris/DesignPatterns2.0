using System;
using System.Collections.Generic;

namespace DesignPatterns._Bridge
{
    // ConcreteImplementor class
    public class CustomersData : DataObject
    {
        private List<string> customers = new List<string>();
        private int current = 0;

        public CustomersData()
        {
            customers.Add("Jeff");
            customers.Add("Billy");
            customers.Add("Steve");
            customers.Add("Ted");
            customers.Add("Frank");
        }

        public override void NextRecord()
        {
            if (current <= customers.Count - 1)
            {
                current++;
            }
        }

        public override void PriorRecord()
        {
            if (current > 0)
            {
                current--;
            }
        }

        public override void AddRecord(string customer)
        {
            customers.Add(customer);
        }

        public override void DeleteRecord(string customer)
        {
            customers.Remove(customer);
        }

        public override void ShowRecord()
        {
            Console.WriteLine(customers[current]);
        }

        public override void ShowAllRecord()
        {
            foreach (string customer in customers)
            {
                Console.WriteLine(" " + customer);    
            }
        }
    }
}