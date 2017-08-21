using System;

namespace Lesson2
{
    class TestConstructor
    {
        public static void Test()
        {
            var radius = 2.5;
            var height = 3.0;

            var ring = new Circle(radius);
            var tube = new Cylinder(radius, height);

            Console.WriteLine("Area of the circle = {0:F2}", ring.Area());
            Console.WriteLine("Area of the cylinder = {0:F2}", tube.Area());

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
