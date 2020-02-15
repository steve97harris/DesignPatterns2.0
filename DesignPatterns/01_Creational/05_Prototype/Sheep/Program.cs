using System;

namespace DesignPatterns._01_Creational._05_Prototype.Sheep
{
    public class Program
    {
        public static void Main()
        {
            var original = new Sheep("Jolly", "Mountain Sheep");
            Console.WriteLine(original.Name);
            Console.WriteLine(original.Category);

            var clone = original.Clone();
            clone.Name = "Dolly";
            
            Console.WriteLine(clone.Name);
            Console.WriteLine(clone.Category);
            Console.WriteLine(original.Name);
        }
    }
}