using DataAccess.Abstract;
using DataAccess.Context;
using PaymentSystem.Entity.Domains;

namespace DataAccess.Concrete
{
    public class EfCustomerDal : EfRepositoryDal<Customer, DataContext>, ICustomerDal
    {
    }
}
