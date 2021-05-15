using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Experience { get; set; }
        public int HospitalId { get; set; }
        [ForeignKey("SpecializationId")]
        public virtual ICollection<Specialization> Specializations { get; set; }
        public virtual Hospital Hospital { get; set; }
    }
}
