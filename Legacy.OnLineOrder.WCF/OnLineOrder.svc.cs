using System;
using OnLineOrder.Models;
using OnLineOrder.Services;
using OnLineOrderWCF.Dto;
using OnLineOrderWCF.Models;
using OnLineOrderWCF.Requests;
using OnLineOrderWCF.Responses;
using OnLineOrderWCF.Validations;

namespace OnLineOrderWCF
{
    public class OnLineOrder : IOnLineOrder
    {
        private readonly LoginService loginService;
        private readonly LoginSessionService loginSessionService;
        private readonly ProductService productService;

        public OnLineOrder()
        {
            loginService = new LoginService();
            loginSessionService = new LoginSessionService();
            productService = new ProductService();
        }
        public OnLineOrderLoginSesssionResponse CreateLoginSession(string username, string password)
        {
            var response = new OnLineOrderLoginSesssionResponse();
            var validate = new ValidatorOnLineOrder(username, password);
            try
            {
                if (!validate.IsUsernameAndPasswordValid())
                { response.Errors = validate.Errors; }
                else
                {
                    if (loginService.GetLoginDetailsByUsernameAndPasswordAsync(username, password).Result == null)
                    { response.Errors.Add(CreateError(401, "No username and Password Found")); }
                    else
                    {
                        var sessionID = loginSessionService.CreateLoginSessionAsync(
                            loginService.GetLoginDetailsByUsernameAndPasswordAsync(username, password).Result.LoginId,
                            new LoginSession
                            {
                                RowCreateDate = DateTime.Now,
                                RowLastUpdateDate = DateTime.Now,
                                SessionId = Guid.NewGuid().ToString(),
                                SessionKey = Guid.NewGuid().ToString(),
                                SessionLastAction = DateTime.Now,
                                SessionStart = DateTime.Now
                            });
                        response.OnLineOrderLoginSesssionKey = sessionID.Result;
                    }
                }
            }
            catch (Exception ex)
            {
                response.Errors.Add(CreateError(000, "OnLineOrder - Error : " + ex.Message));
            }
            return response;
        }

        private static OnLineOrderError CreateError(int code, string desc)
        {
            OnLineOrderError error = new OnLineOrderError();
            error.ErrorCode = code.ToString();
            error.ErrorDescription = desc;
            return error;
        }


        public OnLineOrderCreateProductResponse CreateProduct(OnLineOrderProductRequest onLineOrderRequest)
        {
            var response = new OnLineOrderCreateProductResponse();
            var validate = new ValidatorOnLineOrder(onLineOrderRequest.SessionId);
            try
            {
                if (!validate.IsSessionIdValidate())
                { response.Errors = validate.Errors; }
                else
                {
                    if (loginSessionService.GetLoginSesionBySenssionIdAsync(onLineOrderRequest.SessionId).Result == null)
                    { response.Errors.Add(CreateError(005, "No username and Password Found")); }
                    else
                    {
                        var validator = new ValidatorOnLineOrder(onLineOrderRequest);
                        if (validator.IsProductValid())
                        {
                            productService.CreateProductAsync(ProductDto.MapOnLineOrderRequest(onLineOrderRequest));
                        }
                        else
                        {
                            response.Errors = validator.Errors;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                response.Errors.Add(CreateError(1000, "OnLineOrder - Error : " + ex.Message));
            }
            return response;
        }

        public OnLineOrderGetAvailableProductsResponse GetAllAvailableProducts(string sessionId)
        {
            var validate = new ValidatorOnLineOrder(sessionId);
            var response = new OnLineOrderGetAvailableProductsResponse();
            try
            {
                if (!validate.IsSessionIdValidate())
                { response.Errors = validate.Errors; }
                else
                {
                    response.GetAllProducts = AvailableProductsResponsesDtos.MapOnLineOrderRequest(productService.GetAllProductAsync());
                }
            }
            catch (Exception ex)
            {
                response.Errors.Add(CreateError(1001, "OnLineOrder - Error : " + ex.Message));
            }
            return response;
        }

        public OnLineOrderGetAvailableProductsByProductIdResponse GetAvailableProductsByProductId(string sessionId, int productId)
        {
            var validate = new ValidatorOnLineOrder(sessionId);
            var response = new OnLineOrderGetAvailableProductsByProductIdResponse();
            try
            {
                if (!validate.IsSessionIdValidate())
                { response.Errors = validate.Errors; }
                else
                {
                    response.GetProduct = AvailableProductsResponsesDtos.MapOnLineOrderRequestProduct(productService.GetProductIDAsync(productId));
                }
            }
            catch (Exception ex)
            {
                response.Errors.Add(CreateError(1001, "OnLineOrder - Error : " + ex.Message));
            }
            return response;
        }
    }
}

