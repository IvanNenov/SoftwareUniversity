using System;
using System.Collections.Generic;
using System.Linq;

namespace AppendList
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { '|'} , StringSplitOptions.RemoveEmptyEntries);
            List<string> result = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                result.Add(input[i]);
            }
            result.Reverse();
            Console.WriteLine(string.Join(" ",result).Trim());
        }
    }
}
