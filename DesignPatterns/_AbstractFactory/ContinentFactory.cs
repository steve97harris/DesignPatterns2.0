namespace DesignPatterns._AbstractFactory
{
    abstract class ContinentFactory
    {
        public abstract Herbivore CreateHerbivore();
        public abstract Carnivore CreateCarnivore();
    }

    abstract class Herbivore
    {
        
    }

    abstract class Carnivore
    {
        
    }
}