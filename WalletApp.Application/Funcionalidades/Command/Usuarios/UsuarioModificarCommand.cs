using Contracts.Request.Usuarios;
using WalletApp.Application.Configuraciones.CQRSPatron.Command;

namespace WalletApp.Application.Funcionalidades.Command.Usuarios
{
    public class UsuarioModificarCommand : ICommand
    {
        public UsuarioModificarRequest Request { get; set; }
        public UsuarioModificarCommand(UsuarioModificarRequest request)
        {
            this.Request = request;
        }
    }
}
