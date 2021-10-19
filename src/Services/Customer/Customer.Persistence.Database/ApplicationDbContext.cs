using System.Diagnostics.CodeAnalysis;
using System;
using Microsoft.EntityFrameworkCore;
using Customer.Domain;
using Customer.Persistence.Database.Configuration;

namespace Customer.Persistence.Database
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public ApplicationDbContext([NotNull] DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.HasDefaultSchema("Customer");

            ModelConfig(modelBuilder);
        }

        private static void ModelConfig(ModelBuilder modelBuilder)
        {
            _ = new ClientConfiguration(modelBuilder.Entity<Client>());
        }
    }
}
