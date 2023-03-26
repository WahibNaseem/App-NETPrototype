using Core;
using Core.Reoositories;
using Infrastructure.Persistance;
using Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Services.Interfaces;

namespace Services.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(IUnitOfWork), (typeof(UnitOfWork) ));
            services.AddScoped<IMessageRepository, MessageRepository>();
          ;

            services.AddScoped<IMessageService, MessageService>();
            return services;
        }
    }
}
