using System;
using System.Collections.Generic;
using System.Text;

namespace Employees.Data.DtoModels
{
    public class EmployeeDto
    {
        public EmployeeDto(string firstName, string lastName, decimal salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;
        }

        public EmployeeDto()
        {
        }

        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; } 
    }
}
