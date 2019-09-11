using OnLineOrder.Models;
using OnLineOrder.MVC.OnLineOrderService;
using System.Collections.Generic;

namespace OnLineOrder.MVC.Dtos
{
    public static class MapServiceMVC
    {
        public static List<Product> MapOnLineOrderRequest(ProductsResponses [] onLineOrderGetAvailableProductsResponses)
        {
            var listofProducts = new List<Product>();
           
            foreach (var item in onLineOrderGetAvailableProductsResponses)
            {
                var product = new Product
                {
                    Price = item.Price,
                    ProductDescription = item.ProductDescription,
                    ProductName = item.ProductName,
                    ProductId = item.ProductId
                };
                listofProducts.Add(product);
            }
            return listofProducts;

        }

        public static Product MapOnLineOrderRequestProduct(ProductsResponses task)
        {
            var listofProducts = new List<Product>();
            return new Product
            {
                Price = task.Price,
                ProductDescription = task.ProductDescription,
                ProductName = task.ProductName,
                ProductId = task.ProductId
            };
        }

        public static Product MapOnLineOrderRequestProductErrors(ProductsResponses task)
        {
            return new Product
            {
                Price = task.Price,
                ProductDescription = task.ProductDescription,
                ProductName = task.ProductName,
                ProductId = task.ProductId
            };
        }
    }
}