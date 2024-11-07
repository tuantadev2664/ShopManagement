using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IOrderDetailRepository
    {
        IEnumerable<OrderDetail> GetAllOrderDetails();

        OrderDetail GetOrderDetailById(Expression<Func<OrderDetail, bool>> filter);

        void AddOrderDetail(OrderDetail orderDetail);

        void UpdateOrderDetail(OrderDetail orderDetail);

        void DeleteOrderDetail(int orderDetailId);
    }
}
