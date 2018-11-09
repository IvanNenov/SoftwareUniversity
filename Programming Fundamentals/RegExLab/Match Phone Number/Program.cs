using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
namespace Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"\+359(-|\s)2(\1)(\d{3}|\d{4})(\1)(\d{4})\b";

            var regex = Regex.Matches(input, pattern);
             
            List<string> result = new List<string>();

            foreach (Match match in regex)
            {
                result.Add(match.Value);
            }

            Console.WriteLine(string.Join(", " , result));
        }
    }
}
