using System;

namespace DesignPatterns._Facade
{
    //Subsystem A
    public class Bank
    {
        public bool HasSufficientSavings(Customer c, int amount, int salary)
        {
            if (salary <= 20000)
            {
                Console.WriteLine("Customer salary: " + salary + " (Insufficient funds)");
                return false;
            }
            else
            {
                Console.WriteLine("Check bank for " + c.customerName);
                return true;
            }
        }
    }
    
    //Subsystem B
    public class Credit
    {
        public bool HasGoodCredit(Customer c)
        {
            Console.WriteLine("Check credit for " + c.customerName);
            return true;
        }
    }
    
    //Subsystem C
    public class Loan
    {
        public bool HasNoBadLoans(Customer c)
        {
            Console.WriteLine("Check for loans " +  c.customerName);
            return true;
        }
    }
}