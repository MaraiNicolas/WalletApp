using AutoMapper;
using Contracts.Request.Usuarios;
using WalletApp.Application.Configuraciones.CQRSPatron;
using WalletApp.Application.Configuraciones.CQRSPatron.Command;
using WalletApp.Domain.Core.Abstracciones.UnitOfWork;
using WalletApp.Domain.Core.Primitivos.Result;
using WalletApp.Domain.Entities;

namespace WalletApp.Application.Funcionalidades.Command.Usuarios
{
    public class UsuarioModificarCommandHandler : HandlerBase, ICommandHandler<UsuarioModificarCommand>
    {
        public UsuarioModificarCommandHandler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<Result> Handle(UsuarioModificarCommand request, CancellationToken cancellationToken)
        {
            Result<Usuario> usuario = await ObtenerUsuarioAsync(this._unitOfWork, request.Request);
            if (usuario.IsFailure)
            {
                return Result.Failure(usuario.Error);
            }
            var usuarioValue = usuario.Value;
            usuarioValue.Actualizar(request.Request.Nombre, request.Request.Apellido, request.Request.NumeroDoc, request.Request.Email);
           // await GuardarEnBdAsync(usuarioValue);
            return Result.Success();
        }
        private async Task GuardarEnBdAsync(IUnitOfWork context, Usuario usuario)
        {
           // await context.Repositorios.UsuarioRepository.AddAsync(usuario);
            await context.SaveChangesAsync();
        }

        public async Task<Result<Usuario>> ObtenerUsuarioAsync(IUnitOfWork context, UsuarioModificarRequest request)
        {
            Usuario usuario = null;
                
            //= await context.Repositorios.UsuarioRepository.GetByGuidAsync(request.Guid);
            //if (usuario is null)
            //{
            //    return Result.Failure<Usuario>("Usuario no encontrado");
            //}
            return Result.Success(usuario);
        }
    }
}
