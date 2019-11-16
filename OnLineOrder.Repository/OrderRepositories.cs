using OnLineOrder.Models;
using OnLinerOrder.Interfaces.Repositories;
using System;
using System.Threading.Tasks;

namespace OnLineOrder.Repository
{
    public class OrderRepositories : IOrderRepositories
    {
        private readonly OnLineOrderDbContext dbContext;
        public OrderRepositories()
        {
            this.dbContext = new OnLineOrderDbContext();
        }

        public async Task<int> CreateOrderAsync(Orders orders)
        {

                dbContext.Orders.Add(orders);
                dbContext.SaveChanges();
                return orders.OrderId;
        }
    }
}
