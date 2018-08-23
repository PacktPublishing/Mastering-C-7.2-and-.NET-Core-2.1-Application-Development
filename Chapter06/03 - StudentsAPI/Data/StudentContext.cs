using Microsoft.EntityFrameworkCore;
using StudentsAPI.Models;

namespace StudentsAPI.Data
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
    }
}