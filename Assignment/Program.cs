using Assignment.Contexts;
using Assignment.Entities;
using Microsoft.EntityFrameworkCore;
namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using itiDbContext ItI   = new itiDbContext();
            Student student01 = new Student()
            {
                FName = "Ahmed",
                LName = "Kamal",
                Address = "Cairo",
                Age = 20,
            };
            Student student02 = new Student()
            {
                FName = "Fatma",
                LName = "Nassar",
                Address = "Menofia",
                Age = 23,
            };
            Student student03 = new Student()
            {
                FName = "Yousef",
                LName = "Walid",
                Address = "Tanta",
                Age = 22,
            };
            Course course01 = new Course()
            {
                Name = "Backend",
                Description = "Web Devolobment",
                Duration = 40,
                Top_ID = 80 
            };
            Topic topic01 = new Topic()
            {
                Name = "Entity Framework"
            };
            Instructor instructor01 = new Instructor()
            {
                Name = "Aliaa",
                Adress = "Cairo",
                Salary = 5000M,
                Bouns = 10,
                HourRate = 50
            };
            #region CRUD Operation
            //ItI.Add<Student>(student01);
            //ItI.Add<Student>(student02);
            //ItI.Add<Student>(student03);
            //ItI.Add<Course>(course01);
            //ItI.Add<Instructor>(instructor01);
            //ItI.Add<Topic>(topic01);
            //ItI.SaveChanges();


            #endregion

            #region Explicit loading 
            //var student = (from s in ItI.Student
            //               where s.ID == 25
            //               select s).FirstOrDefault();
            //ItI.Entry(student).Reference(D => D.Department).Load();
            ////Console.WriteLine($"{student?.FName ?? "Not Found"} :: {student?.Department?.Name ?? "Not Found"}");

            //var department = (from d in ItI.Departments
            //                  where d.ID == 1
            //                  select d).FirstOrDefault();

            //ItI.Entry(department).Collection(D => D.StudentsDepartment).Load();
            //foreach (var item in department.StudentsDepartment)
            //{
            //    Console.WriteLine($"{item?.FName ?? "Not Found"} :: {item?.Department?.Name ?? "Not Found"}");
            //}
            #endregion

            #region eager loading 
            //var student = (from s in ItI.Student.Include(s => s.Department)
            //               where s.ID == 25
            //               select s).FirstOrDefault();

            //Console.WriteLine($"{student?.FName ?? "Not Found"} :: {student?.Department?.Name ?? "Not Found"}");

            //var department = (from d in ItI.Departments.Include( d=> d.StudentsDepartment)
            //                  where d.ID == 1
            //                  select d).FirstOrDefault();

            //foreach (var item in department.StudentsDepartment)
            //{
            //    Console.WriteLine($"{item?.FName ?? "Not Found"} :: {item?.Department?.Name ?? "Not Found"}");
            //}
            #endregion

            #region lazy loading
            //var student = (from s in ItI.Student
            //               where s.ID == 25
            //               select s).FirstOrDefault();

            //Console.WriteLine($"{student?.FName ?? "Not Found"} :: {student?.Department?.Name ?? "Not Found"}");

            //var department = (from d in ItI.Departments
            //                  where d.ID == 1
            //                  select d).FirstOrDefault();

            //foreach (var item in department.StudentsDepartment)
            //{
            //    Console.WriteLine($"{item?.FName ?? "Not Found"} :: {item?.Department?.Name ?? "Not Found"}");
            //}
            #endregion
        }
    }
}
