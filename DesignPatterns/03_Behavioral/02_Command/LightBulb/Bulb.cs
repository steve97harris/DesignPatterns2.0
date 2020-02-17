using System;

namespace DesignPatterns._03_Behavioral._02_Command.LightBulb
{
    public class Bulb
    {
        public void TurnOn()
        {
            Console.WriteLine("Bulb is Lit");
        }

        public void TurnOff()
        {
            Console.WriteLine("Darkness consumes the room");
        }
    }
}