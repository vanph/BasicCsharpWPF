using System;
using System.Collections.Generic;

namespace Practice.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var cSharpBook = new Book("C#", 5);
            var javaBook = new Book("Java", 10);

            var books = new List<Book> { cSharpBook, javaBook };

            Console.WriteLine("Listing books:");

            foreach (var book in books)
            {
                Console.WriteLine($"Name:{book.Name} Grade: {book.Grade}");
            }

            //Homework
            //Create a list 10 books.
            //Find Min, Max, Avg of grade of the books.
            //Find the book(s) that has the max grade.

            Console.ReadLine();
        }

    }
}
