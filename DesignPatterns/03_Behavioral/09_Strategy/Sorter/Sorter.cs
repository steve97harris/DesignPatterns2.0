using System.Collections.Generic;
using System.ComponentModel;

namespace DesignPatterns._03_Behavioral._09_Strategy.Sorter
{
    public class Sorter
    {
        private readonly ISortStrategy mSorter;

        // Constructor 
        public Sorter(ISortStrategy sorter)
        {
            this.mSorter = sorter;
        }

        public List<int> Sort(List<int> unSortedList)        // Creating list method to Sort() unsorted list. 
        {
            return mSorter.Sort(unSortedList);            // Uses ISortStrategy Sorter to 
        }
    }
}