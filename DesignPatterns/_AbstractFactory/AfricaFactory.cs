namespace DesignPatterns._AbstractFactory
{
    class AfricaFactory : ContinentFactory
    {
        public override Herbivore CreateHerbivore()
        {
            throw new System.NotImplementedException();
        }

        public override Carnivore CreateCarnivore()
        {
            throw new System.NotImplementedException();
        }
    }
}