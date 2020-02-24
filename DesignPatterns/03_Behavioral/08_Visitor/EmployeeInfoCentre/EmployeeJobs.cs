namespace DesignPatterns._03_Behavioral._08_Visitor.EmployeeInfoCentre
{
    public class DistributionManager : Employee
    {
        // Constructor
        public DistributionManager() : base("Jesse", 85000.0, 25)
        {
        }
    }
    
    public class Cook : Employee
    {
        // Constructor
        public Cook() : base("Walt", 100000.0, 25)
        {
        }
    }
}