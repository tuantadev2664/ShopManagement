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
    public class OrderDAO
    {
        private static OrderDAO _instance;
        private static readonly object _lock = new object();
        private ShopDbContext _context = new ShopDbContext();


        public static OrderDAO Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new OrderDAO();
                    }
                    return _instance;
                }
            }
        }

        public IEnumerable<Order> GetAll()
        {
            return _context.Orders
                .Include(o => o.Customer)
                .Include(o => o.OrderDetails)
                .ThenInclude(od => od.ProductDetail)
                .ThenInclude(pd => pd.Product)
                .OrderBy(o => o.OrderStatus)
                .ThenByDescending(o => o.OrderDate)
                .ToList();
        }

        public Order GetById(Expression<Func<Order, bool>> filter)
        {
            return _context.Orders.FirstOrDefault(filter);
        }

        public void Add(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
        }

        public void Update(Order order)
        {
            _context.Orders.Update(order);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var order = _context.Orders.Find(id);
            if (order != null)
            {
                _context.Orders.Remove(order);
                _context.SaveChanges();
            }
        }
    }
}
