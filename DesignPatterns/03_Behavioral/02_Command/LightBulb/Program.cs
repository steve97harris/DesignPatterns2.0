using System;

namespace DesignPatterns._03_Behavioral._02_Command.LightBulb
{
    public class Program
    {
        static void Main()
        {
            var bulb = new Bulb();
            
            var turnOn = new TurnOn(bulb);
            var turnOff = new TurnOff(bulb); 
            
            var remote = new RemoteControl();
            remote.Submit(turnOn);
            remote.Submit(turnOff);

            Console.ReadKey();
        }
    }
}