using System;

namespace Interval_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int stopNumber = int.Parse(Console.ReadLine());

            int stop = Math.Max(startNumber, stopNumber);
            int start = Math.Min(startNumber, stopNumber);

            for (int i = start; i <= stop; i++)
            {
                Console.WriteLine(i);
            }




        }
    }
}
