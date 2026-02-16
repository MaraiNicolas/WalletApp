using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WalletApp.Domain.Entities;

namespace WalletApp.Infrastructure.Contexto.Configuraciones
{
    public class MonedaConfiguracion : IEntityTypeConfiguration<Moneda>
    {
        public void Configure(EntityTypeBuilder<Moneda> builder)
        {
            builder.ToTable("MONEDA");
            builder.Property(e => e.Id).HasColumnName("MON_ID");
            builder.Property(e => e.Nombre).HasColumnName("MON_NOMBRE").HasMaxLength(50);
            builder.Property(e => e.Guid).HasColumnName("MON_GUID");
            builder.Property(e => e.NombreCorto).HasColumnName("MON_NOMBRE_CORTO").HasMaxLength(10);
            builder.Property(e => e.FechaAlta).HasColumnName("MON_FALTA").HasDefaultValueSql("GETDATE()");
            builder.Property(e => e.FechaModificacion).HasColumnName("MON_LUPDATE").HasDefaultValueSql("GETDATE()");
        }
    }
}
