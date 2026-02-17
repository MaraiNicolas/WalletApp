using Contracts.Request.Usuarios;
using WalletApp.Application.Configuraciones.CQRSPatron.Command;

namespace WalletApp.Application.Funcionalidades.Command.Usuarios
{
    public class UsuarioNuevoCommand : ICommand
    {
        public UsuarioNuevoRequest Request { get; set; }
        public UsuarioNuevoCommand(UsuarioNuevoRequest request)
        {
            this.Request = request;
        }
    }
}
