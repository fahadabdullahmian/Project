using Microsoft.EntityFrameworkCore;



namespace Web_API.Server.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Student> Stude { get; set; }
    }
}
