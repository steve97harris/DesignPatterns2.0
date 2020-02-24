namespace DesignPatterns._03_Behavioral._08_Visitor.EmployeeInfoCentre
{
    public class Program
    {
        static void MainOLD()
        {
            Employees employees = new Employees();

            Employee jesse = new DistributionManager();
            Employee walt = new Cook();
            
            IVisitor payRise = new IncomeVisitor();
            IVisitor extraVacation = new VacationVisitor();
            
            employees.Add(jesse);
            employees.Add(walt);
            
            employees.Accept(payRise);
            walt.Accept(extraVacation);
        }
    }
}