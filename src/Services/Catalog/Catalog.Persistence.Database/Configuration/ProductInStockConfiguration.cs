using Catalog.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Persistence.Database.Configuration
{
    public class ProductInStockConfiguration
    {
        public ProductInStockConfiguration(EntityTypeBuilder<ProductInStock> builder)
        {
            builder.HasIndex(x => x.Id);

            var stocks = new List<ProductInStock>(100);
            var random = new Random();

            for (int i = 1; i <= 100; i++)
            {
                stocks.Add(new ProductInStock
                {
                    Id = i,
                    ProductId = i,
                    Stock = random.Next(0, 100),
                });
            }

            builder.HasData(stocks);
        }
    }
}
