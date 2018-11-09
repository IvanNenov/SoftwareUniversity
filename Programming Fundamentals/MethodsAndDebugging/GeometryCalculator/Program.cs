using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();

            CalculateArea(figureType);
        }

        private static void CalculateArea(string figureType)
        {
            if (figureType == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                Console.WriteLine("{0:F2}", (side * height) / 2);
            }
            else if (figureType == "square")
            {
                double side = double.Parse(Console.ReadLine());

                Console.WriteLine("{0:F2}", Math.Pow(side, 2));
            }
            else if (figureType == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                Console.WriteLine("{0:F2}", width * height);
            }
            else if (figureType == "circle")
            {
                double radius = double.Parse(Console.ReadLine());

                Console.WriteLine("{0:F2}", Math.PI * Math.Pow(radius, 2));
            }
        }
    }
}