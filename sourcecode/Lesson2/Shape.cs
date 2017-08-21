using System;

namespace Lesson2
{
    abstract class Shape
    {
        protected const double Pi = Math.PI;
        protected double X, Y;
        
        protected Shape(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public abstract double Area();
    }

    class Circle : Shape
    {

        public Circle(double radius)
            : base(radius, 0)
        {
        }
        public override double Area()
        {
            return Pi * X * X;
        }
    }

    class Cylinder : Circle
    {
        public Cylinder(double radius, double height)
            : base(radius)
        {
            Y = height;
        }

        public override double Area()
        {
            return (2 * base.Area()) + (2 * Pi * X * Y);
        }
    }
}
