using System;

namespace DesignPatterns._Decorator
{
    // ConcreteComponent class
    public class Book : LibraryItem
    {
        private string author;
        private string title;
        
        // Constructor
        public Book(string author, string title, int numCopies)
        {
            this.author = author;
            this.title = title;
            this.NumCopies = numCopies;
        }
        
        public override void Display()
        {
            Console.WriteLine("\n Book -----");
            Console.WriteLine(" Author: " + author);
            Console.WriteLine(" Title: " + title);
            Console.WriteLine(" # Copies: " + NumCopies);
        }
    }
}