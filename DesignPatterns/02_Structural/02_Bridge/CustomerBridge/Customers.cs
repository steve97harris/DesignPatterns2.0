using System;

namespace DesignPatterns._Bridge
{
    // RefinedAbstraction class
    public class Customers : CustomersBase
    {
        // Constructor
        public Customers(string group) : base(group)
        {
            
        }

        public override void ShowAll()
        {
            // Add line separation
            Console.WriteLine();
            Console.WriteLine("--------------");
            base.ShowAll();
            Console.WriteLine("--------------");
        }
    }
}