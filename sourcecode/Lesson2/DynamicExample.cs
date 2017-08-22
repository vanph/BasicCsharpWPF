using System;

namespace Lesson2
{
    //https://stackoverflow.com/questions/31859016/is-the-use-of-dynamic-considered-a-bad-practice
    class DynamicExample
    {
        public static void Test()
        {
            ExampleClass1 ec = new ExampleClass1();
            //Console.WriteLine(ec.ExampleMethod(10));
            //Console.WriteLine(ec.ExampleMethod("value"));

            dynamic d = ec;
            Console.WriteLine(ec.ExampleMethod(10));

            //// The following line causes a compiler error because exampleMethod
            //// takes only one argument.
            ////Console.WriteLine(ec.exampleMethod(10, 4));

            //dynamic dynamic_ec = new ExampleClass2();
            //Console.WriteLine(dynamic_ec.exampleMethod(11));
            //dynamic_ec = ec;
            //Console.WriteLine(dynamic_ec.exampleMethod2("ashdjksa"));

            //// Because dynamic_ec is dynamic, the following call to exampleMethod
            //// with two arguments does not produce an error at compile time.
            //// However, itdoes cause a run-time error. 
            ////Console.WriteLine(dynamic_ec.exampleMethod(10, 4));
        }
    }

    public class ExampleClass1
    {
        public dynamic ExampleMethod(dynamic d)
        {
            dynamic local = "Local int variable";

            int two = 2;

            return d is int ? local : two;
        }
    }

    public class ExampleClass2
    {

        public dynamic ExampleMethod(object o)
        {
            dynamic local = "Local test variable";

            return local;
        }
    }
}
