using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson2.Extensions;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            //var strName = "Van Minh";
            //var count = strName.WordCount().ToString();

            //var count2 = WordCount2(strName);

            //Console.WriteLine(count2);

            var van = new Person() {FirstName = "Van", LastName = "Pham"};
            var minh = new Person() { FirstName = "Minh", LastName = "Pham", MiddleName = "Anh"};

            Console.WriteLine(van.FullName);
            Console.WriteLine(minh.FullName);
            Console.ReadLine();

        }

        public static int WordCount2( string str)
        {
            return str.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }

    public class Book
    {
        public string Name { get; set; }

        public void Print()
        {
            Console.WriteLine(Name);
        }
    }
}
