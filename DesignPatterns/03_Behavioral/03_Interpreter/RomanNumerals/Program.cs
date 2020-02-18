using System;
using System.Collections.Generic;

namespace DesignPatterns._03_Behavioral._03_Interpreter.RomanNumerals
{
    public class Program
    {
        static void MainOLD()
        {
            string roman = "MCMXXVIII";
            Context context = new Context(roman);
            
            // Build the 'Parse tree'
            List<Expression> tree = new List<Expression>();
            tree.Add(new ThousandExp());
            tree.Add(new HundredExp());
            tree.Add(new TenExp());
            tree.Add(new OneExp());

            // Interpret
            foreach (Expression expression in tree)
            {
                expression.Interpret(context);
            }
            
            Console.WriteLine("{0} = {1}", roman, context.Output);
        }
    }
}