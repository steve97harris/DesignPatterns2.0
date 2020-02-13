namespace DesignPatterns._AbstractFactory
{
    // Client Class
    public class AnimalWorld
    {
        private Herbivore herbivore;
        private Carnivore carnivore;
        
        //Constructor
        public AnimalWorld(ContinentFactory factory)
        {
            herbivore = factory.CreateHerbivore();
            carnivore = factory.CreateCarnivore();
        }

        public void RunFoodChain()
        {
            carnivore.Eat(herbivore);
        }
    }
}