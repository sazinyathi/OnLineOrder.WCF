using OnLineOrder.Models;
using System.Threading.Tasks;

namespace OnLinerOrder.Interfaces.Repositories
{
    public interface IOrderItemsRepository
    {
        Task CreateOrderItemsAsync(int orderId, OrderItems orderItems);
    }
}
