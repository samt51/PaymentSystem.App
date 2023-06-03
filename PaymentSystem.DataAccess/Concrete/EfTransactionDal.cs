using PaymentSystem.DataAccess.Abstract;
using PaymentSystem.DataAccess.Context;
using PaymentSystem.Entity.Domains;

namespace PaymentSystem.DataAccess.Concrete
{
    public class EfTransactionDal : EfRepositoryDal<Transaction, DataContext>, ITransactionDal
    {
    }
}
