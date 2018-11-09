using System;
using System.Collections.Generic;
using System.Linq;

namespace UserLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            

            SortedDictionary<string, Dictionary<string,int>> result = new SortedDictionary<string, Dictionary<string , int>>();

            string input = Console.ReadLine();
            while (input != "end")
            {

                string[] tokens = input.Split(new[] { '=', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string key = tokens[tokens.Length -1];
                string IpValue = tokens[1];

                if (!result.ContainsKey(key))
                {
                    result.Add(key, new Dictionary<string, int>());
                }
                if (!result[key].ContainsKey(IpValue))
                {
                    result[key].Add(IpValue, 0);
                }
                result[key][IpValue]++;

                input = Console.ReadLine();
            }

            foreach (var kvp in result)
            {
                Console.WriteLine($"{kvp.Key}:");

                List<string> print = new List<string>();
                foreach (var secoundPair in kvp.Value)
                {
                    print.Add($"{secoundPair.Key} => {secoundPair.Value}");
                  
                }
                Console.WriteLine(string.Join(", " ,print) + ".");
            }
        }
    }
}
