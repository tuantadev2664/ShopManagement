using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IOrderRepository
    {
        IEnumerable<Order> GetAllOrders();

        IEnumerable<Order> GetAllOrders(Customer customer);

        Order GetOrderById(Expression<Func<Order, bool>> filter);

        void AddOrder(Order order);

        void UpdateOrder(Order order);

        void DeleteOrder(int orderId);
    }
}
