using System;
using Employees.Data;
using Employees.Data.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AutoMapper;

namespace Employees
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var serviceProvider = ConfigureServices();
            var engine = new Engine(serviceProvider);
            engine.Run();
        }

        static IServiceProvider ConfigureServices()
        {
            var serviceCollection = new ServiceCollection();

            serviceCollection.AddDbContext<EmployeesContext>(option => option.UseSqlServer(Configuration.Connectionstring));

            serviceCollection.AddTransient<EmployeeService>();
            serviceCollection.AddAutoMapper(cfg => cfg.AddProfile<AutomapperProfile>());
            var provider = serviceCollection.BuildServiceProvider();

            return provider;
        }
    }
}
