using System;
using System.Collections.Generic;
using System.Linq;

namespace SumReversedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                var num = numbers[i].ToString().ToList();

                num.Reverse();
                sum += int.Parse(string.Join("",num));
             
            }
            Console.WriteLine(sum);
        }
    }
}
