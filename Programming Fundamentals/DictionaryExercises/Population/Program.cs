using System;
using System.Collections.Generic;
using System.Linq;

namespace Population
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split('|').ToArray();
            var countryPopulation = new Dictionary<string,Dictionary<string, long>>();
          

            while (input[0] != "report")
            {
                var country = input[1];
                var city = input[0];
                

                if (!countryPopulation.ContainsKey(country))
                {
                    countryPopulation.Add(country, new Dictionary<string,long>());
                }
                    
                if (!countryPopulation[country].ContainsKey(city))
                {
                    countryPopulation[country].Add(city, long.Parse(input[2]));
                }

                input = Console.ReadLine().Split('|').ToArray();
            }

            foreach (var kvp in countryPopulation.OrderByDescending(x => x.Value.Values.Sum()))
            {
                Console.WriteLine($"{kvp.Key} (total population: {kvp.Value.Values.Sum()})");

                foreach (var item in kvp.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"=>{item.Key}: {item.Value}");
                }
            }
           
        }
    }
}
