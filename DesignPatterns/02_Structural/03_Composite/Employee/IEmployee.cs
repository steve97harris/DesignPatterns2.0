namespace DesignPatterns._02_Structural._03_Composite.Employee
{
    public interface IEmployee
    {
        float GetSalary();
        string GetRole();
        string GetName();
    }

    class Developer : IEmployee
    {
        private string mName;
        private float mSalary;

        public Developer(string name, float salary)
        {
            this.mName = name;
            this.mSalary = salary;
        }

        public float GetSalary()
        {
            return this.mSalary;
        }

        public string GetRole()
        {
            return "Developer";
        }

        public string GetName()
        {
            return this.mName;
        }
    }

    class Designer : IEmployee
    {
        private string mName;
        private float mSalary;

        public Designer(string name, float salary)
        {
            this.mName = name;
            this.mSalary = salary;
        }

        public float GetSalary()
        {
            return this.mSalary;
        }

        public string GetRole()
        {
            return "Designer";
        }

        public string GetName()
        {
            return this.mName;
        }
    }
}