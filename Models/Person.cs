using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetMVC.Models
{
    [Table("Persons")]
    public class Person
    {
        [Key]
        public string PersonID { get; set; }
        [Required(ErrorMessage ="Full name is required")]
        [MaxLength(150)]
        [MinLength(3)]
        public string FullName { get; set; }
        public string Address { get; set; }
    }
}