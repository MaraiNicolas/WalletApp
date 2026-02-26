using Contracts.Request.Usuarios;
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

        public async Task<IActionResult> Nuevo([FromBody] UsuarioNuevoRequest request)
            => await Result.Create(request, new Error("", ""))
                        .Map(request => new UsuarioNuevoCommand(request))
                        .Bind(command => Mediator.Send(command))
                        .Match(Ok, BadRequest);

        [HttpPut]
        public async Task<IActionResult> Modificar([FromBody] UsuarioModificarRequest request)
            => await Result.Create(request, new Error("", ""))
                         .Map(request => new UsuarioModificarCommand(request))
                         .Bind(command => Mediator.Send(command))
                         .Match(Ok, BadRequest);

        [HttpDelete]
        public async Task<IActionResult> Eliminar([FromQuery] UsuarioEliminarRequest request)
            => await Result.Create(request, new Error("", ""))
                         .Map(request => new UsuarioEliminarCommand(request))
                         .Bind(command => Mediator.Send(command))
                         .Match(Ok, BadRequest);
    }
}
