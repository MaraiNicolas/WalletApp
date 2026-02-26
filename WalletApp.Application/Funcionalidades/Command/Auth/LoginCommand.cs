using Contracts.Request.Auth;
using WalletApp.Application.Configuraciones.CQRSPatron.Command;

namespace WalletApp.Application.Funcionalidades.Command.Auth
{
    public class LoginCommand : ICommand
    {
        public LoginRequest Request { get; set; }
        public LoginCommand(LoginRequest request)
        {
            this.Request = request;
        }
    }
}
