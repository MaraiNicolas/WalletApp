using Contracts.Request.Usuarios;
using WalletApp.Application.Configuraciones.CQRSPatron.Command;

namespace WalletApp.Application.Funcionalidades.Command.Usuarios
{
    public class UsuarioModificarPasswordCommand : ICommand
    {
        public UsuarioModificarPasswordRequest Request { get; set; }
        public UsuarioModificarPasswordCommand(UsuarioModificarPasswordRequest request)
        {
            Request = request;
        }
    }
}
