using System.Collections.Generic;

namespace DesignPatterns._03_Behavioral._09_Strategy.Sorter
{
    public class Program
    {
        static void MainOLD()
        {
            var unSortedList = new List<int> {1, 10, 2, 16, 19};
            
            var sorter = new Sorter(new BubbleSortStrategy());
            sorter.Sort(unSortedList);
            
            sorter = new Sorter(new QuickSortStrategy());
            sorter.Sort(unSortedList);
        }
    }
}