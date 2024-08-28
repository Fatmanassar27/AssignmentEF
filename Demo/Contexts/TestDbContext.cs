using Demo.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Contexts
{
    internal class TestDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Data Source = DESKTOP-3CE5M2E ; Initial Catalog = Airline ; Integarted Security = true");
            optionsBuilder.UseSqlServer("Server = . ; Database = Test ; Trusted_Connection = true");
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Departments> Departments { get; set; }
        public DbSet<Products>Products { get; set; }
        public DbSet<Projects>Projects { get; set; }
    }
}
