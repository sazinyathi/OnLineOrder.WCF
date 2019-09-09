using OnLineOrder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnLinerOrder.Interfaces.Services
{
   public interface IProductService
    {
        Task CreateProductAsync(Product product);
        Task<IEnumerable<Product>> GetAllProductAsync();
        Task<Product> GetProductIDAsync(int id);
        Task UpdateProductAsync(Product updatedEvent);
        Task DeleteProductAsync(int id);
    }
}
