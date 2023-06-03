using PaymentSystem.Core.Dtos.Payzee.Request;
using PaymentSystem.Core.ResponseModel.PayzeeResponses;

namespace PaymentSystem.Business.Abstract
{
    public interface IPayzeeService
    {
        LoginResponse Login(LoginRequest request);
        PaymentResponse Payment(PaymentRequest request,string accessToken);
    }
}
