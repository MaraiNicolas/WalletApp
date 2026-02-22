using Contracts.Request.Usuarios;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WalletApp.Api.Infraestructura;
using WalletApp.Application.Funcionalidades.Command.Usuarios;
using WalletApp.Domain.Core.Primitivos;
using WalletApp.Domain.Core.Primitivos.Result;

namespace WalletApp.Api.Controllers
{
    [Route("/[controller]/[action]")]
    [ApiController]
    public class UsuarioController : BaseController
    {
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> CrearUsuario([FromBody] UsuarioNuevoRequest request)
            => await Result.Create(request, new Error("",""))
                        .Map(request => new UsuarioNuevoCommand(request))
                        .Bind(command => Mediator.Send(command))
                        .Match(Ok, NotFound);
        
    }
}
