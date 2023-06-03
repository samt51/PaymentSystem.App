using AutoMapper;
using PaymentSystem.Core.Dtos.Transaction.Request;
using PaymentSystem.Core.Dtos.Transaction.Response;

namespace PaymentSystem.Core.Mapping.Transaction
{
    public class TransactionProfile:Profile
    {
        public TransactionProfile()
        {
            CreateMap<PaymentSystem.Entity.Domains.Transaction, TransactionAddOrUpdateRequest>();
            CreateMap<PaymentSystem.Entity.Domains.Transaction, TransactionResponse>();
           
        }
    }
}
