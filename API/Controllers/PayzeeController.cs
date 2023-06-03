using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PaymentSystem.Business.Abstract;
using PaymentSystem.Core.Dtos.Payzee.Request;
using PaymentSystem.Core.ResponseModel.PayzeeResponses;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PayzeeController : ControllerBase
    {
        private readonly IPayzeeService _payzeeService;
        public PayzeeController(IPayzeeService payzeeService)
        {
            _payzeeService = payzeeService;
        }
        [HttpPost("Login")]
        public LoginResponse Login(LoginRequest request)
        {

            return _payzeeService.Login(request);
        }
        [HttpPost("Payment")]
        public PaymentResponse Payment(PaymentRequest request)
        {
            var tokn = HttpContext.Request.Headers["Authorization"];
            return _payzeeService.Payment(request,tokn);
        }
    }
}
