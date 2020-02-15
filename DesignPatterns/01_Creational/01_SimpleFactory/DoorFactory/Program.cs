using System;
using System.Collections.Generic;

namespace DesignPatterns._01_Creational._01_SimpleFactory.DoorFactory
{
    public class Program
    {
        public static void MainOLD()
        {
            var woodDoor = DoorFactory.MakeWoodDoor(80, 30);
            var glassDoor = DoorFactory.MakeGlassDoor(72, 24);
            
            Console.WriteLine($"Height of Wooden Door: {woodDoor.GetHeight()}");
            Console.WriteLine($"Width of Wooden Door: {woodDoor.GetWidth()}");
            
            Console.WriteLine($"Height of Glass Door: {glassDoor.GetHeight()}");
            Console.WriteLine($"Width of Glass Door: {glassDoor.GetWidth()}");
        }
    }
}