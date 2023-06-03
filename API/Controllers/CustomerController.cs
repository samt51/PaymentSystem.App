using Microsoft.AspNetCore.Mvc;
using PaymentSystem.Business.Abstract;
using PaymentSystem.Core.Dtos.Customer.Request;
using PaymentSystem.Core.Dtos.Customer.Response;
using PaymentSystem.Core.ResponseModel;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        [HttpPost]
        public Response<CustomerResponse> Save(CustomerAddOrUpdateRequest request)
        {
            return _customerService.Create(request);
        }
        [HttpGet]
        public Response<List<CustomerResponse>> GetAll()
        {
            return _customerService.GetAll();
        }
        [HttpGet("{id}")]
        public Response<CustomerResponse> GetById(int id)
        {
            return _customerService.GetById(id);
        }
        [HttpPost("Update")]
        public Response<CustomerResponse> Update(CustomerAddOrUpdateRequest request)
        {
            return _customerService.Update(request);
        }
        [HttpDelete("{id}")]
        public Response<CustomerResponse>Delete(int id)
        {
            return _customerService.Delete(id);
        }

    }
}
