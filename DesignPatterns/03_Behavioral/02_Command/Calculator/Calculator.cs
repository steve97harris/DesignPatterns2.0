using System;

namespace DesignPatterns._03_Behavioral._02_Command.Calculator
{
    // Receiver class 
    public class Calculator
    {
        private int mCurrentValue = 0;

        public void Operation(char @operator, int operand)
        {
            switch (@operator)
            {
                case '+':
                    mCurrentValue += operand;
                    break;
                case '-':
                    mCurrentValue -= operand;
                    break;
                case '*':
                    mCurrentValue *= operand;
                    break;
                case '/':
                    mCurrentValue /= operand;
                    break;
            }
            
            Console.WriteLine("Current value = {0,3} (following {1} {2})", mCurrentValue, @operator, operand);
            // @operator is each different case; '+', '-', '*', '/'.
            // operand is the particular integer the user inputs. 
        }
    }
}