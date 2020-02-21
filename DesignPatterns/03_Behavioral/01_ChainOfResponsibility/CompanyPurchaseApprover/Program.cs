using System;

namespace DesignPatterns._03_Behavioral._01_ChainOfResponsibility.CompanyPurchaseApprover
{
    public class Program
    {
        static void Main()
        {
            Approver larry = new Director();
            Approver david = new VicePresident();
            Approver jim = new President();
            
            larry.SetSuccessor(david);        // Setting Larry's successor as David (Vice President)
            david.SetSuccessor(jim);          // Setting David's successor as Jim (President)
            
            Purchase p = new Purchase(101, 350.0, "Cleaning offices");
            larry.ProcessRequest(p);
            
            p = new Purchase(102, 32590.0, "New computers for staff");
            larry.ProcessRequest(p);
            
            p = new Purchase(103, 1222300.0, "Company retreat to Barbados");
            larry.ProcessRequest(p);

            Console.ReadKey();
        }
    }
}