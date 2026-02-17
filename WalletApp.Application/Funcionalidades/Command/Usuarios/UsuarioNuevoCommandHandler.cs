using WalletApp.Application.Configuraciones.CQRSPatron.Command;
using WalletApp.Application.Configuraciones.CQRSPatron;
using AutoMapper;
using WalletApp.Domain.Core.Abstracciones.UnitOfWork;
using WalletApp.Domain.Core.Primitivos.Result;

namespace WalletApp.Application.Funcionalidades.Command.Usuarios
{
    public class UsuarioNuevoCommandHandler : HandlerBase, ICommandHandler<UsuarioNuevoCommand>
    {

        public UsuarioNuevoCommandHandler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<Result> Handle(UsuarioNuevoCommand request, CancellationToken cancellationToken)
        {
            await _unitOfWork.SaveChangesAsync();
            return Result.Success();
        }
    }
}
