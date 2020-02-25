namespace DesignPatterns._03_Behavioral._10_State.BankAccount
{
    // ConcreteStateC 
    // Gold indicates an interest bearing state
    public class GoldState : State
    {
        // Overloaded constructors
        public GoldState(State state) : this(state.Account, state.Balance)        
        {
            
        }

        public GoldState(Account account, double balance)
        {
            this.balance = balance;
            this.account = account;
            Initialize();
        }

        public void Initialize()
        {
            interest = 0.05;
            lowerLimit = 1000.0;
            upperLimit = 10000000.0;
        }
        
        private void StateChangeCheck()
        {
            if (balance < 0.0)
            {
                account.State = new RedState(this);
            }
            else if (balance < lowerLimit)
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
            balance -= amount;
            StateChangeCheck();
        }

        public override void PayInterest()
        {
            balance = balance + interest * balance;
            StateChangeCheck();
        }
    }
}