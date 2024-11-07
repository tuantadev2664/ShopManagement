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
    public class ProductDetailRepository : IProductDetailRepository
    {
        public IEnumerable<ProductDetail> GetAllProductDetails()
        {
            return ProductDetailDAO.Instance.GetAll();
        }

        public ProductDetail GetProductDetailById(Expression<Func<ProductDetail, bool>> filter)
        {
            return ProductDetailDAO.Instance.GetById(filter);
        }

        public void AddProductDetail (ProductDetail productDetail)
        {
            ProductDetailDAO.Instance.Add(productDetail);
        }

        public void UpdateProductDetail(ProductDetail productDetail)
        {
            ProductDetailDAO.Instance.Update(productDetail);
        }

        public void DeleteProductDetail(int productDetailId)
        {
            ProductDetailDAO.Instance.Delete(productDetailId);
        }
    }
}
