using AutoMapper;
using Contracts.Response.Transacciones;
using System;
using System.Collections.Generic;
using System.Text;
using WalletApp.Domain.Entities;

namespace WalletApp.Application.MappingProfiles.Transacciones
{
    public class TransaccionMappingProfile : Profile
    {
        public TransaccionMappingProfile()
        {
            CreateMap<Transaccion, TransaccionDto>();
        }
    }
}
