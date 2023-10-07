using System.ComponentModel.DataAnnotations;

namespace NetMVC.Models
{
    public class Student
    {
        [Required(ErrorMessage = "Vui long nhap Student id")]
        public string StudentID { get; set; }
        [Required]
        public string FullName { get; set; }
    }
}