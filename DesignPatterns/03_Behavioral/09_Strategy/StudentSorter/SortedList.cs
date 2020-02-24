using System;
using System.Collections.Generic;

namespace DesignPatterns._03_Behavioral._09_Strategy.StudentSorter
{
    // Context class
    public class SortedList
    {
        private List<string> mList = new List<string>();
        private SortStrategy mSortStrategy;

        public void SetSortStrategy(SortStrategy sortStrategy)
        {
            this.mSortStrategy = sortStrategy;
        }

        public void Add(string name)
        {
            mList.Add(name);
        }

        public void Sort()
        {
            mSortStrategy.Sort(mList);
            
            // Iterate over list and display results
            foreach (string name in mList)
            {
                Console.WriteLine("  " + name);
            }
            Console.WriteLine();
        }
    }
}