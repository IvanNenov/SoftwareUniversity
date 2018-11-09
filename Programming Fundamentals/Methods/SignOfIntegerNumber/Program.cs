using System;

namespace SignOfIntegerNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            PrintSign(number);
        }

        private static void PrintSign(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");

            }
            else if (number == 0)
            {
                Console.WriteLine($"The number {number} is zero.");

            }
            else
            {
                Console.WriteLine($"The number {number} is negative.");
            }
        }
    }
}
