using System;

namespace DesignPatterns._03_Behavioral._01_ChainOfResponsibility.Accounts
{
    public class Account
    {
        private Account mSuccessor;
        protected decimal mBalance;
        
        public void SetNext(Account account)        // Sets next account to check.
        {
            this.mSuccessor = account;            
        }

        public void Pay(decimal amountToPay)
        {
            if (CanPay(amountToPay))        // If balance is greater than amount to pay; console write paid.
            {
                Console.WriteLine($"Paid {amountToPay:c} using {this.GetType().Name}");
            }
            else if (this.mSuccessor != null)        // Else if current successor is not null; successor Pay(amount to pay).
            {
                Console.WriteLine($"Cannot pay using {this.GetType().Name}. Proceeding...");
                mSuccessor.Pay(amountToPay);
            }
            else         // else "None of the accounts have enough balance"
            {
                throw new Exception("None of the accounts have enough balance");
            }
        }
        
        private bool CanPay(decimal amount)
        {
            return mBalance >= amount;        // Check current balance is greater than amount to pay.
        }
    }
}