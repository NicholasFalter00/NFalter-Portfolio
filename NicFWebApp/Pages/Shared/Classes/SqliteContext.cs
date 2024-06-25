using Microsoft.EntityFrameworkCore;

namespace NicFWebApp.Pages.Shared.Classes
{
    public class SqliteContext : DbContext
    {
        public SqliteContext(DbContextOptions<SqliteContext> option) : base(option)
        {
        }

        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Task> Tasks { get; set; }
    }
}
