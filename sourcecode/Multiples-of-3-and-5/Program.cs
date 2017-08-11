using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiples_of_3_and_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiples of 3 and 5");
            int sum = 0;

            for (int i = 0; i < 1000; i++)
            {
                if ((i % 3) == 0) { sum += i; }
                else
                {
                    if ((i % 5) == 0) { sum += i; }
                }
            }
                Console.WriteLine("sum of all the multiples of 3 or 5 below 10: {0}", sum);
            Console.ReadKey();
        }
    }
}
