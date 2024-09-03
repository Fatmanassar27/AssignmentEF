using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment.Entities
{
    internal class Department
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        [ForeignKey(nameof(Manager))]
        public int Ins_ID { get; set; }
        public DateTime HiringDate { get; set; }

        [InverseProperty(nameof(Instructor.Manage))]
        public Instructor? Manager { get; set; }
        public ICollection<Student> StudentsDepartment { get; set; } = new HashSet<Student>();
        [InverseProperty(nameof(Instructor.Department))]
        public ICollection<Instructor> Instructors { get; set; } = new HashSet<Instructor>();

    }
}
