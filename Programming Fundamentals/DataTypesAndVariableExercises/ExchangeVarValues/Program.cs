using System;

namespace ExchangeVarValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;

            int newa = b;
            int newb = a;

            Console.WriteLine("Before:");
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");

            Console.WriteLine("After:");
            Console.WriteLine($"a = {newa}");
            Console.WriteLine($"b = {newb}");



        }
    }
}
