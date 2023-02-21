using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Chow_Patty_HW4.Models
{
    public class AppUser : IdentityUser
    {
        [Required]
        [Display(Name = "First Name")]
        public String FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public String LastName { get; set; }
    }
}