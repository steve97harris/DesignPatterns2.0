using System;

namespace DesignPatterns._AbstractFactory
{
    public abstract class ContinentFactory
    {
        public abstract Herbivore CreateHerbivore();
        public abstract Carnivore CreateCarnivore();
    }

    public abstract class Herbivore
    {
        
    }

    public abstract class Carnivore
    {
        public abstract void Eat(Herbivore h);
    }

    public class Zebra : Herbivore
    {
        
    }

    public class Lion : Carnivore
    {
        public override void Eat(Herbivore h)
        {
            // Eat Zebra
            Console.WriteLine(this.GetType().Name + " eats " + h.GetType().Name);
        }
    }

    public class Bison : Herbivore
    {
        
    }

    public class Wolf : Carnivore
    {
        public override void Eat(Herbivore h)
        {
            Console.WriteLine(this.GetType().Name + " eats " + h.GetType().Name);
        }
    }

    public class Sheep : Herbivore
    {
        
    }

    public class Tiger : Carnivore
    {
        public override void Eat(Herbivore h)
        {
            Console.WriteLine(this.GetType().Name + " Eats " + h.GetType().Name);
        }
    }
}