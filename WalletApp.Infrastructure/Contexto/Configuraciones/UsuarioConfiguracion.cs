using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WalletApp.Domain.Entities;

namespace WalletApp.Infrastructure.Contexto.Configuraciones
{
    public class UsuarioConfiguracion : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
                builder.ToTable("USUARIO");
            builder.Property(e=>e.Id).HasColumnName("USER_ID").ValueGeneratedOnAdd();
            builder.Property(e => e.Guid).HasColumnName("USER_GUID");
            builder.Property(e => e.Nombre).HasColumnName("USER_NOMBRE").HasMaxLength(100);
            builder.Property(e => e.Apellido).HasColumnName("USER_APELLIDO").HasMaxLength(100);
            builder.Property(e => e.NumeroDoc).HasColumnName("USER_NUMERO_DOC").HasMaxLength(50);
            builder.Property(e => e.Email).HasColumnName("USER_EMAIL").HasMaxLength(100);
            builder.Property(e => e.Password).HasColumnName("USER_PASSWORD").HasMaxLength(255);
            builder.Property(e=>e.FechaAlta).HasColumnName("USER_FALTA").HasDefaultValueSql("GETDATE()");
            builder.Property(e => e.FechaModificacion).HasColumnName("USER_LUPDATE").HasDefaultValueSql("GETDATE()");
        }
    }
}
