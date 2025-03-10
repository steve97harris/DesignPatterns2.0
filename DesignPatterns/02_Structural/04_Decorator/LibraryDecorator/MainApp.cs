﻿using System;

namespace DesignPatterns._Decorator
{
    public class MainApp
    {
        public static void MainOLD()
        {
            Book book1 = new Book("Stephen Kind", "The Outsider", 20);
            
            Video video1 = new Video("Wes Anderson", "The grand budapest hotel", 10, 120);
            
            // Make video borrowable, then borrow and display
            Console.WriteLine("\n Making video borrowable: ");
            
            Borrowable borrowableVideo = new Borrowable(video1);
            borrowableVideo.BorrowItem("Customer #1");
            borrowableVideo.BorrowItem("Customer #2");
            
            borrowableVideo.Display();
            
            Borrowable borrowableBook = new Borrowable(book1);
            borrowableBook.BorrowItem("Customer X");
            borrowableBook.BorrowItem("Customer Y");
            borrowableBook.BorrowItem("Customer Z");
            borrowableBook.Display();
            
            Console.ReadKey();
        }
    }
}