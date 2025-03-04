using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_P1_Q1
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public double Price { get; set; }

        public void DisplayBookInfo()
        {
            Console.WriteLine("Book Details : ");
            Console.WriteLine($"Book Title : {Title}");
            Console.WriteLine($"Book Author : {Author}");
            Console.WriteLine($"Book ISBN : {ISBN}");
            Console.WriteLine($"Book Price : {Price:F2}");

        }
        public void ApplyDiscount(double percentage)
        {
            if (percentage < 0 || percentage > 100)
            {
                Console.WriteLine("Invalid Discount amount, PLease enter between 0 and 100!");
            }
            double discountAmount = (Price * percentage) / 100;
            Price -= discountAmount;
            Console.WriteLine($"Discount of {percentage}% applied, New price is : {Price}");
        }
    }
    class Program
    {
        /*Scenario 1: Library Management System
You are developing a Library Management System where books are stored with specific details. Implement a Book class that contains the following properties:

Title (string)
Author (string)
ISBN (string)
Price (double)
The class should have:

A method DisplayBookInfo() that prints book details.
A method ApplyDiscount(double percentage) that reduces the price of the book based on a given discount percentage.*/
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.Title = "Atomic Habits";
            book1.Author = "James Clear";
            book1.ISBN = "7788554123";
            book1.Price = 456.90;
            book1.DisplayBookInfo();
            book1.ApplyDiscount(10);
            Console.WriteLine("----------------------------");
            Console.WriteLine("Updated : ");

            book1.DisplayBookInfo();

            Console.WriteLine("----------------------------");

            Book book2 = new Book();
            book2.Title = "40 Rules Of Love";
            book2.Author = "Elif Shafak";
            book2.ISBN = "88996521403";
            book2.Price = 490.95;
            book2.DisplayBookInfo();
            book2.ApplyDiscount(10);
            Console.WriteLine("----------------------------");
            Console.WriteLine("Updated : ");
            book2.DisplayBookInfo();

            
        }
    }
}
