﻿namespace Lesson1
{
    //http://www.dotnettricks.com/learn/csharp/understanding-boxing-and-unboxing-in-csharp
    public class TestUnboxing
    {
        public static void Test()
        {
            int i = 12;
            object o = i;  // implicit boxing

            try
            {
                int j = (short)o;  // attempt to unbox
                //int j = (int)o;

                System.Console.WriteLine("Unboxing OK.");
            }
            catch (System.InvalidCastException e)
            {
                System.Console.WriteLine("{0} Error: Incorrect unboxing.", e.Message);
            }
        }
    }
}
