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
        
        public override void Execute()
        {
            
        }

        public override void UnExecute()
        {
            
        }
    }
}