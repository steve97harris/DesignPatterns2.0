using System;
using System.Reflection.Emit;
using System.Collections.Generic;

namespace DesignPatterns._Decorator
{
    // ConcreteDecorator class
    public class Borrowable : Decorator
    {
        protected List<string> borrowers = new List<string>();
        
        // Constructor 
        public Borrowable(LibraryItem libraryItem) : base(libraryItem)
        {
            
        }

        public void BorrowItem(string name)
        {
            borrowers.Add(name);
            libraryItem.NumCopies--;
        }

        public void ReturnItem(string name)
        {
            borrowers.Remove(name);
            libraryItem.NumCopies++;
        }

        public override void Display()
        {
            base.Display();

            foreach (string person in borrowers)
            {
                Console.WriteLine(" borrower: " + person);
            }
        }
    }
}