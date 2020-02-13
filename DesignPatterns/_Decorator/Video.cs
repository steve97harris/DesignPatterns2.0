﻿using System;

namespace DesignPatterns._Decorator
{
    // ConcreteComponent class
    public class Video : LibraryItem
    {
        private string director;
        private string title;
        private int playTime;

        public Video(string director, string title, int numCopies, int playTime)
        {
            this.director = director;
            this.title = title;
            this.NumCopies = numCopies;
            this.playTime = playTime;
        }
        public override void Display()
        {
            Console.WriteLine("\n Video ------");
            Console.WriteLine(" Director: " + director);
            Console.WriteLine(" title: " + title);
            Console.WriteLine(" # Copies: " + NumCopies);
            Console.WriteLine(" PlayTime: " + playTime);
        }
    }
}