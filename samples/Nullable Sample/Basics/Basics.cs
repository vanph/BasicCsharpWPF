﻿
using System;

namespace Basics
{
    internal class NullableBasics
    {
        static void DisplayValue(int? num)
        {
            if (num.HasValue)//num != null
            {
                Console.WriteLine("num = " + num);
            }
            else
            {
                Console.WriteLine("num = null");
            }

            // num.Value throws an InvalidOperationException if num.HasValue is false
            try
            {
                Console.WriteLine("value = {0}", num.Value);
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void Main()
        {
            DisplayValue(1);
            DisplayValue(null);
        }
    }
}
