using System;
using System.Collections.Generic;

namespace Multiples_of_3_and_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiples of 3 and 5");
            var sum = GetSum(1000);

            Console.WriteLine("sum of all the multiples of 3 or 5 below 1000: {0}", sum);
            Console.ReadKey();
        }

        private static int GetSum(int number)
        {
            var sum = 0;

            for (var i = 0; i < number; i++)
            {
                if (i % 3 == 0 || i % 5 ==0)
                {
                    sum += i;
                }
            }

            return sum;
        }
    }
}
