using System;
using System.Collections.Generic;
using System.Linq;

namespace FixEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var nameAndEmail = new Dictionary<string, string>();

            while (input != "stop")
            {
                var email = Console.ReadLine();

                if (!nameAndEmail.ContainsKey(input) && !email.EndsWith("uk") && !email.EndsWith("us"))
                {
                    nameAndEmail.Add(input,email);
                }
                    
                input = Console.ReadLine();
            }

            foreach (var kvp in nameAndEmail)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
