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

        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite(@"Data Source=C:\Users\nicho\source\repos\NicFWebApp\NicFWebApp\db");*/

        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var dbPath = Path.Combine(ApplicationData.Current.LocalFolder.Path, "Database.db");
            optionsBuilder.UseSqlite("Filename = " + dbPath);
            base.OnConfiguring(optionsBuilder);
        }*/

        /*{
            base.OnConfiguring(optionsBuilder);
        }*/
    }
}
