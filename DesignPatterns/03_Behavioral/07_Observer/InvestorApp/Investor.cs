using System;

namespace DesignPatterns._03_Behavioral._07_Observer.InvestorApp
{
    // ConcreteObserver class
    public class Investor : IInvestor
    {
        private string mName;
        private Stock mStock;
        
        // Constructor
        public Investor(string name)
        {
            this.mName = name;
        }
        
        public void Update(Stock stock)
        {
            Console.WriteLine("Notified {0} of {1}'s " + "change to {2:C}", mName, stock.Symbol, stock.Price);
        }
        
        // Gets or sets the stock
        public Stock Stock
        {
            get { return mStock; }
            set { mStock = value; }
        }
    }
}