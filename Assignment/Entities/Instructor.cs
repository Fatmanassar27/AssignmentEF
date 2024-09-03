using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Entities
{
    internal class Instructor
    {
       public int ID { get; set; }
       public string? Name { get; set; }
       public int Bouns { get; set; }
       public decimal Salary { get; set; }
       public string? Adress { get; set; }
       public int HourRate { get; set; }
       [ForeignKey(nameof(Department))]
       public int? Dept_ID { get; set; }
       [InverseProperty(nameof(Entities.Department.Instructors))]
       public Department? Department { get; set; }
       [InverseProperty(nameof(Entities.Department.Manager))]
        public Department? Manage { get; set; }
        public ICollection<Course_Inst>? course_Insts { get; set; } = new HashSet<Course_Inst>();
    }
}
