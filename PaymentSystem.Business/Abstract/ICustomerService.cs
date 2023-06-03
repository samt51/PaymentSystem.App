using PaymentSystem.Core.Dtos.Customer.Request;
using PaymentSystem.Core.Dtos.Customer.Response;
using PaymentSystem.Core.ResponseModel;
using System.Collections.Generic;

namespace PaymentSystem.Business.Abstract
{
    public interface ICustomerService
    {
        Response<CustomerResponse> Create(CustomerAddOrUpdateRequest request);
        Response<List<CustomerResponse>> GetAll();
        Response<CustomerResponse> GetById(int id);
        Response<CustomerResponse> Update(CustomerAddOrUpdateRequest request);
        Response<CustomerResponse> Delete(int id);
    }
}
