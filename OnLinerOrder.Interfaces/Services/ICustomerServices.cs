using System.Threading.Tasks;
using OnLineOrder.Models;

namespace OnLinerOrder.Interfaces.Repositories
{
    public interface ICustomerServices
    {
        Task<int> CreateCustomerAsync(Customer customer);
    }
}
