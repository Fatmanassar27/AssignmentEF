using System;
using System.Collections.Generic;
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
       public int Dept_ID { get; set; }
    }
}
