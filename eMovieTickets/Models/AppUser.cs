using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace eMovieTickets.Models
{
    public class AppUser : IdentityUser
    {
        [Display(Name = "Full Name")]
        public string FullName { get; set; }
    }
}
