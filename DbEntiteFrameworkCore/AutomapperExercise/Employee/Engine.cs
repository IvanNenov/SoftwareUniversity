using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Extensions.DependencyInjection;

namespace Employees
{
    public class Engine
    {
        private readonly IServiceProvider serviceProvider;

        public Engine(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        internal void Run()
        {
            while (true)
            {
                string input = Console.ReadLine();

                var commandTokens = input.Split();
                string commandName = commandTokens[0];

                var commandArgs = commandTokens.Skip(1).ToArray();

                var command = CommandParser.Parse(serviceProvider, commandName);

                var result = command.Execute(commandArgs);
                Console.WriteLine(result);
            }
        }
    }
}
