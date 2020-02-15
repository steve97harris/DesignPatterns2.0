namespace DesignPatterns._01_Creational._03_AbstractFactory.AbstractDoorFactory
{
    public class Program
    {
        public static void Main()
        {
            var woodenDoorFactory = new WoodenDoorFactory();
            var woodenDoor = woodenDoorFactory.MakeDoor();
            var woodenDoorFactoryExpert = woodenDoorFactory.GetFittingExpert();
            
            var ironDoorFactory = new IronDoorFactory();
            var ironDoor = ironDoorFactory.MakeDoor();
            var ironDoorFactoryExpert = ironDoorFactory.GetFittingExpert();
            
            woodenDoor.GetDescription();
            woodenDoorFactoryExpert.GetDescription();
            
            ironDoor.GetDescription();
            ironDoorFactoryExpert.GetDescription();
        }
    }
}