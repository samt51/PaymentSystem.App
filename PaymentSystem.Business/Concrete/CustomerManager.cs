using DataAccess.Abstract;
using PaymentSystem.Business.Abstract;
using PaymentSystem.Core.Dtos.Customer.Request;
using PaymentSystem.Core.Dtos.Customer.Response;
using PaymentSystem.Core.Enum;
using PaymentSystem.Core.ExternalServices.IdentityControllService;
using PaymentSystem.Core.Mapping.Customer;
using PaymentSystem.Core.ResponseModel;
using System.Collections.Generic;

namespace PaymentSystem.Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        public Response<CustomerResponse> Create(CustomerAddOrUpdateRequest request)
        {
            var value = IdentityService.MernisControll(request.IdentityNo, request.Name, request.Surname, request.BirthDate.Year);
            var data = _customerDal.Create(request.AsEntity());
            if (value.Result == false)
            {
                request.Status = 3;
                return new Response<CustomerResponse>().Fail("Bu T.C No Mernis Kayıtlarında Bulunamamıştır Üyeliğiniz Pasif Durumdadır.Lütfen Kontrol Ediniz");
            }
            return new Response<CustomerResponse>().Success();
        }

        public Response<CustomerResponse> Delete(int id)
        {
            var data = _customerDal.GetById(id);
            data.IsDeleted = true;
            data.IsActive = false;
            var d = _customerDal.Update(data);
            return new Response<CustomerResponse>().Success();
        }

        public Response<List<CustomerResponse>> GetAll()
        {
            return new Response<List<CustomerResponse>>().Success(_customerDal.GetAll(x => x.IsActive == true && x.IsDeleted == false).AsResponse());
        }

        public Response<CustomerResponse> GetById(int id)
        {
            return new Response<CustomerResponse>().Success(_customerDal.GetById(id).AsResponse());
        }

        public Response<CustomerResponse> Update(CustomerAddOrUpdateRequest request)
        {
            var data = _customerDal.GetById(request.Id);
            data = request.AsEntity();
            _customerDal.Update(data);
            return new Response<CustomerResponse>().Success();
        }
    }
}
