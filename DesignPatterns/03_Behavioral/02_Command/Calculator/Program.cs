﻿using System;

namespace DesignPatterns._03_Behavioral._02_Command.Calculator
{
    public class Program
    {
        static void MainOLD()
        {
            User user = new User();
            
            user.Compute('+', 100);
            user.Compute('-',50);
            user.Compute('*',10);
            user.Compute('/',2);
            
            user.Undo(4);
            
            user.Redo(3);

            Console.ReadKey();
        }
    }
}