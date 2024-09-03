﻿// <auto-generated />
using System;
using Assignment.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Assignment.Migrations
{
    [DbContext(typeof(itiDbContext))]
    [Migration("20240903013149_Migration12")]
    partial class Migration12
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.33")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Assignment.Entities.Course", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("Top_ID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("Top_ID");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("Assignment.Entities.Course_Inst", b =>
                {
                    b.Property<int>("Course_ID")
                        .HasColumnType("int");

                    b.Property<int>("inst_ID")
                        .HasColumnType("int");

                    b.Property<int>("evaluate")
                        .HasColumnType("int");

                    b.HasKey("Course_ID", "inst_ID");

                    b.ToTable("Course_Inst");
                });

            modelBuilder.Entity("Assignment.Entities.Department", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("HiringDate")
                        .HasColumnType("DateTime");

                    b.Property<int>("Ins_ID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasDefaultValue(" ");

                    b.HasKey("ID");

                    b.HasIndex("Ins_ID")
                        .IsUnique();

                    b.ToTable("Department");
                });

            modelBuilder.Entity("Assignment.Entities.Instructor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Adress")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasDefaultValue(" ");

                    b.Property<int>("Bouns")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<int?>("Dept_ID")
                        .HasColumnType("int");

                    b.Property<int>("HourRate")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Salary")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(18,2)")
                        .HasDefaultValue(3000m);

                    b.HasKey("ID");

                    b.HasIndex("Dept_ID");

                    b.ToTable("Instructor");
                });

            modelBuilder.Entity("Assignment.Entities.Stud_Course", b =>
                {
                    b.Property<int>("stud_ID")
                        .HasColumnType("int");

                    b.Property<int>("Course_ID")
                        .HasColumnType("int");

                    b.Property<int>("Grade")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.HasKey("stud_ID", "Course_ID");

                    b.ToTable("Stud_Course");
                });

            modelBuilder.Entity("Assignment.Entities.Student", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<int?>("Dep_Id")
                        .HasColumnType("int");

                    b.Property<string>("FName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("Dep_Id");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("Assignment.Entities.Topic", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 10L, 10);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Topic");
                });

            modelBuilder.Entity("Assignment.Entities.Course", b =>
                {
                    b.HasOne("Assignment.Entities.Topic", "Topic")
                        .WithMany("Courses")
                        .HasForeignKey("Top_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Topic");
                });

            modelBuilder.Entity("Assignment.Entities.Department", b =>
                {
                    b.HasOne("Assignment.Entities.Instructor", "Manager")
                        .WithOne("Manage")
                        .HasForeignKey("Assignment.Entities.Department", "Ins_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Manager");
                });

            modelBuilder.Entity("Assignment.Entities.Instructor", b =>
                {
                    b.HasOne("Assignment.Entities.Department", "Department")
                        .WithMany("Instructors")
                        .HasForeignKey("Dept_ID");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("Assignment.Entities.Student", b =>
                {
                    b.HasOne("Assignment.Entities.Department", "Department")
                        .WithMany("StudentsDepartment")
                        .HasForeignKey("Dep_Id");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("Assignment.Entities.Department", b =>
                {
                    b.Navigation("Instructors");

                    b.Navigation("StudentsDepartment");
                });

            modelBuilder.Entity("Assignment.Entities.Instructor", b =>
                {
                    b.Navigation("Manage");
                });

            modelBuilder.Entity("Assignment.Entities.Topic", b =>
                {
                    b.Navigation("Courses");
                });
#pragma warning restore 612, 618
        }
    }
}
