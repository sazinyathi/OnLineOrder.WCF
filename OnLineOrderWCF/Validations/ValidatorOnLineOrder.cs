using OnLineOrderWCF.Models;
using OnLineOrderWCF.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnLineOrderWCF.Validations
{
    public class ValidatorOnLineOrder : IValidatorOnLineOrder
    {
        public Product OnLineOrderProductRequest { get; set; }
        public List<OnLineOrderError> Errors { get; set; }
        public ValidatorOnLineOrder(Product onLineOrderProductRequest)
        {
            Errors = new List<OnLineOrderError>();
            OnLineOrderProductRequest = onLineOrderProductRequest;
        }
        public bool IsProductValid()
        {
            ValidateProduct(OnLineOrderProductRequest);
            if (Errors.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void ValidateProduct(Product onLineOrderProductRequest)
        {
            if(string.IsNullOrEmpty(onLineOrderProductRequest.ProductDescription))
            {
                Errors.Add(CreateError(1001, "Product Description is not provided"));
            }
            else
            {
                if(onLineOrderProductRequest.ProductDescription.Length > 50)
                {
                    Errors.Add(CreateError(1002, "Product Description should not be more than 50 charactors"));
                }
            }
            if(string.IsNullOrEmpty(onLineOrderProductRequest.ProductName))
            {
                Errors.Add(CreateError(1003, "Product Name is not provided"));
            }
            else
            {
                if (onLineOrderProductRequest.ProductDescription.Length > 50)
                {
                    Errors.Add(CreateError(1004, "Product Name should not be more than 50 charactors"));
                }
            }
            if (string.IsNullOrEmpty(onLineOrderProductRequest.Price.ToString()))
            {
                Errors.Add(CreateError(1005, "Product Price is not provided"));
            }
            

        }

        private static OnLineOrderError CreateError(int code, string desc)
        {
            OnLineOrderError error = new OnLineOrderError();
            error.ErrorCode = code.ToString();
            error.ErrorDescription = desc;
            return error;
        }
    }
}