using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CustomerDAO
    {
        private static CustomerDAO _instance;
        private static readonly object _lock = new object();
        private ShopDbContext _context = new ShopDbContext();


        public static CustomerDAO Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new CustomerDAO();
                    }
                    return _instance;
                }
            }
        }

        public IEnumerable<Customer> GetAll()
        {
            return _context.Customers.ToList();
        }

        public Customer GetById(Expression<Func<Customer, bool>> filter)
        {
            return _context.Customers.FirstOrDefault(filter);
        }

        public void Add(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }

        public void Update(Customer customer)
        {
            _context.Customers.Update(customer);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var customer = _context.Customers.Find(id);
            if (customer != null)
            {
                _context.Customers.Remove(customer);
                _context.SaveChanges();
            }
        }
    }
}
