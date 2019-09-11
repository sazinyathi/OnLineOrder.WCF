using OnLineOrder.Models;
using OnLineOrderWCF.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace OnLineOrderWCF.Dto
{
    public static class AvailableProductsResponsesDtos
    {
        public static List<ProductsResponses> MapOnLineOrderRequest(Task<IEnumerable<Product>> task)
        {
            List<ProductsResponses> productsResponses = new List<ProductsResponses>();
            foreach (var item in task.Result)
            {
                ProductsResponses products = new ProductsResponses
                {
                    Price = item.Price,
                    ProductDescription = item.ProductDescription,
                    ProductName = item.ProductName,
                    ProductId = item.ProductId
                    
                };
                productsResponses.Add(products);
            }

            return productsResponses;
        }


        public static ProductsResponses MapOnLineOrderRequestProduct(Task<Product> task)
        {
            return new ProductsResponses
            {
                Price = task.Result.Price,
                ProductDescription = task.Result.ProductDescription,
                ProductName = task.Result.ProductName,
                ProductId = task.Result.ProductId
            };
        }
    }
}