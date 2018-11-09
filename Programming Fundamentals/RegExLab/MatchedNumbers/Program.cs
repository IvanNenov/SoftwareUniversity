using System;
using System.Text.RegularExpressions;

namespace MatchedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";

            var matches = Regex.Matches(input, pattern);

            foreach (Match match in matches)
            {
                Console.Write(match + " ");
            }
            Console.WriteLine();
        }
    }
}
