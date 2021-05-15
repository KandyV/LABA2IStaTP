using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Specialization
    { 
        public int Id { get; set; }
        public int DoctorId { get; set; }
        public int ServiceId { get; set; }
        [ForeignKey("DoctorId")]
        public virtual Doctor Doctor { get; set; }
        [ForeignKey("ServiceId")]
        public virtual Service Service { get; set; }

    }
}
