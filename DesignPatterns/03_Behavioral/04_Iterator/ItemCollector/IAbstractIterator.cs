namespace DesignPatterns._03_Behavioral._04_Iterator.ItemCollector
{
    // Iterator Interface
    public interface IAbstractIterator
    {
        Item First();
        Item Next();
        bool IsDone { get; }
        Item CurrentItem { get; }
    }

    public class Iterator : IAbstractIterator
    {
        private Collection mCollection;
        private int mCurrent = 0;
        private int mStep = 1;
        
        // Constructor
        public Iterator(Collection collection)
        {
            this.mCollection = collection;
        }
        
        //Gets first item
        public Item First()
        {
            mCurrent = 0;        // Instance of current item = 0, therefore it's the first item.
            return mCollection[mCurrent] as Item;        // Instance of collection (instance of current item)
        }

        // Gets next item
        public Item Next()
        {
            mCurrent += mStep;        // current = current + step    (current + 1)
            if (!IsDone)        // if iteration is not complete
            {
                return mCollection[mCurrent] as Item;
            }
            else
                return null;
        }

        // Gets or sets stepsize
        public int Step
        {
            get { return mStep; }
            set { mStep = value; }
        }
        
        // Gets current iterator item
        public Item CurrentItem
        {
            get { return mCollection[mCurrent] as Item; }
        }

        // Gets whether iteration is complete
        public bool IsDone
        {
            get { return mCurrent >= mCollection.Count; }
        }
    }
}