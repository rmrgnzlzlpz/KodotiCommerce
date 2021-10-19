using Catalog.Domain;
using Catalog.Persistence.Database.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Persistence.Database
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductInStock> Stocks { get; set; }
        private string SchemaName { get; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            SchemaName = "Catalog";
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.HasDefaultSchema(SchemaName);

            ModelConfig(builder);
        }

        private static void ModelConfig(ModelBuilder builder)
        {
            _ = new ProductConfiguration(builder.Entity<Product>());
            _ = new ProductInStockConfiguration(builder.Entity<ProductInStock>());
        }
    }
}
