
using Contracts.Request.Usuarios;
using WalletApp.Application.Configuraciones.CQRSPatron.Command;

namespace WalletApp.Application.Funcionalidades.Command.Usuarios
{
    public class UsuarioEliminarCommand : ICommand
    {
        public UsuarioEliminarRequest Request { get; set; }
        public UsuarioEliminarCommand(UsuarioEliminarRequest request)
        {
            Request = request;
        }
    }
}
