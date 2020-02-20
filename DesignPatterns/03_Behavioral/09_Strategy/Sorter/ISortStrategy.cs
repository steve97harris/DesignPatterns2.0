using System;
using System.Collections.Generic;

namespace DesignPatterns._03_Behavioral._09_Strategy.Sorter
{
    public interface ISortStrategy
    {
        List<int> Sort(List<int> dataset);        // Creating List method called Sort with respect to the dataset.
    }

    // 2 Concrete Strategies, Bubble and Quick Sort.
    class BubbleSortStrategy : ISortStrategy
    {
        public List<int> Sort(List<int> dataset)
        {
            Console.WriteLine("Sorting into Bubble sort!");
            return dataset;
        }
    }

    class QuickSortStrategy : ISortStrategy
    {
        public List<int> Sort(List<int> dataset)
        {
            Console.WriteLine("Sorting into Quick sort!");
            return dataset;
        }
    }
}