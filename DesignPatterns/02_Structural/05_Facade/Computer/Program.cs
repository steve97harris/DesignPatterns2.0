using System;

namespace DesignPatterns._02_Structural._05_Facade.Computer
{
    public class Program
    {
        static void Main()
        {
            var computer = new ComputerFacade(new Computer());
            computer.TurnOn();
            Console.WriteLine();
            computer.Lock();
            Console.WriteLine();
            computer.TurnOff();

            Console.ReadLine();
        }
    }
}