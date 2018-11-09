using System;
using System.Collections.Generic;
using System.Linq;

namespace PopulationCounter2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var populationCounter = new Dictionary<string, Dictionary<string, long>>();

            while (input != "report")
            {
                var tokens = input.Split('|').ToArray();

                var city = tokens[0];
                var country = tokens[1];
                var population = long.Parse(tokens[2]);

                if (!populationCounter.ContainsKey(country))
                {
                    populationCounter.Add(country, new Dictionary<string, long>());
                }

                if (!populationCounter[country].ContainsKey(city))
                {
                    populationCounter[country].Add(city, population);
                }

                if (populationCounter.ContainsKey(city))
                {
                    populationCounter[country][city] += population;
                }

                input = Console.ReadLine();
            }

            foreach (var countryes in populationCounter.OrderByDescending(x => x.Value.Values.Sum()))
            {
                Console.WriteLine($"{countryes.Key} (total population: {countryes.Value.Values.Sum()})");

                foreach (var cityes in countryes.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"=>{cityes.Key}: {cityes.Value}");
                } 
            }
        }
    }
}
