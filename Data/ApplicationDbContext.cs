
using Microsoft.EntityFrameworkCore;
using NetMVC.Models;
namespace NetMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        //khai bao anh xa vao database
        public DbSet<Person> Person { get; set; }
        public DbSet<Student> Student { get; set; }
    }
}