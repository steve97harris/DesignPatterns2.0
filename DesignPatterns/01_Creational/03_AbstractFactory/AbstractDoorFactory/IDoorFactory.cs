namespace DesignPatterns._01_Creational._03_AbstractFactory.AbstractDoorFactory
{
    interface IDoorFactory
    {
        IDoor MakeDoor();
        IDoorFittingExpert GetFittingExpert();
    }

    class WoodenDoorFactory : IDoorFactory
    {
        public IDoor MakeDoor()
        {
            return new WoodenDoor();
        }

        public IDoorFittingExpert GetFittingExpert()
        {
            return new Carpenter();
        }
    }

    class IronDoorFactory : IDoorFactory
    {
        public IDoor MakeDoor()
        {
            return new IronDoor();
        }

        public IDoorFittingExpert GetFittingExpert()
        {
            return new Welder();
        }
    }
}