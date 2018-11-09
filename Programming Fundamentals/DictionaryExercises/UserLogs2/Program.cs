using System;
using System.Collections.Generic;
using System.Linq;

namespace UserLogs2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string user;
            string ip;

            SortedDictionary<string, Dictionary<string, int>> result = new SortedDictionary<string, Dictionary<string, int>>();

            while (input != "end")
            {
                var tokens = input
                    .Split(new[] { ' ', '=' } ,StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                 user = tokens[tokens.Length-1];
                 ip = tokens[1];

                if (!result.ContainsKey(user))
                {
                    result.Add(user, new Dictionary<string, int>());
                }
                if (!result[user].ContainsKey(ip))
                {
                    result[user].Add(ip, 1);
                }
                else if (result[user].ContainsKey(ip))
                {
                    result[user][ip]++;
                }

                input = Console.ReadLine();
            }

            foreach (var users in result)
            {
                Console.WriteLine($"{users.Key}:");
                List<string> countUser = new List<string>();

                foreach (var data in users.Value)
                {
                    countUser.Add($"{data.Key} => {data.Value}");
                }
                Console.WriteLine($"{string.Join(", " , countUser)}.");
            }
        }
    }
}
