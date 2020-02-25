namespace DesignPatterns._03_Behavioral._10_State.BankAccount
{
    // ConcreteStateB class
    // Silver indicates the account is a non-interest bearing state
    public class SilverState : State
    {
        private double mServiceFee;
        
        // Overloaded constructors
        public SilverState(State state) : this(state.Account, state.Balance)
        {
            
        }
        public SilverState(Account account, double balance)
        {
            this.account = account;
            this.balance = balance;
            Initialize();
        }

        public void Initialize()
        {
            interest = 0.0;
            lowerLimit = 0.0;
            upperLimit = 1000.0;
        }

        private void StateChangeCheck()
        {
            if (balance < lowerLimit)
            {
                account.State = new RedState(this);
            }
            else if (balance > upperLimit)
            {
                account.State = new GoldState(this);
            }
        }
        
        public override void Deposit(double amount)
        {
            balance += amount;
            StateChangeCheck();
        }

        public override void Withdraw(double amount)
        {
            balance = balance - amount;
            StateChangeCheck();
        }

        public override void PayInterest()
        {
            balance = balance + interest * balance;
            StateChangeCheck();
        }
    }
}