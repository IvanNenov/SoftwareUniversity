using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ReplaceTag
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "end")
            {
                string pattern = @"<a.*?href.*?=(.*)>(.*?)<\/a>"; 
                var replace = Regex.Replace(input, pattern, @"[URL href=$1]$2[/URL]");
                Console.WriteLine(replace);
                input = Console.ReadLine(); 
            }

        }
    }
}
