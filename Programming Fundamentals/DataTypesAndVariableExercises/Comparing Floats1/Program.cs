using System;

namespace Comparing_Floats1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            var maxNumber = Math.Max(a, b);
            var minNumber = Math.Min(a, b);

            if (maxNumber - minNumber >= 0.000001 )
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }


        }
    }
}
