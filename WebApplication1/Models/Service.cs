using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Service
    {
       
        public int Id { get; set; }
        [Required(ErrorMessage = "Поле має бути заповненим")]
        [Display(Name = "Послуга")]
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Specialization> Specializations { get; set; }
    }
}
