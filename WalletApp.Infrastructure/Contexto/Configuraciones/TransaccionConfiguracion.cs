using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WalletApp.Domain.Entities;

namespace WalletApp.Infrastructure.Contexto.Configuraciones
{
    public class TransaccionConfiguracion : IEntityTypeConfiguration<Transaccion>
    {
        public void Configure(EntityTypeBuilder<Transaccion> builder)
        {
            builder.ToTable("TRANSACCION");
            builder.Property(e => e.Id).HasColumnName("TRANS_ID");
            builder.Property(e => e.Guid).HasColumnName("TRANS_GUID");
            builder.Property(e => e.TransaccionTipoId).HasColumnName("TRANST_ID");
            builder.Property(e => e.MonedaId).HasColumnName("MON_ID");
            builder.Property(e => e.Importe).HasColumnName("TRANS_IMPORTE");
            builder.Property(e => e.Descripcion).HasColumnName("TRANS_DESCRIPCION").HasMaxLength(500);
            builder.Property(e => e.FechaAlta).HasColumnName("TRANS_FALTA").HasDefaultValueSql("GETDATE()");
            builder.Property(e => e.FechaModificacion).HasColumnName("TRANS_LUPDATE").HasDefaultValueSql("GETDATE()");
        }
    }
}
