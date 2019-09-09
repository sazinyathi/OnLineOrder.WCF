using OnLineOrderWCF.Requests;

namespace OnLineOrderWCF.Validations
{
    public interface IValidatorOnLineOrder
    {
        void ValidateProduct(Product onLineOrderProductRequest);
    }
}
