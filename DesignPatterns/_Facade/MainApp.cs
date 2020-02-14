using System;

namespace DesignPatterns._Facade
{
    public class MainApp
    {
        public static void MainOLD()
        {
            // Facade
            Mortgage mortgage = new Mortgage();
            
            // Evaluate mortgage eligibility for customer
            Customer customer = new Customer("Charlie");
            bool eligible = mortgage.IsEligible(customer, 125000, 15000);
            
            Console.WriteLine("\n" + customer.customerName + " has been " + (eligible ? "Approved" : "Rejected") + "\n");
            
            customer = new Customer("Frank");
            eligible = mortgage.IsEligible(customer, 90000, 25000);
            
            Console.WriteLine("\n" + customer.customerName + " has been " + (eligible ? "Approved" : "Rejected") + "\n");        // ? = if else statement
        }
    }
}