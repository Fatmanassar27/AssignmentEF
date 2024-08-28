using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Entities
{
    //internal class Employee
    //{
    //    public int Id { get; set; }
    //    public string? EmpName { get; set; }
    //    public decimal Salary { get; set; }
    //    public int? Age { get; set; }

    //}

    internal class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmpId { get; set; }
        [Required]
        [StringLength(50 , MinimumLength = 3)]
        [Column(TypeName = "varchar")]
        [MaxLength (50)]
        public string? Name { get; set; }
        [DataType(DataType.Currency)]
        //[Column (TypeName = "money")]
        public decimal Salary { get; set; }
        [Range(20,60)]
        public int? Age { get; set; }
        [DataType (DataType.EmailAddress)]
        public string? Email { get; set; }
        [DataType(DataType.Password)]
        public string Passward { get; set; } 
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

    }
}
