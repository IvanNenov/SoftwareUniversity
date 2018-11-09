using System;

namespace Cube
{
    class Program
    {
        static void Main(string[] args)
        {
            //face, space, volume or area
            double side = double.Parse(Console.ReadLine());
            string result = Console.ReadLine().ToLower();

            decimal face = 0;
            decimal space = 0;
            decimal volume = 0;
            decimal area = 0;

            if (result == "face")
            {
                face = (decimal)Math.Sqrt(2 * side * side);
                Console.WriteLine($"{face:f2}");
            }

            else if (result == "space")
            {
                space = (decimal)Math.Sqrt(3 * side * side);
                Console.WriteLine($"{space:f2}");
            }

            else if (result == "volume")
            {
                volume = (decimal)(side * side * side);
                Console.WriteLine($"{volume:f2}");
            }

            else if (result == "area")
            {
                area = (decimal)(6 * side * side);
                Console.WriteLine($"{area:f2}");
            }
        }
    }
}
