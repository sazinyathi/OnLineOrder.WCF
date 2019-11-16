using OnLineOrder.Models;
using OnLinerOrder.Interfaces.Repositories;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace OnLineOrder.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly OnLineOrderDbContext dbContext;
        public ProductRepository()
        {
            this.dbContext = new OnLineOrderDbContext();

        }
        public async Task CreateProductAsync(Product product)
        {
         
                dbContext.Product.Add(product);
                await dbContext.SaveChangesAsync();
          
        }

        public async Task DeleteProductAsync(int id)
        {
            var productEntity = await dbContext.Product.FirstOrDefaultAsync(x => x.ProductId == id);
            if(productEntity == null || productEntity == default)
            {
                throw new KeyNotFoundException($"Id of '{id}' was not found!");
            }
            dbContext.Product.Remove(productEntity);
            await dbContext.SaveChangesAsync();
        }

        public async  Task<IEnumerable<Product>> GetAllProductAsync()
        {
            return await dbContext.Product.ToListAsync();
        }

        public async Task<Product> GetProductIDAsync(int id)
        {
            return await dbContext.Product.Where(x =>x.ProductId == id).FirstOrDefaultAsync() ;
        }

        public async Task UpdateProductAsync(Product updatedProduct)
        {
            var productEntity = await dbContext.Product.FirstOrDefaultAsync(x => x.ProductId == updatedProduct.ProductId);
            if (productEntity == null || productEntity == default)
            {
                throw new KeyNotFoundException($"Id of '{productEntity.ProductId}' was not found!");
            }
            productEntity.Price = updatedProduct.Price;
            productEntity.ProductDescription = updatedProduct.ProductDescription;
            productEntity.ProductName = updatedProduct.ProductName;
            dbContext.Product.Add(productEntity);

            await dbContext.SaveChangesAsync();
        }
    }
}
