using System;

namespace DesignPatterns._03_Behavioral._09_Strategy.StudentSorter
{
    public class Program
    {
        static void MainOLD()
        {
            // Two contexts following different strategies
            SortedList studentRecords = new SortedList();
            studentRecords.Add("Bill");
            studentRecords.Add("Jeff");
            studentRecords.Add("Lilly");
            studentRecords.Add("Fred");
            studentRecords.Add("Katie");
            studentRecords.Add("Jerry");
            
            studentRecords.SetSortStrategy(new QuickSort());
            studentRecords.Sort();
            
            studentRecords.SetSortStrategy(new MergeSort());
            studentRecords.Sort();
            
            studentRecords.SetSortStrategy(new ShellSort());
            studentRecords.Sort();

            Console.ReadKey();
        }
    }
}