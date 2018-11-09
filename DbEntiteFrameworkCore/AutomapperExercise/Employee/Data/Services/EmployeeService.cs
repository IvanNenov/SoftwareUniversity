using Employees.Data;
using Employees.Data.DtoModels;
using AutoMapper;
using Employees.Data.Models;
using System;

namespace Employees.Data.Services
{
    public class EmployeeService
    {
        private readonly EmployeesContext context;

        public EmployeeService(EmployeesContext context)
        {
            this.context = context;
        }

        public EmployeeDto ById(int Id)
        {
            var employee = context.Employees.Find(Id);

            var employeeDto = Mapper.Map<EmployeeDto>(employee);

            return employeeDto;
        }

        public void AddEmployee(EmployeeDto dto)
        {
            var employee = Mapper.Map<Employee>(dto);
            context.Employees.Add(employee);
            context.SaveChanges();
        }
        public string SetBirthday(int employeeId ,DateTime Date)
        {
            var employee = context.Employees.Find(employeeId);
            employee.Birthday = Date;
            context.SaveChanges();
            return $"{employee.FirstName} {employee.LastName}";
        }

        public string SetAdress(int employeeId, string addres)
        {
            var employee = context.Employees.Find(employeeId);
            employee.Address = addres;
            context.SaveChanges();
            return $"{employee.FirstName} {employee.LastName}";
        }
    }
}
