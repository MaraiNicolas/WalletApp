using AutoMapper;
using WalletApp.Application.Configuraciones.CQRSPatron;
using WalletApp.Application.Configuraciones.CQRSPatron.Command;
using WalletApp.Domain.Core.Abstracciones.UnitOfWork;
using WalletApp.Domain.Core.Primitivos.Result;

namespace WalletApp.Application.Funcionalidades.Command.Usuarios
{
    public class UsuarioModificarPasswordCommandHandler : HandlerBase, ICommandHandler<UsuarioModificarPasswordCommand>
    {
        public UsuarioModificarPasswordCommandHandler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<Result> Handle(UsuarioModificarPasswordCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
