using OnLineOrderWCF.Models;
using OnLineOrderWCF.Requests;

namespace OnLineOrderWCF.Validations
{
    public interface IValidatorOnLineOrder
    {
        void CheckIfUsernameAndPassword(string username, string password);
        void ValidateProduct(OnLineOrderProductRequest onLineOrderProductRequest);
        void ValidateSessionId(string sessionId);
        bool LogErrors();
    }
}
