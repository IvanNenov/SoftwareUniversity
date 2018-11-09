using Employees.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employees.Commands
{

    class SetAddresCommand : ICommand
    {
        private readonly EmployeeService employeeService;

        public SetAddresCommand(EmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }

        public string Execute(params string[] args)
        {
            int employeeId = int.Parse(args[0]);
            string addres = string.Join(" ", args.Skip(1));

            var employeeName = employeeService.SetAdress(employeeId, addres);

            return $"{employeeName}'s addres was set to {addres}";
        }
    }
}
