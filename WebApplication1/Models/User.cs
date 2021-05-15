using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class User
    {
      
           
        public int Id { get; set; }
        [Required(ErrorMessage = "Поле має бути заповненим")]
        [Display(Name = "Поштова скринька")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Поле має бути заповненим")]
        [Display(Name = "Пароль")]
        public string Password { get; set; }
        public int BirthDay { get; set; }
        public string Sex { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
