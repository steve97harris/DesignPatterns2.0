using System.Collections;

namespace DesignPatterns._03_Behavioral._04_Iterator.ItemCollector
{
    // Aggregate interface
    public interface IAbstractCollection
    {
        Iterator CreateIterator();
    }
    
    // Concrete Aggregate
    public class Collection : IAbstractCollection
    {
        private ArrayList mItems = new ArrayList();
        
        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }
        
        // Gets item count
        public int Count
        {
            get { return mItems.Count; }        
        }
        
        // Indexer - Allows instances of a class or struct to be indexed just like arrays.
        public object this[int index]
        {
            get { return mItems[index]; }
            set { mItems.Add(value); }        // Adds object to end of Array List
        }
    }
}