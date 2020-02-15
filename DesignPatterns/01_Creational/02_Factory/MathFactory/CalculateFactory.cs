using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._Factory
{
    public class CalculateFactory
    {
        public ICalculate GetCalculation(string type)
        {
            ICalculate objectA = null;

            if (type.ToLower().Equals("add"))
            {
                objectA = new Add();
            }
            else if (type.ToLower().Equals("subtract"))
            {
                objectA = new Subtract();
            }
            else if (type.ToLower().Equals("divide"))
            {
                objectA = new Divide();
            }
            else
            {
                Console.WriteLine("Invalid");
            }
            return objectA;
        }
    }
}