namespace DesignPatterns._03_Behavioral._10_State.BankAccount
{
    public abstract class State
    {
        
        
        public abstract void Deposit(double amount);
        public abstract void Withdraw(double amount);
        public abstract void PayInterest();
    }
}