using Microsoft.EntityFrameworkCore;

namespace MappedModel
{
    public class StudentContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"Host=localhost;Database=Students;Username=postgres;
                Password=5b16f0abdc32447cbe49a9114ac9ee9b");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .Property(b => b.Gender)
                .HasDefaultValue("M");


            modelBuilder.Entity<Student>()
                .Property(p => p.SystemAge)
                .HasComputedColumnSql("age(CURRENT_TIMESTAMP,DateOfBirth)");

            modelBuilder.Entity<Student>()
                .Property(p => p.FeesOutstanding)
                .HasColumnType("numeric (20,8)");

        }


        public DbSet<Student> Students { get; set; }
    }
}