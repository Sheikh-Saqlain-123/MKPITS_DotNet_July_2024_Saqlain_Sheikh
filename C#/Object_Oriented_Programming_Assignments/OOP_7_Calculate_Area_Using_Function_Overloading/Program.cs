using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_7_Calculate_Area_Using_Function_Overloading
{
    class CalculateArea
    {
        private const double pie = 3.14;
        public  double length, bredth, radius;
        public double height, width, half;
        public double result;
        public double Area(double radius)
        {
            result = pie * (radius*radius);
            return result;
        }
        public double Area(double length, double bredth )
        {
            result = (length*bredth);
            return result;
        }
        public double Area(double half , double width, double height)
        {
            result = half * width * height;
            return result;
        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculateArea area = new CalculateArea();
            Console.WriteLine("Area of Triangle is :- " +area.Area(0.5,10,10));
            Console.WriteLine("Area of Rectangle is :- " + area.Area(10, 10));
            Console.WriteLine("Area of Circle is :- " + area.Area(10));

            Console.Read();
        }
    }
}
