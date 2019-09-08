using OnLineOrder.Models;
using System.Threading.Tasks;

namespace OnLinerOrder.Interfaces.Repositories
{
    public interface IProductRepository
    {
        Task CreateProductAsync(Product product);
    }
}
