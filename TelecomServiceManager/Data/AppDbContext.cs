using Microsoft.EntityFrameworkCore;
using TelecomServiceManager.Models;

namespace TelecomServiceManager.Data
{
    public class AppDbContext : DbContext
    {
        // Constructor that takes options
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // DbSets for your entities/models
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Bill> Bills { get; set; }

        // Optional: Override OnModelCreating for model configuration
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // You can add Fluent API configurations here if needed
            // For example:
            // modelBuilder.Entity<Customer>().HasIndex(c => c.Email).IsUnique();
        }
    }
}
