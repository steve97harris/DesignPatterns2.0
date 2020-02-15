namespace DesignPatterns._AbstractFactory
{
    public class OtherFactory : ContinentFactory
    {
        public override Herbivore CreateHerbivore()
        {
            return new Sheep();
        }

        public override Carnivore CreateCarnivore()
        {
            return new Tiger();
        }
    }
}