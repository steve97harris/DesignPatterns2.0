using System;

namespace DesignPatterns._02_Structural._03_Composite.Employee
{
    public class Program
    {
        static void Main()
        {
            // Arrange Employees, Organization and add emplyees
            var developer = new Developer("Muthafucka Jones", 100000);
            var designer = new Designer("Jeff Goldbloom", 900000);
            
            var organisation = new Organisation();
            organisation.AddEmployee(designer);
            organisation.AddEmployee(developer);
            
            Console.WriteLine($"Net Salary of Employees in Organisation is {organisation.GetNetSalaries():c}");
        }
    }
}