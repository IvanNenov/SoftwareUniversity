using System;

namespace PrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            int counter = (int)Math.Sqrt(n);
            bool isPrime = true;
            isPrime = PrimeChecker(n, counter, isPrime);
        }

        private static bool PrimeChecker(double n, int counter, bool isPrime)
        {
            if (n > 1)
            {
                for (int i = 2; i <= counter; i++)
                {
                    if (n % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }

            else
            {
                isPrime = false;
            }
            if (isPrime)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

            return isPrime;
        }
    }
}
