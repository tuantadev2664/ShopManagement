using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class Customer
    {
        public int CustomerId { get; set; }

        public string CustomerName { get; set; }

        public string Phone {  get; set; }
       
        public string Email { get; set; }

        public string Password { get; set; }

        public string Address { get; set; }

        public CustomerStatus CustomerStatus { get; set; }


        public virtual ICollection<Order> Orders { get; set; }
    }

    public enum CustomerStatus
    {
        Active,
        Deleted
    }
}
