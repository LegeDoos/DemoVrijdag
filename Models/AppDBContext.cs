using Microsoft.EntityFrameworkCore;
using DemoVrijdag.Models;

namespace DemoVrijdag.Models
{
    public class AppDBContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public AppDBContext(DbContextOptions<AppDBContext> contextOptions) : base(contextOptions)
        {            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            // geef de precisie aan
            modelBuilder.Entity<Course>().Property(p => p.Price).HasPrecision(10, 2);
        }

        public DbSet<DemoVrijdag.Models.Course> Course { get; set; } = default!;
    }
}
