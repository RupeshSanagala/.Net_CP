using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsTasks
{
    public class Shape
    {
        protected Location c;

        public string ToString()
        {
            return string.Empty;
        }

        public double Area()
        {
            return 0.000;
        }

        public double Perimeter()
        {
            return 0.000;
        }
    }

    public class Location
    {
        private double x, y;
    }

    public class Rectangle : Shape
    {
        protected double side1, side2;

        public double Area(double side1, double side2)
        {
            return side1 * side2;
        }

        public double Perimeter(double side1, double side2)
        {
            return 2 * (side1 + side2);
        }
    }

    public class Circle : Shape
    {
        protected double radius;

        public double Area(int radius)
        {
            return 3.14 * radius * radius;
        }
        public double Perimeter(int radius)
        { 
            return 2 * 3.14 * radius;
        }
    }
}
