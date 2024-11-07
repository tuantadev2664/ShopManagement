using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class ProductDetail
    {
        public int ProductDetailId { get; set; }

        public int ProductId { get; set; }

        public Color Color { get; set; }

        public Size Size { get; set; }

        public int Stock { get; set; }

        public virtual Product Product { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

    }

    public enum Color
    {
        Black,
        White, 
    }

    public enum Size
    {
        S,
        M,
        L,
    }
}
