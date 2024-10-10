﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Entities
{
    public class Course_Inst
    {
        public int inst_ID { get; set; }
        public int Course_ID { get; set; }
        public int evaluate { get; set; }

        public virtual Course Course  { get; set; }
        public virtual Instructor Instructor  { get; set; }
    }
}
