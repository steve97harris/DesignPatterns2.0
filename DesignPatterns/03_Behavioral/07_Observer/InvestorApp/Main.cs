using System;

namespace DesignPatterns._03_Behavioral._07_Observer.InvestorApp
{
    public class Program
    {
        static void MainOLD()
        {
            // Create IBM stock and attach investors
            Stock ibm = new IBM("IBM", 120.00);
            ibm.Attach(new Investor("Frank"));
            ibm.Attach(new Investor("Charlie"));
            
            Stock deloitte = new Deloitte("Deloitte", 124.30);
            deloitte.Attach(new Investor("Andy"));
            
            // Fluctuating prices will notify investors
            ibm.Price = 120.10;
            ibm.Price = 120.30;
            deloitte.Price = 124.70;
            ibm.Price = 121.10;
            ibm.Price = 120.80;
            deloitte.Price = 124.40;
            ibm.Price = 120.90;
        }
    }
}