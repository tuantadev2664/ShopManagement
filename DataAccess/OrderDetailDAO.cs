using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class OrderDetailDAO
    {
        private static OrderDetailDAO _instance;
        private static readonly object _lock = new object();
        private ShopDbContext _context = new ShopDbContext();


        public static OrderDetailDAO Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new OrderDetailDAO();
                    }
                    return _instance;
                }
            }
        }

        public IEnumerable<OrderDetail> GetAll()
        {
            return _context.OrderDetails.ToList();
        }

        public OrderDetail GetById(Expression<Func<OrderDetail, bool>> filter)
        {
            return _context.OrderDetails.FirstOrDefault(filter);
        }

        public void Add(OrderDetail orderDetail)
        {
            _context.OrderDetails.Add(orderDetail);
            _context.SaveChanges();
        }

        public void Update(OrderDetail orderDetail)
        {
            _context.OrderDetails.Update(orderDetail);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var orderDetail = _context.OrderDetails.Find(id);
            if (orderDetail != null)
            {
                _context.OrderDetails.Remove(orderDetail);
                _context.SaveChanges();
            }
        }
    }
}
