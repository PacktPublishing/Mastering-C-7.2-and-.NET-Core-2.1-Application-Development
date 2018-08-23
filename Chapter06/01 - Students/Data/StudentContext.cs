using Microsoft.EntityFrameworkCore;
using Students.Models;

namespace Students.Data
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
    }
}