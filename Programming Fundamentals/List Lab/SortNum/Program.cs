using System;
using System.Linq;
using System.Collections.Generic;

namespace SortNum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> numbers = Console.ReadLine().Split().Select(decimal.Parse).ToList();

            numbers.Sort();
            Console.WriteLine(string.Join(" <= ", numbers));
        }
    }
}
