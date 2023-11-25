using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace NetMVC.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? FullName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}