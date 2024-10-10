using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Entities
{
    public class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int Duration { get; set; }
        [Required]
        [StringLength(50 , MinimumLength = 3)]
        [Column(TypeName = "varchar")]
        public string? Name { get; set; }
        public string? Description { get; set; }
        [ForeignKey("Topic")]
        public int Top_ID { get; set; }
        public virtual Topic Topic { get; set; }
        public  virtual ICollection<Stud_Course>? StudentCourses { get; set; } = new HashSet<Stud_Course>();
        public  virtual ICollection<Course_Inst>? course_Insts { get; set; } = new HashSet<Course_Inst>();
    }
}
