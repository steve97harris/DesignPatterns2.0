namespace DesignPatterns._03_Behavioral._01_ChainOfResponsibility.Accounts
{
    public class Bank : Account
    {
        public Bank(decimal balance)
        {
            this.mBalance = balance;
        }
    }

    public class PayPal : Account
    {
        public PayPal(decimal balance)
        {
            this.mBalance = balance;
        }
    }

    public class Bitcoin : Account
    {
        public Bitcoin(decimal balance)
        {
            this.mBalance = balance;
        }
    }
}