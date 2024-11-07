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
    public class OrderDetailRepository : IOrderDetailRepository
    {
        public IEnumerable<OrderDetail> GetAllOrderDetails()
        {
            return OrderDetailDAO.Instance.GetAll();
        }

        public OrderDetail GetOrderDetailById(Expression<Func<OrderDetail, bool>> filter)
        {
            return OrderDetailDAO.Instance.GetById(filter);
        }

        public void AddOrderDetail(OrderDetail orderDetail)
        {
            OrderDetailDAO.Instance.Add(orderDetail);
        }

        public void UpdateOrderDetail(OrderDetail orderDetail)
        {
            OrderDetailDAO.Instance.Update(orderDetail);
        }

        public void DeleteOrderDetail(int orderDetailId)
        {
            OrderDetailDAO.Instance.Delete(orderDetailId);
        }
        
    }
}
