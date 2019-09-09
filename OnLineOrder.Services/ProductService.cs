using System.Collections.Generic;
using System.Threading.Tasks;
using OnLineOrder.Models;
using OnLinerOrder.Interfaces.Services;

namespace OnLineOrder.Services
{
    public class ProductService : IProductService
    {
        public Task CreateProductAsync(Product product)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteProductAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetAllProductAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<Product> GetProductIDAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateProductAsync(Product updatedEvent)
        {
            throw new System.NotImplementedException();
        }
    }
}
