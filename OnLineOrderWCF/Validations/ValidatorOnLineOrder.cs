using OnLineOrderWCF.Models;
using OnLineOrderWCF.Requests;
using System.Collections.Generic;

namespace OnLineOrderWCF.Validations
{
    public class ValidatorOnLineOrder : IValidatorOnLineOrder
    {
        public OnLineOrderProductRequest OnLineOrderProductRequest { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string SessionId { get; set; }
        public List<OnLineOrderError> Errors { get; set; }
        public ValidatorOnLineOrder(OnLineOrderProductRequest onLineOrderProductRequest)
        {
            Errors = new List<OnLineOrderError>();
            OnLineOrderProductRequest = onLineOrderProductRequest;
        }
        public ValidatorOnLineOrder(string sessionId)
        {
            Errors = new List<OnLineOrderError>();
            SessionId = sessionId;
        }
        public ValidatorOnLineOrder(string username, string password)
        {
            Errors = new List<OnLineOrderError>();
            Username = username;
            Password = password;
        }
        public bool IsUsernameAndPasswordIsNotNull()
        {
            CheckIfUsernameAndPassword(Username, Password);
            return LogErrors();
        }

        public bool LogErrors()
        {
            if (Errors.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool IsProductValid()
        {
            ValidateProduct(OnLineOrderProductRequest);
            return LogErrors();
        }

        public void ValidateProduct(OnLineOrderProductRequest onLineOrderProductRequest)
        {
            if (string.IsNullOrEmpty(onLineOrderProductRequest.ProductDescription))
            {
                Errors.Add(CreateError(1001, "Product Description is not provided"));
            }
            else
            {
                if (onLineOrderProductRequest.ProductDescription.Length > 50)
                {
                    Errors.Add(CreateError(1002, "Product Description should not be more than 50 charactors"));
                }
            }
            if (string.IsNullOrEmpty(onLineOrderProductRequest.ProductName))
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

        public void CheckIfUsernameAndPassword(string username, string password)
        {
            if (string.IsNullOrEmpty(username))
            {
                Errors.Add(CreateError(402, "Please provide the correct username"));
            }
            if (string.IsNullOrEmpty(password))
            {
                Errors.Add(CreateError(403, "Please provide the correct Password"));
            }
        }

        public bool IsSessionId()
        {
            ValidateSessionId(SessionId);
            return LogErrors();
        }

       

        public void ValidateSessionId(string sessionId)
        {
            if (string.IsNullOrEmpty(sessionId))
            {
                Errors.Add(CreateError(406, "Error -SessionId is null"));
            }
        }

        
    }
}