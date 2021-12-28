using System;

namespace OpenClosedPrinciple
{
    public class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }
    }
    public class AreaCalculator 
    {
        public double Area(object[] shapes) // Rectangle[] shapes förut
        {
            double area = 0;
            foreach (var shape in shapes)
                if (shape is Rectangle)
                {
                    Rectangle rectangle = (Rectangle)shape;
                    area += rectangle.Width * rectangle.Height;
                }
                else
                {
                    Circle circle = (Circle)shape;
                    area += circle.Radius * circle.Radius * Math.PI;
                }
            /*{
                area += shape.Width * shape.Height;
            }*/

            return area;
        }
    }

    public class Circle // Om vi vill ha cirkel måste vi ändra i AreaCalculator ovan... Blir fult.
    {
        public double Radius { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
