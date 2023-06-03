using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PaymentSystem.Business.Abstract;
using PaymentSystem.Core.Dtos.Transaction.Request;
using PaymentSystem.Core.Dtos.Transaction.Response;
using PaymentSystem.Core.ResponseModel;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly ITransactionService _transactionService;
        public TransactionController(ITransactionService transactionService)
        {
            _transactionService = transactionService;
        }
        [HttpPost("save")]
        public Response<TransactionResponse> Save(TransactionAddOrUpdateRequest request)
        {
            return _transactionService.Create(request);
        }
        [HttpGet("{id}")]
        public Response<TransactionResponse> GetById(int id)
        {
            return _transactionService.GetById(id);
        }
        [HttpGet]
        public Response<List<TransactionResponse>> GetAll()
        {
            return _transactionService.GetAll();
        }
        [HttpPost("Update")]
        public Response<TransactionResponse> Update(TransactionAddOrUpdateRequest request)
        {
            return _transactionService.Update(request);
        }
        [HttpDelete("{id}")]
        public Response<TransactionResponse> Delete(int id)
        {
            return _transactionService.Delete(id);
        }
    }
}
