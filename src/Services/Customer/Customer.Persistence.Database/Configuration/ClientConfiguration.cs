using Customer.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.Persistence.Database.Configuration
{
    internal class ClientConfiguration
    {
        public ClientConfiguration(EntityTypeBuilder<Client> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(100);

            var clients = new List<Client>(10);

            for (int i = 1; i <= clients.Capacity; i++)
            {
                clients.Add(new Client
                {
                    Id = i,
                    Name = $"Client {i}"
                });
            }

            builder.HasData(clients);
        }
    }
}
