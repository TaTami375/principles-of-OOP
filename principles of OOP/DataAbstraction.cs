using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace principles_of_OOP
{
    internal class DataAbstraction
    {
        public abstract class Shape
        {
            public abstract double GetArea();
        }

        public class Circle : Shape
        {
            public double Radius { get; set; }

            public Circle(double radius)
            {
                Radius = radius;
            }

            public override double GetArea()
            {
                return Math.PI * Radius * Radius;
            }
        }

        public class Rectangle : Shape
        {
            public double Width { get; set; }
            public double Height { get; set; }

            public Rectangle(double width, double height)
            {
                Width = width;
                Height = height;
            }

            public override double GetArea()
            {
                return Width * Height;
            }
        }
    }
}
