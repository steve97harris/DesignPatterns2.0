using System.Collections.Generic;

namespace DesignPatterns._02_Structural._03_Composite.Employee
{
    public class Organisation
    {
        protected List<IEmployee> employees;

        public Organisation()
        {
            employees = new List<IEmployee>();
        }

        public void AddEmployee(IEmployee employee)
        {
            employees.Add(employee);
        }

        public float GetNetSalaries()
        {
            float netSalary = 0;
            
            foreach (var x in employees)
            {
                netSalary = netSalary + x.GetSalary();
            }

            return netSalary;
        }
    }
}