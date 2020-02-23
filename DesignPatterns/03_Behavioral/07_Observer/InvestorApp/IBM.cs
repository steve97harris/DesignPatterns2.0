namespace DesignPatterns._03_Behavioral._07_Observer.InvestorApp
{
    // ConcreteSubject class
    public class IBM : Stock
    {
        public IBM(string symbol, double price) : base(symbol, price)
        {
        }
    }
    
    public class Deloitte : Stock
    {
        public Deloitte(string symbol, double price) : base(symbol, price)
        {
        }
    }
}