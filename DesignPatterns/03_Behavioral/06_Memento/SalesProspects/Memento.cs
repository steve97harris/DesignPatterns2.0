namespace DesignPatterns._03_Behavioral._06_Memento.SalesProspects
{
    // Memento class
    public class Memento
    {
        public string mName;
        public string mPhone;
        public double mBudget;
        
        // Constructor
        public Memento(string name, string phone, double budget)
        {
            this.mName = name;
            this.mPhone = phone;
            this.mBudget = budget;
        }

        public string Name
        {
            get { return mName; }
            set { mName = value; }
        }

        public string Phone
        {
            get { return mPhone; }
            set { mPhone = value; }
        }

        public double Budget
        {
            get { return mBudget; }
            set { mBudget = value; }
        }
    }
}