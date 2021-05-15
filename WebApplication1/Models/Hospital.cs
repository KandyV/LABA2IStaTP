﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Hospital
    {
       public int Id { get; set; }
        public string Name { get; set; }
        public int WorkHours { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Doctor> Doctors { get; set; }
    }
}
