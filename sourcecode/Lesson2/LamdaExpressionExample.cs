﻿using System;
using System.Linq;

namespace Lesson2
{
    //Link: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/statements-expressions-operators/lambda-expressions

    /* A lambda expression is an ANONYMOUS function that you can use to create delegates or expression tree types. 
    By using lambda expressions, you can write local functions that can be passed as arguments or returned as the value of function calls. 
    Lambda expressions are particularly helpful for writing LINQ query expressions.

    To create a lambda expression, you specify input parameters (if any) on the left side of the lambda operator =>, and you put the expression or statement block on the other side. 
    For example, the lambda expression x => x * x specifies a parameter that’s named x and returns the value of x squared.*/

    //A delegate is a type that safely encapsulates a method, similar to a function pointer in C and C++
    //Expression trees represent code in a tree-like data structure, where each node is an expression.
    //When a lambda expression is assigned to a variable of type Expression<TDelegate>, the compiler emits code to build an expression tree that represents the lambda expression.

    public class LamdaExpressionExample
    {
        private delegate int Calculate(int x, int y);

        public void Run()
        {
            //Example 1: add two numbers using delegate
            Calculate add = (x, y) => x + y;
            Console.WriteLine(add(3, 4));

            //Example 2: calculate circle using delegate
            Calculate circle = (x, y) => (x + y) * 2;
            Console.WriteLine(circle(3, 4));

            //Example 3: Lambdas with the Standard Query Operators
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var oddNumbers = numbers.Where(n => n % 2 == 1);

            Console.WriteLine("Odd Numbers:");
            foreach (var oddNumber in oddNumbers)
            {
                Console.Write(oddNumber + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Count even numbers:" + numbers.Count(n => n % 2 == 0));
        }

    }
}
