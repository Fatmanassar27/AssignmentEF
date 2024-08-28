using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Entities
{
    internal class Course
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
        public int Top_ID { get; set; }
    }
}
