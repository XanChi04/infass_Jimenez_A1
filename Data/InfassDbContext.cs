using Microsoft.EntityFrameworkCore;
using infass_Jimenez_A1.Models;

namespace infass_Jimenez_A1.Data
{
    public class InfassDbContext : DbContext
    {
        public InfassDbContext(DbContextOptions<InfassDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { UserId = 1, Email = "user1@example.com", Password = "Password1" }
            );
        }
    }
}
