using System.ComponentModel.DataAnnotations;

namespace NetMVC.Models
{
    public class Faculty
    {
        [Key]
        public string FacultyID { get; set; }
        public string FacultyName { get; set; }
    }
}