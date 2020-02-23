using System;

namespace DesignPatterns._03_Behavioral._04_Iterator.ItemCollector
{
    public class Program
    {
        static void MainOLD()
        {
            // Build a collection of items
            Collection collection = new Collection();
            collection[0] =new Item("Item 0");
            collection[1] =new Item("Item 1");
            collection[2] =new Item("Item 2");
            collection[3] =new Item("Item 3");
            collection[4] =new Item("Item 4");
            collection[5] =new Item("Item 5");
            collection[6] =new Item("Item 6");
            
            // Create iterator
            Iterator iterator = collection.CreateIterator();
            
            // Skip every other item
            iterator.Step = 2;
            
            Console.WriteLine("Iterating over collection");

            for (Item item = iterator.First(); !iterator.IsDone; item = iterator.Next())
            {
                Console.WriteLine(item.Name);
            }
            
            // Wait for user
            Console.ReadKey();
        }
    }
}