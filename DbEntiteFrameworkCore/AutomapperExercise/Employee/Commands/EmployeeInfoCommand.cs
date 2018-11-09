﻿using Employees.Data.Services;

namespace Employees.Commands
{
    class EmployeeInfoCommand : ICommand
    {
        private readonly EmployeeService employeeService;

        public EmployeeInfoCommand(EmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }


        public string Execute(params string[] args)
        {
            int employeeId = int.Parse(args[0]);
            var employee = employeeService.ById(employeeId);

            return $"Id : {employeeId} - {employee.FirstName} { employee.LastName} {employee.Salary}";
        }
    }
}
