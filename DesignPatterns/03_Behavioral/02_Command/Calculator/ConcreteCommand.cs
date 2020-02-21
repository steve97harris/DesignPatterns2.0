using System;

namespace DesignPatterns._03_Behavioral._02_Command.Calculator
{
    // Concrete Command class
    public class CalculatorCommand : Command
    {
        private char mOperator;
        private int mOperand;
        private Calculator mCalculator;

        public CalculatorCommand(Calculator calculator, char @operator, int operand)
        {
            this.mCalculator = calculator;
            this.mOperator = @operator;
            this.mOperand = operand;
        }

        public char Operator
        {
            set { mOperator = value; }
        }

        public int Operand
        {
            set { mOperand = value; }
        }

        public override void Execute()
        {
            mCalculator.Operation(mOperator, mOperand);        // Setting current calculation operation as current operator and operand. 
        }

        public override void UnExecute()
        {
            mCalculator.Operation(Undo(mOperator),mOperand);
        }

        public char Undo(char @operator)
        {
            switch (@operator)
            {
                case '+':
                    return '-';
                case '-':
                    return '+';
                case '*':
                    return '/';
                case '/':
                    return '*';
                default: 
                    throw new ArgumentException("@operator");
            }
        }
    }
}