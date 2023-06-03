using AutoMapper;
using PaymentSystem.Core.Dtos.Customer.Request;
using PaymentSystem.Core.Dtos.Customer.Response;

namespace PaymentSystem.Core.Mapping.Customer
{
    public  class CustomerProfile: Profile
    {
        public CustomerProfile()
        {
            CreateMap<PaymentSystem.Entity.Domains.Customer, CustomerAddOrUpdateRequest>();
            CreateMap<PaymentSystem.Entity.Domains.Customer, CustomerResponse>();

        }
        
    }
}
