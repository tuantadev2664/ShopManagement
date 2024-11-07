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
    public class CustomerRepository : ICustomerRepository
    {
        public IEnumerable<Customer> GetAllCustomers()
        {
            return CustomerDAO.Instance.GetAll();
        }

        public Customer GetCustomerById(Expression<Func<Customer, bool>> filter)
        {
            return CustomerDAO.Instance.GetById(filter);
        }

        public void AddCustomer(Customer customer)
        {
            CustomerDAO.Instance.Add(customer);
        }

        public void UpdateCustomer(Customer customer)
        {
            CustomerDAO.Instance.Update(customer);
        }

        public void DeleteCustomer(int customerId)
        {
            CustomerDAO.Instance.Delete(customerId);
        }
    }
}
