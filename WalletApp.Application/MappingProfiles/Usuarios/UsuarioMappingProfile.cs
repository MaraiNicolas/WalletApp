using AutoMapper;
using Contracts.Response.Usuarios;
using WalletApp.Domain.Entities;

namespace WalletApp.Application.MappingProfiles.Usuarios
{
    public class UsuarioMappingProfile : Profile
    {
        public UsuarioMappingProfile()
        {
            CreateMap<Usuario, UsuarioDto>();
        }
    }
}
