using System;
using System.Collections.Generic;

namespace DesignPatterns._03_Behavioral._09_Strategy.StudentSorter
{
    // ConcreteStrategy classes
    public class QuickSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            list.Sort();        // Default is QuickSort
            Console.WriteLine("QuickSorted list ");
        }
    }
    
    public class ShellSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            // list.ShellSort();
            Console.WriteLine("ShellSorted list");
        }
    }
    
    public class MergeSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            // list.MergeSort();
            Console.WriteLine("MergeSorted list");
        }
    }
}