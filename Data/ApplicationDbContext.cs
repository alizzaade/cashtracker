using cashTracker.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace cashTracker.Data
{
    public class ApplicationDbContext(DbContextOptions options) : IdentityDbContext<Users>(options)
    {
        public DbSet<Expense> Expenses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Expense>()
                .Property(e => e.Value)
                .HasPrecision(18, 2);
        }
    }
}
