using System;

namespace FastPrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 2; i <= number; i++)
            {
                bool Istrue = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        Istrue = false;
                        break;
                    }
                }
                Console.WriteLine($"{i} -> {Istrue}");
            }

        }
    }
}
