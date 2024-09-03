using Assignment.Contexts;
using Assignment.Entities;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            itiDbContext ItI = new itiDbContext();
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
                Duration = 40
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
            //ItI.Add<Topic>(topic01);
            //ItI.Add<Instructor>(instructor01);
            //ItI.SaveChanges();

            //Console.WriteLine(ItI.Entry(topic01).State);

            //var student = (from s in ItI.Student
            //               where s.ID < 3
            //               select s).FirstOrDefault();
            ////Console.WriteLine(ItI.Entry(student).State);
            ////student.FName = "Mohamed";
            ////Console.WriteLine(student?.FName ?? "Not Found");
            ////ItI.Student.Remove(student);
            ////Console.WriteLine(ItI.Entry(student).State);
            //ItI.SaveChanges();
            //Console.WriteLine(ItI.Entry(student).State); 
            #endregion

        }
    }
}
