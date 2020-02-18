namespace DesignPatterns._03_Behavioral._03_Interpreter.RomanNumerals
{
    // Context - Contains information that is global to the interpreter.
    public class Context
    {
        private string input;
        private int output;
        
        // Constructor 
        public Context(string input)
        {
            this.input = input;
        }

        // Gets and Sets input and output
        public string Input
        {
            get => input;
            set => input = value;
        }

        public int Output
        {
            get => output;
            set => output = value;
        }
    }
}