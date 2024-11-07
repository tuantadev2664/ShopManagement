using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetAllCustomers();

        Customer GetCustomerById(Expression<Func<Customer, bool>> filter);

        void AddCustomer(Customer customer);

        void UpdateCustomer(Customer customer);

        void DeleteCustomer(int customerId);
    }
}
