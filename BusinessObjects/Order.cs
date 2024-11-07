using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class Order
    {
        public int OrderId { get; set; }

        public DateOnly OrderDate { get; set; }

        public Decimal TotalPrice { get; set; }

        public int CustomerId { get; set; }

        public OrderStatus OrderStatus { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }

    public enum OrderStatus
    {
        Pending,
        Confirmed,
        Cancelled
    }
}
