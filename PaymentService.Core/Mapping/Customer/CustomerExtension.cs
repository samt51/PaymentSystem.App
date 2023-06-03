using AutoMapper;
using PaymentSystem.Core.Dtos.Customer.Request;
using PaymentSystem.Core.Dtos.Customer.Response;

namespace PaymentSystem.Core.Mapping.Customer
{
    public static class CustomerExtension
    {
        internal static IMapper Mapper;
        static CustomerExtension()
        {
            Mapper = new MapperConfiguration(cfg => cfg.AddProfile<CustomerProfile>()).CreateMapper();
        }
        public static PaymentSystem.Entity.Domains.Customer AsEntity(this CustomerAddOrUpdateRequest request)
        {
            return Mapper.Map<PaymentSystem.Entity.Domains.Customer>(request);
        }
        public static List<CustomerResponse> AsResponse(this List<PaymentSystem.Entity.Domains.Customer> entities)
        {
            return Mapper.Map<List<CustomerResponse>>(entities);
        }
        public static CustomerResponse AsResponse(this PaymentSystem.Entity.Domains.Customer entities)
        {
            return Mapper.Map<CustomerResponse>(entities);
        }




    }
}
