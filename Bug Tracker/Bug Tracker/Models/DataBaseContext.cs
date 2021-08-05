using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Bug_Tracker.Models
{
    public class DataBaseContext: IdentityDbContext<IdentityUser>
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options): base(options)
        {
           
        }

        public DbSet<Project> Projects { get; set; }

        public DbSet<Bug> Bugs { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Add default value for property status in Bug model
            modelBuilder.Entity<Bug>()
                .Property(b => b.Status)
                .HasDefaultValue("reported");
           
        }
    }
}
