using AutoMapper;
using Employees.Data.DtoModels;
using Employees.Data.Models;

namespace Employees
{
    class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Employee, EmployeeDto>();
            CreateMap<EmployeeDto, Employee>();
        }
    }
}
