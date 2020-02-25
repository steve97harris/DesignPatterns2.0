using System;

namespace DesignPatterns._03_Behavioral._10_State.BankAccount
{
    // ConcreteStateA class 
    // Red indicates the account is overdrawn
    public class RedState : State
    {
        private double mServiceFee;
        
        // Constructor
        public RedState(State state)
        {
            this.account = state.Account;
            this.balance = state.Balance;        // this.(Field) = state.(Property)
            Initialize();
        }

        public void Initialize()
        {
            // Should come from a data source
            interest = 0.0;
            lowerLimit = -100.00;
            upperLimit = 0.0;
            mServiceFee = 15.00;
        }

        private void StateChangeCheck()
        {
            if (balance > upperLimit)
            {
                account.State = new SilverState(this);
            }
        }

        public override void Deposit(double amount)
        {
            balance += amount;
            StateChangeCheck();
        }

        public override void Withdraw(double amount)
        {
            amount = amount - mServiceFee;
            Console.WriteLine("No funds available for withdrawal!");
        }

        public override void PayInterest()
        {
            // No interest is paid.
        }
    }
}