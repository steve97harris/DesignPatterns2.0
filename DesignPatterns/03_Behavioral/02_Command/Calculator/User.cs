using System;
using System.Collections.Generic;

namespace DesignPatterns._03_Behavioral._02_Command.Calculator
{
    // Invoker class
    public class User
    {
        private Calculator mCalculator = new Calculator();
        private List<Command> mCommands = new List<Command>();
        private int mCurrent = 0;

        public void Redo(int levels)
        {
            Console.WriteLine("\n------ Redo {0} levels ", levels);
            
            // Perform redo operation
            for (int i = 0; i < levels; i++)
            {
                if (mCurrent < mCommands.Count - 1)
                {
                    Command command = mCommands[mCurrent++];
                    command.Execute();
                }
            }
        }

        public void Undo(int levels)
        {
            Console.WriteLine("\n----- Undo {0} levels ", levels);
            // Perform undo operation 
            for (int i = 0; i < levels; i++)
            {
                if (mCurrent > 0)
                {
                    Command command = mCommands[--mCurrent] as Command;        // Sets command to previous command (check this)
                    command.UnExecute();
                }
            }
        }

        public void Compute(char @operator, int operand)
        {
            // Create command operation and execute it
            Command command = new CalculatorCommand(mCalculator, @operator, operand);
            command.Execute();
            
            // Add command to undo list
            mCommands.Add(command);
            mCurrent++;
        }
    }
}