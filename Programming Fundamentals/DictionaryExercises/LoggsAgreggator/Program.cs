using System;
using System.Collections.Generic;
using System.Linq;

namespace LoggsAgreggator
{
    class Program
    {
        static void Main(string[] args)
        {
            int loggedPeople = int.Parse(Console.ReadLine());
            var result = new SortedDictionary<string, SortedDictionary<string, int>>();

            for (int i = 0; i < loggedPeople; i++)
            {
                List<string> input = Console.ReadLine().Split().ToList();

                var ip = input[0];
                var user = input[1];
                var duration = int.Parse(input[2]);

                if (!result.ContainsKey(user))
                {
                    result.Add(user, new SortedDictionary<string, int>());
                }

                if (!result[user].ContainsKey(ip))
                {
                    result[user].Add(ip, duration);
                }

                else
                {
                    result[user][ip] += duration;
                }

            }

            foreach (var user in result)
            {
                var totalDuration = result[user.Key].Values.Sum();
                var listOfIps = user.Value.Keys.ToList();

                Console.WriteLine($"{user.Key}: {totalDuration} [{string.Join(", " , listOfIps)}] ");
            }
        }
    }
}
