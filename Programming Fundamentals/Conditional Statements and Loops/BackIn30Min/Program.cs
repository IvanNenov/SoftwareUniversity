using System;

namespace BackIn30Min
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());

            min += 30;
            if (min > 59)
            {
                min -= 60;
                hours++;
            }

            if (hours > 23)
            {
                hours = 0;
            }
            
            Console.WriteLine($"{hours}:{min:d2}");
        }
    }
}
