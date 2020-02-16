using System;

namespace DesignPatterns._02_Structural._04_Decorator.CoffeeShop
{
    public class Program
    {
        static void Main()
        {
            var myCoffee = new SimpleCoffee();
            Console.WriteLine($"{myCoffee.GetCost():c}");
            Console.WriteLine(myCoffee.GetDescription());
            
            var milkCoffee = new MilkCoffee(myCoffee);
            Console.WriteLine($"{milkCoffee.GetCost():c}");
            Console.WriteLine(milkCoffee.GetDescription());
            
            var vanillaTurCoffee = new VanillaTurmericCoffee(milkCoffee);
            Console.WriteLine($"{vanillaTurCoffee.GetCost():c}");
            Console.WriteLine(vanillaTurCoffee.GetDescription());
            
            var milkSugarCoffee = new MilkSugarCoffee(myCoffee);
            Console.WriteLine($"{milkSugarCoffee.GetCost():c}");
            Console.WriteLine(milkSugarCoffee.GetDescription());
            
            // Vanilla, Turmeric, Milk and Sugar coffee:
            var vanTurMilkSugarCoffee = new VanillaTurmericCoffee(milkSugarCoffee);
            Console.WriteLine($"{vanTurMilkSugarCoffee.GetCost():c}");
            Console.WriteLine(vanTurMilkSugarCoffee.GetDescription());
        }
    }
}