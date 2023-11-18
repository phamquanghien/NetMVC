using Microsoft.AspNetCore.Identity;

namespace NetMVC.Models
{
    public class ApplicationUser : IdentityUser
    {
        public required string FullName { get; set; }
    }
}