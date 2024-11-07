using BusinessObjects;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DataAccess
{
    public class ProductDAO
    {
        private static ProductDAO _instance;
        private static readonly object _lock = new object();
        private ShopDbContext _context = new ShopDbContext();


        public static ProductDAO Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new ProductDAO();
                    }
                    return _instance;
                }
            }
        }

        public IEnumerable<Product> GetAll()
        {
            return _context.Products.ToList();
        }

        public Product GetById(Expression<Func<Product, bool>> filter)
        {
            return _context.Products.Include(p => p.ProductDetails).FirstOrDefault(filter);
        }

        public void Add(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void Update(Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var product = _context.Products.Find(id);
            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
        }
    }
}
