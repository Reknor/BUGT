using Microsoft.EntityFrameworkCore;

namespace Bug_Tracker.Models
{
    public class DataBaseContext: DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options): base(options)
        {

        }

        public DbSet<Project> Projects { get; set; }

        public DbSet<Bug> Bugs { get; set; }
    }
}
