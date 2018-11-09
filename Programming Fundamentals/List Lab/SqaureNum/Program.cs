using System;
using System.Collections.Generic;
using System.Linq;

namespace SqaureNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

            var result = new List<int>();

            foreach (var num in numbers)
            {
                if (Math.Sqrt(num) == (int)(Math.Sqrt(num)))
                {
                    result.Add(num);
                }
            }

            var descendingResult = result.OrderByDescending(x => x);
            Console.WriteLine(string.Join(" ",descendingResult));
        }
    }
}
