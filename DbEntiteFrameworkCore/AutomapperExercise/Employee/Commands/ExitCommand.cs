using System;
using System.Collections.Generic;
using System.Text;

namespace Employees.Commands
{
    class ExitCommand : ICommand
    {
        public string Execute(params string[] args)
        {
            Console.WriteLine("GoodBye");
            Environment.Exit(0);
            return null;
        }
    }
}
