using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Group_Project.Models
{
    public class Memebers
    {

        public int MemberID { get; set; } //Unique ID

        [Required]
        [Display(Name = "First Name")]
        public string MemberName { get; set; } // can be displayed throughout the website, e.g in index "Welsome Zairul"

        [Required]
        [Display(Name = "Email Address")]
        public string MemberGamil { get; set; } // For login 

        [Required]
        [Display(Name = "Password")]
        public string MemberPassword { get; set; } // For login 

        [Required]
        [Display(Name = "Membership")]
        public string Membership { get; set; } // Free | Basic  £3.99 | Full £8.99 | *Only one can be selected*

                                               // Free - 1-2 Playlists 
                                               // Basic - 3-5 Playlists
                                               // Full - all available playlists


    }
}
