using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Linq;
using Employees.Commands;
using Microsoft.Extensions.DependencyInjection;

namespace Employees
{
    public class CommandParser
    {
        public static ICommand Parse(IServiceProvider serviceProvider, string commandName)
        {
            var assembly = Assembly.GetExecutingAssembly();

            var commandTypes = assembly.GetTypes().Where(t => t.GetInterfaces().Contains(typeof(ICommand)));
             
            var commandType = commandTypes.SingleOrDefault(t => t.Name.ToLower() == $"{commandName.ToLower()}command");
            if (commandType == null)
            {
                throw new InvalidOperationException("Invalid Command");
            }
            var constructor = commandType.GetConstructors().First();
            var ctorParams = constructor.GetParameters().Select(pi => pi.ParameterType).ToArray();

            var ctorArgs = ctorParams.Select(p => serviceProvider.GetService(p)).ToArray();
            var command =(ICommand) constructor.Invoke(ctorArgs);
            return command;
        }
    }
}
