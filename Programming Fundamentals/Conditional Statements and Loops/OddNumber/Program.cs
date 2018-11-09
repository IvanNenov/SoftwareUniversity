using System;

namespace OddNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int input = Math.Abs(int.Parse(Console.ReadLine()));

                if (input % 2 == 0)
                {
                    Console.WriteLine("Please write an odd number.");
                }

                else
                {
                    Console.WriteLine($"The number is: {input}");
                    break;
                }
            }


        }
    }
}
