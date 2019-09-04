using System.Threading.Tasks;
using OnLineOrder.Models;

namespace OnLinerOrder.Interfaces.Repositories
{
    public interface ICustomerRepository
    {
        Task<int> CreateCustomerAsync(Customer customer);
    }
}
