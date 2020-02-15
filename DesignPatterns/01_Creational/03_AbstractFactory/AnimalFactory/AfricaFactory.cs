namespace DesignPatterns._AbstractFactory
{
    public class AfricaFactory : ContinentFactory
    {
        public override Herbivore CreateHerbivore()
        {
            return new Zebra();
        }

        public override Carnivore CreateCarnivore()
        {
            return new Lion();
        }
    }
}