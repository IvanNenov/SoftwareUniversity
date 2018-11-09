using System;
using System.Linq;

namespace RectangleProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            //c2 = a2 + b2

            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double perimeter = width * 2 + height * 2;
            double area = width * height;
            double diagonal = Math.Sqrt(width * width + height * height);

            Console.WriteLine(perimeter);
            Console.WriteLine(area);
            Console.WriteLine(diagonal);
        }
    }
}
