using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Common.Collection
{
    public class DataCollection<T>
    {
        public IEnumerable<T> Items { get; set; }
        public int Total { get; set; }
        public int Page { get; set; }
        public int Pages { get; set; }
        public bool HasItems
        {
            get
            {
                return Items is not null && Items.Any();
            }
        }
    }
}
