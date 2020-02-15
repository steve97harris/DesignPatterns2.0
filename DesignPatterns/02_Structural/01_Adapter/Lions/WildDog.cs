namespace DesignPatterns._02_Structural._01_Adapter.Lions
{
    // WildDog can't be directly accessed by the hunter because it does not belong to the same interface as Lions. 
    // To make it compatible for the hunter, we create an adapter that is compatible. 
    public class WildDog
    {
        public void Bark()
        {
            
        }
    }

    // Creating an Adapter around the wild dog to make it compatible with the game.
    public class WildDogAdapter : ILion
    {
        private WildDog mDog;        // Create private field wild dog in adapter

        public WildDogAdapter(WildDog dog)        // Create public adapter subject to parameter wild dog
        {
            this.mDog = dog;        // Set field = parameter.
        }
        
        public void Roar()
        {
            mDog.Bark();        // Allows wild dog field to bark under function Roar()
        }
    }
}