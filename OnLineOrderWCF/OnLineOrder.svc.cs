﻿using System;
using OnLineOrder.Models;
using OnLineOrder.Services;
using OnLineOrderWCF.Models;

namespace OnLineOrderWCF
{
    public class OnLineOrder : IOnLineOrder
    {
        private readonly LoginService loginService;
        private readonly LoginSessionService loginSessionService;
        public OnLineOrder()
        {
            loginService = new LoginService();
            loginSessionService = new LoginSessionService();
        }
        public OnLineOrderLoginSesssionResponse CreateLoginSession(string username, string passsword)
        {
            var response = new OnLineOrderLoginSesssionResponse();
            try
            {
                if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(passsword))
                {
                    var login = loginService.GetLoginDetailsByUsernameAndPasswordAsync(username, passsword);
                    if (login.Result == null)
                        response.Errors.Add(CreateError(004, "No username and Password Found"));
                    else
                    {
                       var sessionID = loginSessionService.CreateLoginSessionAsync(login.Result.LoginId, new LoginSession
                        {
                          RowCreateDate = DateTime.Now,
                          RowLastUpdateDate =DateTime.Now,
                          SessionId = Guid.NewGuid().ToString(),
                          SessionKey = Guid.NewGuid().ToString(),
                          SessionLastAction = DateTime.Now,
                          SessionStart = DateTime.Now
                        });
                        response.OnLineOrderLoginSesssionKey = sessionID.Result;
                    }

                    
                }
                else
                {
                    response.Errors.Add(CreateError(003, "Username And Password - not supplied"));
                    //LogMessage("Uploading FingerprintsAndSupportingDocuments: ", "Session Key not supplied");
                }
            }
            catch (Exception ex)
            {
                response.Errors.Add(CreateError(000, "Integrator - Error : " + ex.Message));
               // LogMessage("Uploading FingerprintsAndSupportingDocuments: ", ex.Message);
               
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

    }
}
