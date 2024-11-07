using BusinessObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ProductDetailDAO
    {
        private static ProductDetailDAO _instance;
        private static readonly object _lock = new object();
        private ShopDbContext _context = new ShopDbContext();


        public static ProductDetailDAO Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new ProductDetailDAO();
                    }
                    return _instance;
                }
            }
        }

        public IEnumerable<ProductDetail> GetAll()
        {
            return _context.ProductDetails.ToList();
        }

        public ProductDetail GetById(Expression<Func<ProductDetail, bool>> filter)
        {
            return _context.ProductDetails.AsNoTracking().FirstOrDefault(filter);
        }

        public void Add(ProductDetail productDetail)
        {
            _context.ProductDetails.Add(productDetail);
            _context.SaveChanges();
        }

        public void Update(ProductDetail productDetail)
        {
            _context.ProductDetails.Update(productDetail);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var productDetail = _context.ProductDetails.Find(id);
            if (productDetail != null)
            {
                _context.ProductDetails.Remove(productDetail);
                _context.SaveChanges();
            }
        }
    }
}
