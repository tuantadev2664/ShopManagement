using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }

        public int ProductDetailId { get; set; }

        public int OrderId { get; set; }

        public int Quantity { get; set; }

        public Decimal ActualPrice { get; set; }


        public virtual ProductDetail ProductDetail { get; set; }
        public virtual Order Order { get; set; }


    }
}
