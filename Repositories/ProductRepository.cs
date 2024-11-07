using BusinessObjects;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class ProductRepository : IProductRepository
    {
        public IEnumerable<Product> GetAllProducts()
        {
            return ProductDAO.Instance.GetAll();
        }

        public Product GetProductById(Expression<Func<Product, bool>> filter)
        {
            return ProductDAO.Instance.GetById(filter);
        }

        public void AddProduct(Product product)
        {
            ProductDAO.Instance.Add(product);
        }

        public void UpdateProduct(Product product)
        {
            ProductDAO.Instance.Update(product);
        }

        public void DeleteProduct(int productId)
        {
            ProductDAO.Instance.Delete(productId);
        }
    }
}
