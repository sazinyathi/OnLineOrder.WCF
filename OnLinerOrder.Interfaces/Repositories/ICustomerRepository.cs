using System.Collections.Generic;
using System.Threading.Tasks;
using OnLineOrder.Models;

namespace OnLinerOrder.Interfaces.Repositories
{
    public interface ICustomerRepository
    {
        Task<int> CreateCustomerAsync(Customer customer);
        Task<IEnumerable<Customer>> GetAllCustomerAsync();
  
    }
}
