using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Group_Project.Models
{
    public class Admins
    {
        public int AdminID { get; set; } //Unique ID

        [Required]
        [Display(Name = "First Name")]
        public string AdminName { get; set; } // can be displayed throughout the website, e.g in index "Welsome Zairul"

        [Required]
        [Display(Name = "Email Address")]
        public string AdminGamil { get; set; } // For Login

        [Required]
        [Display(Name = "Password")]
        public string MemberPassword { get; set; } // For login 

    }
}
