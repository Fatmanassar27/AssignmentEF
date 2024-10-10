using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment.Entities
{
    public class Department
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        [ForeignKey(nameof(Manager))]
        [AllowNull]
        public int? Ins_ID { get; set; }
        public DateOnly HiringDate { get; set; }

        [InverseProperty(nameof(Instructor.Manage))]
        public virtual Instructor? Manager { get; set; }
        public virtual ICollection<Student> StudentsDepartment { get; set; } = new HashSet<Student>();
        [InverseProperty(nameof(Instructor.Department))]
        public virtual ICollection<Instructor> Instructors { get; set; } = new HashSet<Instructor>();

    }
}
