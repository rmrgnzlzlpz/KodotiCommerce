using Microsoft.EntityFrameworkCore;
using Order.Domain;
using Order.Persistence.Database.Configuration;

namespace Order.Persistence.Database
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Domain.Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.HasDefaultSchema("Order");

            ModelConfig(modelBuilder);
        }


        private static void ModelConfig(ModelBuilder modelBuilder)
        {
            _ = new OrderConfiguration(modelBuilder.Entity<Domain.Order>());
            _ = new OrderDetailConfiguration(modelBuilder.Entity<OrderDetail>());
        }
    }
}
