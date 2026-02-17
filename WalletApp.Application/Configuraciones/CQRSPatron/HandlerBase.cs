using AutoMapper;
using WalletApp.Domain.Core.Abstracciones.UnitOfWork;

namespace WalletApp.Application.Configuraciones.CQRSPatron;
public abstract class HandlerBase
{
    protected readonly IUnitOfWork _unitOfWork;
    protected readonly IMapper _mapper;
    public HandlerBase(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }
}