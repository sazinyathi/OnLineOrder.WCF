using OnLineOrder.Models;
using System.Threading.Tasks;

namespace OnLinerOrder.Interfaces.Repositories
{
    public interface IProduct
    {
        Task CreateProductAsync(Product product);
    }
}
