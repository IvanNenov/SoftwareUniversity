using Employees.Data.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Employees.Commands
{
    class SetBirthday : ICommand
    {
        private readonly EmployeeService employeeService;

        public SetBirthday(EmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }


        public string Execute(params string[] args)
        {
            int employeeId = int.Parse(args[0]);
            DateTime date = DateTime.ParseExact(args[1], "dd-MM-yyyy", null);

           var employeeName =  employeeService.SetBirthday(employeeId, date);

            return $"{employeeName}'s addres was set to {args[1]}";
        }
    }
}
