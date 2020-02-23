using System;
using System.Collections.Generic;

namespace DesignPatterns._03_Behavioral._07_Observer.InvestorApp
{
    // Subject class
    public abstract class Stock
    {
        private string mSymbol;
        private double mPrice;
        private List<IInvestor> mInvestors = new List<IInvestor>();
        
        // Constructor 
        public Stock(string symbol, double price)
        {
            this.mSymbol = symbol;
            this.mPrice = price;
        }

        public void Attach(IInvestor investor)
        {
            mInvestors.Add(investor);
        }

        public void Detach(IInvestor investor)
        {
            mInvestors.Remove(investor);
        }

        public void Notify()
        {
            foreach (IInvestor investor in mInvestors)
            {
                investor.Update(this);
            }
            
            Console.WriteLine("");
        }
        
        // Gets the symbol
        public string Symbol
        {
            get { return mSymbol; }
        }
        
        // Gets and sets the price
        public double Price
        {
            get { return mPrice; }
            set {
                if (mPrice != value)        // If current price is not equal the value
                {
                    mPrice = value;        // Set current price as new value
                    Notify();            // Notify investors
                } 
            }
        }
    }
}