namespace DesignPatterns._AbstractFactory
{
    class USAFactory : ContinentFactory
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