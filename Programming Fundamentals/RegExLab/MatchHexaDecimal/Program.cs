using System;
using System.Text.RegularExpressions;

namespace MatchHexaDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"\b(?:0x)?[0-9A-F]+\b";

            Regex regex = new Regex(pattern);
            var result = regex.Matches(input);

            foreach (Match match in result)
            {
                Console.Write(match + " ");
            }
        }
    }
}
