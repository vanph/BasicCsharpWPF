using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson2.Extensions;

namespace Lesson2
{
    public  class Person
    {
        public  string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public string FullName => new[] {FirstName, MiddleName, LastName}.JoinStrings("-");
    }
}
