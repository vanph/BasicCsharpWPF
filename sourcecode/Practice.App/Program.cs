using System;
using System.Collections.Generic;

namespace Practice.App
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a list 10 books.
            var cSharpBook = new Book("C#", 5);
            var javaBook = new Book("Java", 10);
            var phpBook = new Book("PHP", 6);
            var htmlBook = new Book("HTML", 8);
            var cssBook = new Book("CSS", 4);
            var rubyBook = new Book("Ruby", 9);
            var cBook = new Book("C", 2);
            var cplusBook = new Book("C++", 7);
            var pascalBook = new Book("Pascal", 1);
            var delphiBook = new Book("Delphi", 3);

            var books = new List<Book> { cSharpBook, javaBook, phpBook, htmlBook, cssBook, rubyBook, cBook, cplusBook, pascalBook, delphiBook };

            Console.WriteLine("Listing books:");
            
            foreach (var book in books)
            {
                Console.WriteLine($"Name:{book.Name} Grade: {book.Grade}");
            }

            var maxBook = new Book("", 0);//var maxBook = new Book;???
            var minBook = new Book("", 0);
            var sumGrade = 0;

            minBook.Name = maxBook.Name = books[0].Name;
            minBook.Grade = maxBook.Grade = books[0].Grade;

            //Find Min, Max, Avg of grade of the books.
            //Find the book(s) that has the max grade.
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].Grade > maxBook.Grade)
                {
                    maxBook.Grade = books[i].Grade;
                    maxBook.Name = books[i].Name;
                }
                else if (books[i].Grade == maxBook.Grade)
                {
                    maxBook.Name = maxBook.Name + " - " + books[i].Name;
                }
                else if (books[i].Grade < minBook.Grade)
                {
                    minBook.Grade = books[i].Grade;
                    minBook.Name = books[i].Name;
                }
                else if (books[i].Grade == minBook.Grade)
                {
                    minBook.Grade = books[i].Grade;
                    minBook.Name = minBook.Name + " - " + books[i].Name;
                }
                sumGrade += books[i].Grade;
            }

            Console.WriteLine("\nMax of grade of the books: {0}", maxBook.Grade);
            Console.WriteLine("The books has the max grade: {0}", maxBook.Name);
            Console.WriteLine("Min of grade of the books: {0}", minBook.Grade);
            Console.WriteLine("The books has the min grade: {0}", minBook.Name);
            Console.WriteLine("Avg of grade of the books: {0}", (float)sumGrade / books.Count);

            //Homework
            //Create a list 10 books.
            //Find Min, Max, Avg of grade of the books.
            //Find the book(s) that has the max grade.

            Console.ReadLine();
        }

    }
}
