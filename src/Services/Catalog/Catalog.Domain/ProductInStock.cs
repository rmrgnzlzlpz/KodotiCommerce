using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Domain
{
    public class ProductInStock
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Stock { get; set; }
    }
}
