using PaymentSystem.Business.Abstract;
using PaymentSystem.Core.Dtos.Transaction.Request;
using PaymentSystem.Core.Dtos.Transaction.Response;
using PaymentSystem.Core.ResponseModel;
using DataAccess.Abstract;
using PaymentSystem.Core.Mapping.Transaction;
using System.Collections.Generic;

namespace PaymentSystem.Business.Concrete
{
    public class TransactionManager : ITransactionService
    {
        private readonly ITransactionDal _transactionDal;
        public TransactionManager(ITransactionDal transactionDal)
        {
            _transactionDal = transactionDal;
        }

        public Response<TransactionResponse> Create(TransactionAddOrUpdateRequest request)
        {

            var data = _transactionDal.Create(request.AsEntity());

            return new Response<TransactionResponse>().Success();
        }

        public Response<TransactionResponse> Delete(int id)
        {
            var data = _transactionDal.GetById(id);
            data.IsDeleted = true;
            data.IsActive = false;

            _transactionDal.Update(data);
            return new Response<TransactionResponse>().Success();

        }

        public Response<List<TransactionResponse>> GetAll()
        {
            return new Response<List<TransactionResponse>>().Success(_transactionDal.GetAll(x => x.IsActive == true && x.IsDeleted).AsResponse());
        }

        public Response<TransactionResponse> GetById(int id)
        {
            var data = _transactionDal.GetById(id);
            return new Response<TransactionResponse>().Success(data.AsResponse());
        }

        public Response<TransactionResponse> Update(TransactionAddOrUpdateRequest request)
        {
            var data = _transactionDal.GetById(request.Id);

            data = request.AsEntity();
    
            _transactionDal.Update(data);
            return new Response<TransactionResponse>().Success();
        }
    }
}
