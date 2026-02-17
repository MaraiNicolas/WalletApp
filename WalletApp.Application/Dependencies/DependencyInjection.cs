using Microsoft.Extensions.DependencyInjection;
using WalletApp.Application.Configuraciones.Assemblies;

namespace WalletApp.Application.Dependencies
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(configuration =>
            {
                configuration.RegisterServicesFromAssembly(typeof(DependencyInjection).Assembly);
                configuration.RegisterServicesFromAssembly(AplicationAssembly.GetAssembly());
            });

            services.AddAutoMapper(config => { }, AplicationAssembly.GetAssembly());

            return services;
        }
    }
}
