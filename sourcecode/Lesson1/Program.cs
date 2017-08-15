using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //var date = new DateTime();

            //Console.WriteLine(date.ToString());

            //var defaultDate = default(DateTime);
            //Console.WriteLine(defaultDate);

            //Console.WriteLine(default(int));

            //int a = 10;
            //int c = a;
            //c = 15;

            //Console.WriteLine(c);
            //Console.WriteLine(a);


            //var cSharpBook = new Book("C#", 5);
            //var book = cSharpBook;
            //book.Name = "Harry P";

            //Console.WriteLine(cSharpBook.Name); //=> C# =>Wrong
            //Console.WriteLine(book.Name); //=> Harry P => True

            //cSharpBook.Grade = 10;

           var htmlBook = new Book("HTML", 8);
            var cssBook = new Book("CSS", 10);
            var rubyBook = new Book("Ruby", 9);
            var cBook = new Book("C", 10);
            var cplusBook = new Book("C++", 7);
            var delphiBook = new Book("Delphi", 3);

            var books = new List<Book> { htmlBook, cssBook, rubyBook, cBook, cplusBook, delphiBook };

            Console.WriteLine("Listing books:");
            PrintBooks(books); //=> Ruby

            //rubyBook.Name = "New Ruby";

            //Console.WriteLine("Re-Listing books:");
            //PrintBooks(books);//=> Ruby => Wrong

            ModifyBooks(books);

            Console.WriteLine("csplus book:");
            Console.WriteLine(cplusBook.Grade); //=> 100 => True

           Console.WriteLine(GetResult(books));


            Console.ReadLine();
        }

        private static void PrintBooks(List<Book> books)
        {
            foreach (var book in books)
            {
                Console.WriteLine($"Name:{book.Name} Grade: {book.Grade}");
            }
        }


        private static string GetResult(List<Book> books)
        {
            StringBuilder strResult = new StringBuilder();

            foreach (var book in books)
            {
                strResult.Append($"Name:{book.Name} Grade: {book.Grade}");
            }

            return strResult.ToString();
        }

        private static void ModifyBooks(List<Book> books)
        {
            foreach (var book in books)
            {
                book.Grade = 100;
            }
        }
    }
}
