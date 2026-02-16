using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WalletApp.Domain.Abstracciones.SqlConnection;
using WalletApp.Domain.Abstracciones.UnitOfWork;
using WalletApp.Infrastructure.Contexto;
using WalletApp.Infrastructure.Contexto.Repositorios;
using WalletApp.Infrastructure.Contexto.SqlConecction;
using WalletApp.Infrastructure.Contexto.UnitOfWork;

namespace WalletApp.Infrastructure.Dependencies
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            // Configuración de la base de datos
            var connectionString = configuration.GetConnectionString("DefaultConnection")
                        ?? throw new ArgumentNullException(nameof(configuration));
            services.AddDbContext<WalletDbContext>(options =>
            options.UseSqlServer(connectionString));
            // Registro del UnitOfWork
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddSingleton<ISqlConnectionFactory>(_ =>
            new SqlConnectionFactory(connectionString));
            return services;
        }
    }
}
