using OnLineOrder.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnLinerOrder.Interfaces.Services
{
    public interface IProductService
    {
        Task CreateProductAsync(Product product);
        Task<IEnumerable<Product>> GetAllProductAsync();
        Task<Product> GetProductIDAsync(int id);
        Task UpdateProductAsync(Product updatedProduct);
        Task DeleteProductAsync(int id);
    }
}
