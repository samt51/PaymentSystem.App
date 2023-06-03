using DataAccess.Abstract;
using DataAccess.Concrete;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PaymentSystem.Business.Abstract;
using PaymentSystem.Business.Concrete;
using PaymentSystem.Core.Middlewares;

namespace PaymentSystem.Business
{
    public static class ServiceRegistration
    {
        public static void UseBusinessService(this IServiceCollection Services, IConfiguration configuration, IApplicationBuilder app)
        {
            Services.AddScoped<ICustomerDal, EfCustomerDal>();
            Services.AddScoped<ICustomerService, CustomerManager>();
            Services.AddScoped<ITransactionDal, EfTransactionDal>();
            Services.AddScoped<ITransactionService, TransactionManager>();
            app.UseMiddleware<UseCustomExceptionHandler>();


        }
    }
}
