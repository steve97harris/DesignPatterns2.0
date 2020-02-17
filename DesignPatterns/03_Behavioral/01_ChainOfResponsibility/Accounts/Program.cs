using DesignPatterns._basicconcepts;

namespace DesignPatterns._03_Behavioral._01_ChainOfResponsibility.Accounts
{
    public class Program
    {
        static void Main()
        {
            var bank = new Bank(100);        // Bank with balance 100
            var paypal = new PayPal(200);        // PayPal balance 200
            var bitcoin = new Bitcoin(500);        // Bitcoin balance 300
            
            bank.SetNext(paypal);        // Sets next account to check as PayPal
            paypal.SetNext(bitcoin);        // Sets next account to check as Bitcoin
            
            bank.Pay(259);        // Try to pay 259 using bank, if fails checks paypal, if paypal fails checks bitcoin.
        }
    }
}