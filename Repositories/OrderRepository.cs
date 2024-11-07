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
    public class OrderRepository : IOrderRepository
    {
        public IEnumerable<Order> GetAllOrders()
        {
            return OrderDAO.Instance.GetAll();
        }

        public IEnumerable<Order> GetAllOrders(Customer customer)
        {
            return OrderDAO.Instance.GetAll().Where(o => o.CustomerId == customer.CustomerId).ToList();
        }

        public Order GetOrderById(Expression<Func<Order, bool>> filter)
        {
            return OrderDAO.Instance.GetById(filter);
        }

        public void AddOrder(Order order)
        {
            OrderDAO.Instance.Add(order);
        }

        public void UpdateOrder(Order order)
        {
            OrderDAO.Instance.Update(order);
        }

        public void DeleteOrder(int orderId)
        {
            OrderDAO.Instance.Delete(orderId);
        }
    }
}
