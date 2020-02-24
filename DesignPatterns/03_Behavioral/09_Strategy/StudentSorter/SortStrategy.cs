using System.Collections.Generic;

namespace DesignPatterns._03_Behavioral._09_Strategy.StudentSorter
{
    // Strategy abstract class
    public abstract class SortStrategy
    {
        public abstract void Sort(List<string> list);
    }
}