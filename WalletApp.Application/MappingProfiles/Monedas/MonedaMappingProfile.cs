using AutoMapper;
using Contracts.Response.Monedas;
using WalletApp.Domain.Entities;

namespace WalletApp.Application.MappingProfiles.Monedas
{
    public class MonedaMappingProfile : Profile
    {
        public MonedaMappingProfile()
        {
            CreateMap<Moneda, MonedaDto>();
        }
    }
}
