using PaymentSystem.Core.Dtos.Transaction.Request;
using PaymentSystem.Core.Dtos.Transaction.Response;
using PaymentSystem.Core.ResponseModel;
using System.Collections.Generic;

namespace PaymentSystem.Business.Abstract
{
    public interface ITransactionService
    {
        Response<TransactionResponse> Create(TransactionAddOrUpdateRequest request);
        Response<List<TransactionResponse>> GetAll();
        Response<TransactionResponse> Update(TransactionAddOrUpdateRequest request);
        Response<TransactionResponse> Delete(int id);
        Response<TransactionResponse> GetById(int id);
    }
}
