using OnLineOrder.Models;
using OnLinerOrder.Interfaces.Repositories;
using System.Threading.Tasks;

namespace OnLineOrder.Repositories
{
    public class ProductRepository : IProduct
    {
        private readonly OnLineOrderDbContext dbContext;
        public ProductRepository()
        {
            this.dbContext = new OnLineOrderDbContext();
        }
        public async Task CreateProductAsync(Product product)
        {
            try
            {
                dbContext.Product.Add(product);
                await dbContext.SaveChangesAsync();
            }
            catch (System.Exception exc)
            {
                throw;
            }
        }
    }
}
