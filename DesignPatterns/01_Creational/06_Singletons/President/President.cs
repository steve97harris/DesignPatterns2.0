using System;

namespace DesignPatterns._01_Creational._06_Singletons.President
{
    public class President
    {
        static President instance;
        
        // Private constructor
        private President()
        {
            
        }
        
        // Public constructor
        public static President GetInstance()
        {
            if (instance == null)
            {
                instance = new President();
            }

            return instance;
        }
    }

    class Program
    {
        public static void MainOLD()
        {
            President x = President.GetInstance();
            President y = President.GetInstance();
            
            Console.WriteLine(x == y);
        }
    }
}