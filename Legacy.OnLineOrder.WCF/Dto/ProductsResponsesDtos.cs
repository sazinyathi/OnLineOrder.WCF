using OnLineOrder.Models;
using OnLineOrderWCF.Responses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnLineOrderWCF.Dto
{
    public static class ProductsResponsesDtos
    {
        public static List<ProductsResponses> MapOnLineOrderRequest(Task<IEnumerable<Product>> product)
        {
            var productsResponses = new List<ProductsResponses>();
            foreach (var item in product.Result)
            {
                productsResponses.Add(GetSingleProductsResponses(item));
            } 
            return productsResponses;
        }


        public static ProductsResponses MapOnLineOrderRequestProduct(Task<Product> product)
        {
            return GetSingleProductsResponses(product.Result);
        }

        private static ProductsResponses GetSingleProductsResponses(Product product)
        {
            return new ProductsResponses
            {
                Price = product.Price,
                ProductDescription = product.ProductDescription,
                ProductName = product.ProductName,
                ProductId = product.ProductId
            };
        }
    }
}