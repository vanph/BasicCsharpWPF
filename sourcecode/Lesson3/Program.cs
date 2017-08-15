using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new NorthwindContext();
            var query = context.Customers.Select(c => new {ID = c.CustomerID, Name = c.CompanyName});

            var customerInfos = query.ToList();

            foreach (var custInfo in customerInfos)
            {
                Console.WriteLine($"ID: {custInfo.ID} - Name: {custInfo.Name}");
            }

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
