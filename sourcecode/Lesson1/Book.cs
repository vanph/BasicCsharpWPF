using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    public class Book
    {
        public string Name { get; set; }

        public int Grade { get; set; }


        public Book()
        {

        }

        public Book(string name)
        {
            Name = name;
        }

        public Book(string name, int grade)
        {
            Name = name;
            Grade = grade;
        }
    }
}
