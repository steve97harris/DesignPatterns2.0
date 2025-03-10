﻿namespace DesignPatterns._Decorator
{
    // Component abstract class
    public abstract class LibraryItem
    {
        private int numCopies;

        public int NumCopies
        {
            get
            {
                return numCopies;
            }
            set
            {
                numCopies = value;
            }
        }

        public abstract void Display();
    }
}