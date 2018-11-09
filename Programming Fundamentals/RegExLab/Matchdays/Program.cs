using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Matchdays
{
    class Program
    {
        static void Main(string[] args)
        {
            string date = Console.ReadLine();

            string pattern = @"\b(?<day>\d{2})(?<separator>[.\/-])(?<month>[A-Z]{1}[a-z]{2})\2(?<year>\d{4})\b";

            var regex = Regex.Matches (date ,pattern);    
           
           
            foreach (Match match in regex)
            {
                var day = match.Groups["day"].Value;
                var month = match.Groups["month"].Value;
                var year = match.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
           
           

           
        }
    }
}
