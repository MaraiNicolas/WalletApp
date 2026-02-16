using Microsoft.EntityFrameworkCore;
using System.Reflection;
using WalletApp.Domain.Entities.NewFolder;

namespace WalletApp.Infrastructure.Contexto
{
    public class WalletDbContext : DbContext
    {
        public WalletDbContext(DbContextOptions<WalletDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var entityTypes = Assembly.GetAssembly(typeof(Entidad<>))!
            .GetTypes()
            .Where(t => t.IsClass && !t.IsAbstract &&
                        t.BaseType != null && t.BaseType.IsGenericType &&
                        t.BaseType.GetGenericTypeDefinition() == typeof(Entidad<>));
            foreach (var type in entityTypes)
            {
                modelBuilder.Entity(type);
            }

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(WalletDbContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}
