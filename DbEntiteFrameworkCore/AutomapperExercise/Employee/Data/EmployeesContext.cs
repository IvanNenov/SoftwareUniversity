using Employees.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Employees.Data
{
    public class EmployeesContext : DbContext
    {
        public EmployeesContext()
        {
        }

        public EmployeesContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration.Connectionstring);
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.EmployeeId);

                entity.Property(e => e.FirstName)
                .IsRequired()
                .HasMaxLength(60);

                entity.Property(e => e.LastName)
                .IsRequired()
                .HasMaxLength(60);

                entity.Property(e => e.Address)
                .HasMaxLength(250);
            });
        }
    }
}
