using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OnLineOrder.Models;
using OnLineOrder.Repositories;
using OnLinerOrder.Interfaces.Repositories;
using OnLinerOrder.Interfaces.Services;

namespace OnLineOrder.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;
        public ProductService()
        {
            productRepository = new ProductRepository();
        }
        public async Task CreateProductAsync(Product product)
        {
            await productRepository.CreateProductAsync(product);
        }

        public async Task DeleteProductAsync(int id)
        {
            await productRepository.DeleteProductAsync(id);
        }

        public async Task<IEnumerable<Product>> GetAllProductAsync()
        {
            return await productRepository.GetAllProductAsync();
        }

        public async Task<Product> GetProductIDAsync(int id)
        {
            return await productRepository.GetProductIDAsync(id);
        }

        public async Task UpdateProductAsync(Product updatedProduct)
        {
            await productRepository.UpdateProductAsync(updatedProduct);
        }


    }
}
