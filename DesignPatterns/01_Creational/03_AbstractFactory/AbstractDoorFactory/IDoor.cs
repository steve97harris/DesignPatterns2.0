using System;

namespace DesignPatterns._01_Creational._03_AbstractFactory.AbstractDoorFactory
{
    interface IDoor
    {
        void GetDescription();
    }

    class WoodenDoor : IDoor
    {
        public void GetDescription()
        {
            Console.WriteLine("Wooden Door");
        }
    }

    class IronDoor : IDoor
    {
        public void GetDescription()
        {
            Console.WriteLine("Iron Door");
        }
    }
}