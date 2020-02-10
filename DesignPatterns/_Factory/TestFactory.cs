using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._Factory
{
    class TestFactory
    {
        static void Main()
        {
            Console.WriteLine("Enter first number");
            string input = Console.ReadLine();
            double number1, number2;
            bool result = Double.TryParse(input, out number1);
            if(!result)
            {
                Console.WriteLine("Please enter a number");
                return;
            }

            Console.WriteLine("Enter second number");
            result = Double.TryParse(Console.ReadLine(), out number2);
            if (!result)
            {
                Console.WriteLine("Please enter a number");
                return;
            }

            Console.WriteLine("Enter add, subtract or divide bitch");
            CalculateFactory factory = new CalculateFactory();
            ICalculate objectA = factory.GetCalculation(Console.ReadLine());
            
            // Divide objectA = new Divide();
            objectA.Calculate(number1, number2);
            Main();
        }
    }
}