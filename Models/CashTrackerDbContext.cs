using Microsoft.EntityFrameworkCore;

namespace cashTracker.Models
{
    public class CashTrackerDbContext : DbContext
    {
        public DbSet<Expense> Expenses { get; set; }
        public CashTrackerDbContext(DbContextOptions<CashTrackerDbContext> options) : base(options) { }
    }
}
