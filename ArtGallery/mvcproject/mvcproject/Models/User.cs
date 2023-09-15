using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace mvcproject.Models
{
    public class User
    {
        public int id { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string name { get; set; }
        
        [Required]
        [Display(Name = "Surname")]
        public string surname { get; set; }

        [Display(Name ="Phone Number")]
        public string phone_number { get; set; }
        
        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        [StringLength(50)]
        public string email { get; set; }
        
        [Required]
        [Display(Name = "Age")]
        public int age { get; set; }

        [Display(Name ="City")]
        public string city { get; set; }

        [Display(Name = "Country")]
        public string country { get; set; }

        [Display(Name = "Street")]
        public string street { get; set; }

        [Required]
        [Display(Name = "Password")]
        public string password { get; set; }

        public List<User> userinfo { get; set; }
    }
}
