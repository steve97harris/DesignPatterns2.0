namespace DesignPatterns._03_Behavioral._01_ChainOfResponsibility.CompanyPurchaseApprover
{
    // Handler class
    public abstract class Approver
    {
        protected Approver mSuccessor;        

        public void SetSuccessor(Approver successor)        // Creating function to set the next successor.
        {
            this.mSuccessor = successor;
        }

        public abstract void ProcessRequest(Purchase purchase);
    }
}