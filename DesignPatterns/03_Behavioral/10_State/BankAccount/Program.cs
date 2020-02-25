namespace DesignPatterns._03_Behavioral._10_State.BankAccount
{
    public class Program
    {
        static void Main()
        {
            // Open a new account
            Account account = new Account("Steve Harris");
            
            // Apply financial transactions
            account.Deposit(500.0);
            account.Deposit(300.0);
            account.Deposit(550.0);
            account.PayInterest();
            account.Withdraw(20.0);
            account.Withdraw(3000.0);
        }
    }
}