using OnLineOrder.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnLinerOrder.Interfaces.Repositories
{
    public interface IOrderRepositories
    {
        Task<int> CreateOrderAsync(Orders order);
    }
}
