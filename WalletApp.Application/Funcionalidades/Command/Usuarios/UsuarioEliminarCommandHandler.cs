using AutoMapper;
using Contracts.Request.Usuarios;
using WalletApp.Application.Configuraciones.CQRSPatron;
using WalletApp.Application.Configuraciones.CQRSPatron.Command;
using WalletApp.Domain.Core.Abstracciones.UnitOfWork;
using WalletApp.Domain.Core.Primitivos.Result;
using WalletApp.Domain.Entities;

namespace WalletApp.Application.Funcionalidades.Command.Usuarios
{
    public class UsuarioEliminarCommandHandler : HandlerBase, ICommandHandler<UsuarioEliminarCommand>
    {
        public UsuarioEliminarCommandHandler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<Result> Handle(UsuarioEliminarCommand request, CancellationToken cancellationToken)
        {
            Result<Usuario> usuario = await ObtenerUsuarioAsync(_unitOfWork, request.Request);

            return Result.Success();
        }
        private async Task<Result<Usuario>> ObtenerUsuarioAsync(IUnitOfWork context, UsuarioEliminarRequest request)
        {
            Usuario usuario = null;
            // = await context.Repositorios.UsuarioRepository.GetByGuidAsync(request.Guid);
            //if(usuario is null) {
            //  return Result.Failure<Usuario>("El usuario seleccionado no existe.");
            //}
            return Result.Success(usuario); 
        }
    }
}
