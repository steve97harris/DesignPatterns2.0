namespace DesignPatterns._03_Behavioral._08_Visitor.EmployeeInfoCentre
{
    // ConcreteElement class
    public class Employee : Element
    {
        private string mName;
        private double mIncome;
        private int mVacationDays;

        public Employee(string name, double income, int vacationDays)
        {
            this.mName = name;
            this.mIncome = income;
            this.mVacationDays = vacationDays;
        }

        // Gets or sets name
        public string Name
        {
            get => mName;
            set => mName = value;
        }

        // Get or sets income
        public double Income
        {
            get { return mIncome; }
            set { mIncome = value; }
        }
        
        // Gets or sets vacation days
        public int VacationDays
        {
            get => mVacationDays;
            set => mVacationDays = value;
        }
        
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}