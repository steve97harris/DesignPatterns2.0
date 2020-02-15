using System;

namespace DesignPatterns._01_Creational._03_AbstractFactory.AbstractDoorFactory
{
    interface IDoorFittingExpert
    {
        void GetDescription();
    }

    class Welder : IDoorFittingExpert
    {
        public void GetDescription()
        {
            Console.WriteLine("Welder, for iron doors");
        }
    }

    class Carpenter : IDoorFittingExpert
    {
        public void GetDescription()
        {
            Console.WriteLine("Carpenter, for wooden doors");
        }
    }
}