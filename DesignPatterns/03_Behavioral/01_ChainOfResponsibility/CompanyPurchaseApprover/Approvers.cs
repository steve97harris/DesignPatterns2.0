using System;

namespace DesignPatterns._03_Behavioral._01_ChainOfResponsibility.CompanyPurchaseApprover
{
    // Concrete Handler
    class Director : Approver
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 10000.0)
            {
                Console.WriteLine("{0} approved request number {1}", this.GetType().Name, purchase.Number);        // Director approved request number ...
            }
            else if (mSuccessor != null)        // successor (Director) is not null
            {
                mSuccessor.ProcessRequest(purchase);        // successor process request subject to purchase
            }
        }
    }

    // Concrete Handler
    class President : Approver
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 100000.0)
            {
                Console.WriteLine("{0} approved request number {1}", this.GetType().Name, purchase.Number);
            }
            else
            {
                Console.WriteLine("Request number {0} requires an executive meeting!", purchase.Number);
            }
        }
    }

    // Concrete Handler
    class VicePresident : Approver
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 25000.0)
            {
                Console.WriteLine("{0} approved request number {1}", this.GetType().Name, purchase.Number);
            }
            else if (mSuccessor != null)
            {
                mSuccessor.ProcessRequest(purchase);
            }
        }
    }
}