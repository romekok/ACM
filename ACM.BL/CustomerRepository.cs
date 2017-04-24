using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
   public class CustomerRepository
    {

        public Customer Retrieve(int customerId)
        {

            var customer = new Customer(customerId);

            if (customerId==1)
            {
                customer.EmailAddress = "jan.nowak@gmail.com";
                customer.FirstName = "Jan";
                customer.LastName = "Nowak";

            }
            return customer;
        }

        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }


        public bool Save()
        {
            return true;
        }

    }
}
