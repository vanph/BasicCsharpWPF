using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice.App
{
    class Program
    {
        static void Main(string[] args)
        {

            //LINQ TO OBJECTS => LINQ to Entities (EF: Entity Framework)
            //Create a list 10 books.

            var cSharpBook = new Book("C#", 3);
            var javaBook = new Book("Java", 10);
            var phpBook = new Book("PHP", 6);
            var htmlBook = new Book("HTML", 8);
            var cssBook = new Book("CSS", 3);
            var rubyBook = new Book("Ruby", 9);
            var cBook = new Book("C", 10);
            var cplusBook = new Book("C++", 7);
            var delphiBook = new Book("Delphi", 3);

            var books = new List<Book> { cSharpBook, javaBook, phpBook, htmlBook, cssBook, rubyBook, cBook, cplusBook, delphiBook };

            Console.WriteLine("Listing books:");

            //var orderedBooks = books.OrderByDescending(x => x.Grade).ThenBy(x => x.Name).ToList();
            
            //PrintBooks(orderedBooks);

            //Projection
            //var names = books.Select(x => x.Name).ToList();

            //foreach (var name in names)
            //{
            //    Console.WriteLine(name);
            //}


            ////Count
            //int count = books.Count;
            //Console.WriteLine("Total books:" + count);

            ////Max of grade of the books:
            //int max = books.Max(x => x.Grade);
            //Console.WriteLine("Max grade:" + max);
            ////The books has the max grade

            //Console.WriteLine("Listing Max Books1:");
            //var maxBooks = books.Where(x => x.Grade == max).ToList();
            //PrintBooks(maxBooks);


            //Console.WriteLine("Listing Max Book Names:");

            //var maxBookNames = books.Where(x => x.Grade == max).Select(x => x.Name).ToList();
            //foreach (var name in maxBookNames)
            //{
            //    Console.WriteLine(name);
            //}

            //var avg = books.Select(x => x.Grade).Average();
            //Console.WriteLine("Average:" + avg);

            //var avg2 = books.Average(x => x.Grade);
            //Console.WriteLine("Average:" + avg2);

            //string test = "Minh:";
            ////Console.WriteLine(test.Hello());
            //Console.WriteLine(test.ReplaceColon(@"Van"));

            //HOMEWORK =>MIN
            //Max of grade of the books:
            int min = books.Min(x => x.Grade);
            Console.WriteLine("Min grade:" + min);
            //The books has the max grade

            Console.WriteLine("Listing Min Books1:");
            var minBooks = books.Where(x => x.Grade == min).ToList();
            PrintBooks(minBooks);


            Console.WriteLine("Listing Min Book Names:");

            var minBookNames = books.Where(x => x.Grade == min).Select(x => x.Name).ToList();
            foreach (var name in minBookNames)
            {
                Console.WriteLine(name);
            }
            //var maxBook = new Book("", 0);//var maxBook = new Book;???
            //var minBook = new Book("", 0);
            //var sumGrade = 0;

            //minBook.Name = maxBook.Name = books[0].Name;
            //minBook.Grade = maxBook.Grade = books[0].Grade;

            ////Find Min, Max, Avg of grade of the books.
            ////Find the book(s) that has the max grade.
            //for (int i = 0; i < books.Count; i++)
            //{
            //    if (books[i].Grade > maxBook.Grade)
            //    {
            //        maxBook.Grade = books[i].Grade;
            //        maxBook.Name = books[i].Name;
            //    }
            //    else if (books[i].Grade == maxBook.Grade)
            //    {
            //        maxBook.Name = maxBook.Name + " - " + books[i].Name;
            //    }
            //    else if (books[i].Grade < minBook.Grade)
            //    {
            //        minBook.Grade = books[i].Grade;
            //        minBook.Name = books[i].Name;
            //    }
            //    else if (books[i].Grade == minBook.Grade)
            //    {
            //        minBook.Grade = books[i].Grade;
            //        minBook.Name = minBook.Name + " - " + books[i].Name;
            //    }
            //    sumGrade += books[i].Grade;
            //}

            //Console.WriteLine("\nMax of grade of the books: {0}", maxBook.Grade);
            //Console.WriteLine("The books has the max grade: {0}", maxBook.Name);
            //Console.WriteLine("Min of grade of the books: {0}", minBook.Grade);
            //Console.WriteLine("The books has the min grade: {0}", minBook.Name);
            //Console.WriteLine("Avg of grade of the books: {0}", (float)sumGrade / books.Count);

            //Homework
            //Create a list 10 books.
            //Find Min, Max, Avg of grade of the books.
            //Find the book(s) that has the max grade.


            Random r = new Random();
            Console.WriteLine(r.Next(5, 10));

            Console.ReadLine();
        }

        private static Func<Book, bool> PredicateEqual(int max)
        {
            return book => book.Grade == max;
        }


        private static void PrintBooks(List<Book> books)
        {
            foreach (var book in books)
            {
                Console.WriteLine($"Name:{book.Name} Grade: {book.Grade}");
            }
        }
    }
}
