using System;
using System.Text.RegularExpressions;

namespace Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"(?<=\s)([a-z]+|\d+)(\d+|\w+|\.+|-+)([a-z]+|\d+)\@[a-z]+\-?[a-z]+\.[a-z]+(\.[a-z]+)?";

            var result = Regex.Matches(input, pattern);

            foreach (Match email in result)
            {
                Console.WriteLine(email);
            }
        }
    }
}
