using System;

namespace DesignPatterns._AbstractFactory
{
    public class AnimalFactory
    {
        public static void Main()
        {
            // Create and run Africa world
            ContinentFactory africa = new AfricaFactory();
            AnimalWorld world = new AnimalWorld(africa);
            world.RunFoodChain();
            
            // Create and run USA world
            ContinentFactory usa = new USAFactory();
            world = new AnimalWorld(usa);
            world.RunFoodChain();

            // Other world
            ContinentFactory other = new OtherFactory();
            world = new AnimalWorld(other);
            world.RunFoodChain();
            
            Console.ReadKey();
        }
    }
}