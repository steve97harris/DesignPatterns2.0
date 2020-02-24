using System;
using System.Collections.Generic;

namespace DesignPatterns._03_Behavioral._08_Visitor.EmployeeInfoCentre
{
    // ObjectStructure class
    public class Employees
    {
        private List<Employee> mEmployees = new List<Employee>();

        public void Add(Employee employee)
        {
            mEmployees.Add(employee);
        }

        public void Remove(Employee employee)
        {
            mEmployees.Remove(employee);
        }

        public void Accept(IVisitor visitor)
        {
            foreach (Employee emp in mEmployees)
            {
                emp.Accept(visitor);        // Accept Income or Vacation Visit
            }
            Console.WriteLine();
        }
    }
}