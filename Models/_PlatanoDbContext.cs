using Microsoft.EntityFrameworkCore;
 
namespace PlatanoApi.Model
{
    // >dotnet ef migration add testMigration
    public class PlatanoDbContext : DbContext
    {
        public PlatanoDbContext(DbContextOptions<PlatanoDbContext> options) : base(options)
        { 

        }
         
        public DbSet<Device> Device { get; set; }
        
        public DbSet<AutomationCommand> AutomationCommand { get; set; }
       
        protected override void OnModelCreating(ModelBuilder builder)
        { 
            builder.Entity<Device>().HasKey(m => m.Id);
            builder.Entity<AutomationCommand>().HasKey(m => m.Id);  
            base.OnModelCreating(builder); 
        } 
    }
}
