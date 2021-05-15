using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Vacancy
    {
       public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int MinSalary { get; set; }
        public int MaxSalary { get; set; }
        public bool IsActive { get; set; }
        public int HospitalId { get; set; }
        public virtual Hospital Hospital { get; set; }
    }
}
