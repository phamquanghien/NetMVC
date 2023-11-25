using System.ComponentModel.DataAnnotations;

namespace NetMVC.Models
{
    // UserViewModel.cs
    public class UserViewModel
    {
        public required string Id { get; set; }
        [Required]
        [EmailAddress]
        public required string Email { get; set; }
        public string? UserName { get; set; }
        public string? FullName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}