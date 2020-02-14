namespace DesignPatterns._Facade.Simple
{
    public class ComputerFacade
    {
        protected Computer computer;

        public void construct(Computer computer)
        {
            this.computer = computer;
        }
    }
}