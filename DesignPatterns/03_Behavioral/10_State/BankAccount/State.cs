namespace DesignPatterns._03_Behavioral._10_State.BankAccount
{
    // State abstract class
    public abstract class State
    {
        protected Account account;
        protected double balance;

        protected double interest;
        protected double lowerLimit;
        protected double upperLimit;
        
        // Properties
        public Account Account
        {
            get { return account; }
            set { account = value; }
        }

        public double Balance
        {
            get => balance;
            set => balance = value;
        }

        public abstract void Deposit(double amount);
        public abstract void Withdraw(double amount);
        public abstract void PayInterest();
    }
}