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
                listofProducts.Add(MapProductResponsesToProduct(item));
            }
            return listofProducts;

        }

        public static Product MapOnLineOrderRequestProduct(ProductsResponses productsResponses)
        {
           return MapProductResponsesToProduct(productsResponses);
        }

        public static Product MapOnLineOrderRequestProductErrors(ProductsResponses productsResponses)
        {
            return MapProductResponsesToProduct(productsResponses);
        }

        private static Product MapProductResponsesToProduct(ProductsResponses productsResponses)
        {
            return new Product
            {
                Price = productsResponses.Price,
                ProductDescription = productsResponses.ProductDescription,
                ProductName = productsResponses.ProductName,
                ProductId = productsResponses.ProductId
            };
        }
    }
}