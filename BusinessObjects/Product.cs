using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class Product
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public string ProductDescription { get; set; }

        public string ProductImage {  get; set; }

        public List<string> ProductColor { get; set; }

        public List<string> ProductSize { get; set; }

        public Decimal ProductPrice { get; set; }
        
        public Category Category { get; set; }

        public virtual ICollection<ProductDetail> ProductDetails { get; set; }
    }

    public enum Category
    {
        Shirt,
        Pants
    }
}
