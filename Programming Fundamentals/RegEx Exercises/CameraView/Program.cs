using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
namespace CameraView
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var toSkip = numbers[0];
            var toTake = numbers[1];

            string input = Console.ReadLine();

            string pattern = @"\|<([\w]{" + toSkip + @"})([\w]{0," + toTake + @"})";

            var matches = Regex.Matches(input, pattern);
            List<string> result = new List<string>();

            foreach (Match m in matches)
            {
                result.Add(m.Groups[2].Value);
            }

            Console.WriteLine(string.Join(", " , result));
        }
    }
}
