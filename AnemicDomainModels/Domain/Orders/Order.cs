using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Orders
{
    public class Order
    {
        public Guid Id { get; set; }

        public Guid CustomerId { get; set; }
        public List<LineItem> LineItems { get; set; }

    }
}
