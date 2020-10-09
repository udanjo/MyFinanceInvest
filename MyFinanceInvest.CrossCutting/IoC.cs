using Microsoft.Extensions.DependencyInjection;
using MyFinanceInvest.Repository;
using MyFinanceInvest.Repository.Interfaces;
using MyFinanceInvest.Service;
using MyFinanceInvest.Service.Interfaces;

namespace MyFinanceInvest.CrossCutting
{
    public static class IoC
    {
        public static IServiceCollection RegisterServices(IServiceCollection services)
        {
            #region Service

            services.AddScoped<IBankService, BankService>();

            #endregion

            #region Repository

            services.AddScoped<IBankRepository, BankRepository>();


            #endregion

            return services;
        }
    }
}
