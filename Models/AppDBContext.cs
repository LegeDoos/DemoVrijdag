using Microsoft.EntityFrameworkCore;

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
    }
}
