using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilesToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal kilometer = decimal.Parse(Console.ReadLine());
            decimal convert = kilometer * 1.60934m;

            Console.WriteLine($"{convert:f2}");
        }
    }
}
