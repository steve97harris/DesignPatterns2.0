using System;
using System.CodeDom;

namespace DesignPatterns._Facade
{
    // Facade class
    public class Mortgage
    {
        private Bank bank = new Bank();
        private Credit credit = new Credit();
        private Loan loan = new Loan();

        public bool IsEligible(Customer customer, int amount, int salary)
        {
            Console.WriteLine("{0} applies for {1} loan ", customer.customerName, amount);

            bool eligible = true;

            if (!bank.HasSufficientSavings(customer, amount, salary))
            {
                eligible = false;
            }
            else if (!credit.HasGoodCredit(customer))
            {
                eligible = false;
            }
            else if (!loan.HasNoBadLoans(customer))
            {
                eligible = false;
            }
            return eligible;
        }
    }
}