using System;

namespace OpenClosedPrinciple
{
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public override double Area()
        {
            return Width * Height;
        }
    }
    public class AreaCalculator 
    {
        public double Area(Shape[] shapes)
        {
            double area = 0;
            foreach (var shape in shapes)
            {
                area += shape.Area();
            }

            return area;
        }
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }
        public override double Area()
        {
            return Radius * Radius * Math.PI;
        }
    }

    public abstract class Shape 
    {
        public abstract double Area();
    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
