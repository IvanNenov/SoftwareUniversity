using System;
using System.Collections.Generic;
using System.Linq;

namespace Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            var result = numbers.Where(n => n > 0).Reverse().ToList();

            if (result.Count <= 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ",result));
            }
        }
    }
}
