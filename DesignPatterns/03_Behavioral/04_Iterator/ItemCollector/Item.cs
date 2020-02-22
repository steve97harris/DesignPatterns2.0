namespace DesignPatterns._03_Behavioral._04_Iterator.ItemCollector
{
    // Collection item
    public class Item
    {
        private string mName;        // Setting mName as the member variable (instance variable).

        // Constructor
        public Item(string name)
        {
            this.mName = name;
        }

        // Gets the Name
        public string Name
        {
            get { return mName; }
            // set { mName = value; }
        }
    }
}