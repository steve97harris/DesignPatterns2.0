using System.Net.NetworkInformation;

namespace DesignPatterns._03_Behavioral._03_Interpreter.RomanNumerals
{
    // Abstract Expression - Declares an interface for executing an operation. 
    public abstract class Expression
    {
        public abstract string One();
        public abstract string Four();
        public abstract string Five();
        public abstract string Nine();
        public abstract int Multiplier();
        
        public void Interpret(Context context)
        {
            if (context.Input.Length == 0)
                return;

            if (context.Input.StartsWith(Nine()))
            {
                context.Output += (9 * Multiplier());        // Output = output + 9(Multiplier)
                context.Input = context.Input.Substring(2);        // Retrieves a substring from this instance. The substring starts at a specified character position and continues to the end of the string.
            }
            else if (context.Input.StartsWith(Four()))
            {
                context.Output += (4 * Multiplier());
                context.Input = context.Input.Substring(2);
            }
            else if (context.Input.StartsWith(Five()))
            {
                context.Output += (5 * Multiplier());
                context.Input = context.Input.Substring(1);
            }

            while (context.Input.StartsWith(One()))
            {
                context.Output += (Multiplier());
                context.Input = context.Input.Substring(1);
            }
        }
    }
}