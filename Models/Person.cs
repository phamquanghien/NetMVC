using System.ComponentModel.DataAnnotations;

namespace NetMVC.Models
{
    public class Person
    {
        [Key]
        public string PersonID { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
    }
}