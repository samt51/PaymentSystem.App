using AutoMapper;
using PaymentSystem.Core.Dtos.Transaction.Request;
using PaymentSystem.Core.Dtos.Transaction.Response;

namespace PaymentSystem.Core.Mapping.Transaction
{
    public static class TransactionExtension
    {
        internal static IMapper Mapper;
        static TransactionExtension()
        {
            Mapper = new MapperConfiguration(cfg => cfg.AddProfile<TransactionProfile>()).CreateMapper();
        }
        public static PaymentSystem.Entity.Domains.Transaction AsEntity(this TransactionAddOrUpdateRequest request)
        {
            return Mapper.Map<PaymentSystem.Entity.Domains.Transaction>(request);
        }
        public static List<TransactionResponse> AsResponse(this List<PaymentSystem.Entity.Domains.Transaction> entities)
        {
            return Mapper.Map<List<TransactionResponse>>(entities);
        }
        public static TransactionResponse AsResponse(this PaymentSystem.Entity.Domains.Transaction entities)
        {
            return Mapper.Map<TransactionResponse>(entities);
        }

    }
}
