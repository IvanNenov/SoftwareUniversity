using System;
using System.Numerics;

namespace Factoriel
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger number = 1;

            for (int i = 1; i <= n; i++)
            {
                number *= i;
            }
            Console.WriteLine(number);
        }
    }
}
