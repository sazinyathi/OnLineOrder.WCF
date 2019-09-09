using OnLineOrder.Models;
using OnLineOrderWCF.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnLineOrderWCF.Dto
{
    public static class ProductDto
    {
        public static Product MapOnLineOrderRequest(OnLineOrderProductRequest onLineOrderProductRequest)
        {
            return new Product
            {
              Price = onLineOrderProductRequest.Price,
              ProductDescription = onLineOrderProductRequest.ProductDescription,
              ProductName = onLineOrderProductRequest.ProductName
            };

        }
    }
}