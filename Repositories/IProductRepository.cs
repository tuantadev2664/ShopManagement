using BusinessObjects;
using System.Linq.Expressions;

namespace Repositories
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();

        Product GetProductById(Expression<Func<Product, bool>> filter);

        void AddProduct(Product product);

        void UpdateProduct(Product product);

        void DeleteProduct(int productId);
    }
}
