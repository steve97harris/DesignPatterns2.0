namespace DesignPatterns._Decorator
{
    // Decorator class
    public class Decorator : LibraryItem
    {
        protected LibraryItem libraryItem;
        
        // Constructor 
        public Decorator(LibraryItem libraryItem)
        {
            this.libraryItem = libraryItem;
        }
        public override void Display()
        {
            libraryItem.Display();
        }
    }
}