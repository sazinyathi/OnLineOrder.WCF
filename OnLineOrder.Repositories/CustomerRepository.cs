using OnLineOrder.Models;
using OnLinerOrder.Interfaces.Repositories;
using System.Threading.Tasks;

namespace OnLineOrder.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly OnLineOrderDbContext dbContext;
        public CustomerRepository()
        {
            this.dbContext = new OnLineOrderDbContext();
        }

        public async Task<int> CreateCustomerAsync(Customer customer)
        {
            try
            {
                dbContext.Customers.Add(customer);
                await dbContext.SaveChangesAsync();
                return customer.CustomerId;
            }
            catch (System.Exception exc)
            {
                throw;
            }
        }
    }
}
