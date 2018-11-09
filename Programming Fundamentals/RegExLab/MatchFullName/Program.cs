using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"\b[A-Z]{1}[a-z]+ [A-Z][a-z]+\b";

            Regex regex = new Regex(pattern);

            MatchCollection result = regex.Matches(input);

            foreach (Match match in result)
            {
                Console.Write(match + " ");
            }
            Console.WriteLine();
        }
    }
}
