using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetMVC.Models
{
    public class Student : Person
    {
        [Required(ErrorMessage = "Vui long nhap Student id")]
        public string StudentID { get; set; }
        public string FacultyID { get; set; }
        [ForeignKey("FacultyID")]
        public Faculty? Faculty { get; set; }

    }
}