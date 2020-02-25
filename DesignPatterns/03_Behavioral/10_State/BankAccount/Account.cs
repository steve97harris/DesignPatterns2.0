using System;

namespace DesignPatterns._03_Behavioral._10_State.BankAccount
{
    // Context class
    public class Account
    {
        private State mState;
        private string mOwner;
        
        // Constructor 
        public Account(string owner)
        {
            // New accounts are 'Silver' by default
            this.mOwner = owner;
            this.mState = new SilverState(this, 0.0);
        }
        
        // Properties
        public double Balance
        {
            get { return mState.Balance; }
        }

        public State State
        {
            get { return mState; }
            set { mState = value; }
        }

        public void Deposit(double amount)
        {
            mState.Deposit(amount);
            Console.WriteLine("Deposited {0:C} --- ", amount);
            Console.WriteLine(" Balance = {0:C}", this.Balance);
            Console.WriteLine(" Status = {0}", this.State.GetType().Name);
            Console.WriteLine("");
        }

        public void Withdraw(double amount)
        {
            mState.Withdraw(amount);
            Console.WriteLine("Withdrew {0:C} --- ", amount);
            Console.WriteLine(" Balance = {0:C}", this.Balance);
            Console.WriteLine(" Status = {0}\n", this.State.GetType().Name);
        }

        public void PayInterest()
        {
            mState.PayInterest();
            Console.WriteLine("Interest Paid --- ");
            Console.WriteLine(" Balance = {0:C}", this.Balance);
            Console.WriteLine(" Status = {0}\n", this.State.GetType().Name);
        }
    }
}