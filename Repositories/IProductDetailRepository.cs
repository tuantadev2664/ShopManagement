using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IProductDetailRepository
    {
        IEnumerable<ProductDetail> GetAllProductDetails();

        ProductDetail GetProductDetailById(Expression<Func<ProductDetail, bool>> filter);

        void AddProductDetail(ProductDetail productDetail);

        void UpdateProductDetail(ProductDetail productDetail);

        void DeleteProductDetail(int productDetailId);
    }
}
