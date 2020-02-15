namespace DesignPatterns._02_Structural._01_Adapter.Lions
{
    public class Program
    {
        static void MainOLD()
        {
            var wildDog = new WildDog();
            var wildDogAdapter = new WildDogAdapter(wildDog);        
            // wildDog does not belong to the interface therefore cannot be hunted. 
            // wildDogAdapter is used to adapt the wildDog as it belongs to the interface.
            
            var hunter = new Hunter();
            hunter.Hunt(wildDogAdapter);
        }
    }
}