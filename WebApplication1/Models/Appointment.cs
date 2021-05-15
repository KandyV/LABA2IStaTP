using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Appointment
    {
       
       
        public int Id { get; set; }
        public int DateTime { get; set; }
        public int HospitalId { get; set; }
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
        [ForeignKey("SpecializationId")]
        public virtual Specialization Specialization { get; set; }
        
    }
}
