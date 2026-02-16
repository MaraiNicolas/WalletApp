using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WalletApp.Domain.Entities;

namespace WalletApp.Infrastructure.Contexto.Configuraciones
{
    public class TransaccionTipoConfiguracion : IEntityTypeConfiguration<TransaccionTipo>
    {
        public void Configure(EntityTypeBuilder<TransaccionTipo> builder)
        {
            builder.ToTable("TRANSACCION_TIPO");
            builder.Property(e => e.Id).HasColumnName("TRANST_ID");
            builder.Property(e => e.Descripcion).HasColumnName("TRANS_DESCRIPCION").HasMaxLength(60);
        }
    }
}
