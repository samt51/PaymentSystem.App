using PaymentSystem.Business.Abstract;
using PaymentSystem.Core.Dtos.Payzee.Request;
using PaymentSystem.Core.ExternalServices.PayzeeServices;
using PaymentSystem.Core.Helpers;
using PaymentSystem.Core.ResponseModel.PayzeeResponses;
using static PaymentSystem.Core.Helpers.AuthorizationCont;

namespace PaymentSystem.Business.Concrete
{
    public class PayzeeManager : IPayzeeService
    {
        public LoginResponse Login(LoginRequest request)
        {
            var data = PayzeeLoginService.Auth(request);
            return data;
        }

        public PaymentResponse Payment(PaymentRequest request, string accessToken)
        {
            var token = AuthorizationCont.Authorization(accessToken);
            //burada hash işlemi yapılacak ancak istenilen bazı parametre değerli olmadığından yapılmadı.
            PaymentHashFunc.CreateHash(new Core.Dtos.PaymentHashRequest { HashPassword = request.Password });
            var response = PaymentService.PaymentResponse(request, accessToken);
            return null;
        }
    }
}
