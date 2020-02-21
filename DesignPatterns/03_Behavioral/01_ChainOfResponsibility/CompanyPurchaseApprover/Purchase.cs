namespace DesignPatterns._03_Behavioral._01_ChainOfResponsibility.CompanyPurchaseApprover
{
    public class Purchase
    {
        private int mNumber;
        private double mAmount;
        private string mPurpose;

        public Purchase(int number, double amount, string purpose)
        {
            this.mNumber = number;
            this.mAmount = amount;
            this.mPurpose = purpose;
        }

        public int Number
        {
            get => mNumber;
            set => mNumber = value;
        }

        public double Amount
        {
            get => mAmount;
            set => mAmount = value;
        }

        public string Purpose
        {
            get => mPurpose;
            set => mPurpose = value;
        }
    }
}