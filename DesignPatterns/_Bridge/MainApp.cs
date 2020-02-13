using System;

namespace DesignPatterns._Bridge
{
    public class MainApp
    {
        public static void MainOLD()
        {
            // Create RefinedAbstraction
            Customers customers = new Customers("England");
            
            // Set ConcreteImplementor
            customers.Data = new CustomersData();
            
            // Exercise the bridge
            customers.Show();
            customers.Next();
            customers.Show();
            customers.Next();
            customers.Show();
            customers.Prior();
            customers.Show();
            customers.Add("Rick");
            
            customers.ShowAll();
            
            customers.Delete("Frank");
            customers.Add("Frank Jr");
            customers.ShowAll();
            
            
            // Wait for user
            Console.ReadKey();
        }
    }
}