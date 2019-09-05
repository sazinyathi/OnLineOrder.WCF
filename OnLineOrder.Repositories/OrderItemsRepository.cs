using OnLineOrder.Models;
using OnLinerOrder.Interfaces.Repositories;
using System.Threading.Tasks;

namespace OnLineOrder.Repositories
{
    public class OrderItemsRepository : IOrderItemsRepository
    {
        private readonly OnLineOrderDbContext dbContext;
        public OrderItemsRepository()
        {
            this.dbContext = new OnLineOrderDbContext();
        }
        public async Task CreateOrderItemsAsync(int orderId, OrderItems orderItems)
        {
            try
            {
                orderItems.OrderId = orderId;
                dbContext.OrderItems.Add(orderItems);
                await dbContext.SaveChangesAsync();
            }
            catch (System.Exception exc)
            {
                throw;
            }
        }
    }
}
