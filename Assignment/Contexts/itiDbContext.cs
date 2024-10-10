using Assignment.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment.configuration;

namespace Assignment.Contexts
{
    internal class itiDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new Course_InstConfiguration());
            modelBuilder.ApplyConfiguration(new TopicConfiguration());
            modelBuilder.ApplyConfiguration(new Stud_CourseConfiguration());
            modelBuilder.Entity<Department>(D =>
            {
                D.HasKey(D => D.ID);
                D.Property(D => D.ID)
                 .UseIdentityColumn(1, 1);
                D.Property(nameof(Department.Name))
                 .HasColumnType("varchar")
                 .HasDefaultValue(" ")
                 .HasMaxLength(100);
                D.Property(D => D.HiringDate)
                 .HasDefaultValueSql("GETDATE()");
            }
            );
            modelBuilder.Entity<Instructor>( I =>
            {
                modelBuilder.Entity<Instructor>().HasKey(I => I.ID);
                modelBuilder.Entity<Instructor>().Property(I => I.ID)
                                                 .UseIdentityColumn(1, 1);
                modelBuilder.Entity<Instructor>().Property(I=> I.Adress)
                                                 .HasDefaultValue(" ")
                                                 .HasMaxLength(100);
                modelBuilder.Entity<Instructor>().Property(I => I.Salary)
                                                 .HasDefaultValue(3000M);
                modelBuilder.Entity<Instructor>().Property(I => I.Bouns)
                                                 .HasDefaultValue(0);
            }

            );
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Server = . ; Database = iti ; Trusted_Connection = true ; trustServerCertificate = true",X => X.UseDateOnlyTimeOnly());
        }
        public DbSet<Student> Student { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Course { get; set; }

    }
}
