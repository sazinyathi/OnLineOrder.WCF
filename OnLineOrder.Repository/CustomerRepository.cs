using OnLineOrder.Models;
using OnLinerOrder.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnLineOrder.Repository
{
    public class CustomerRepository:ICustomerRepository 
    {
        private readonly OnLineOrderDbContext dbContext;
        public CustomerRepository()
        {
            this.dbContext = new OnLineOrderDbContext();
        }
   

        public async Task<IEnumerable<Customer>> GetAllCustomerAsync()
        {
            return  dbContext.Customers.ToList();
        }

       public async Task<int> CreateCustomerAsync(Customer customer)
        {

            dbContext.Customers.Add(customer);
            await dbContext.SaveChangesAsync();
            return  customer.CustomerId;
        }
    }
}
