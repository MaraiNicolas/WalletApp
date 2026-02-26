using Contracts.Request.Auth;
using Microsoft.AspNetCore.Mvc;
using WalletApp.Api.Infraestructura;
using WalletApp.Application.Funcionalidades.Command.Auth;
using WalletApp.Domain.Core.Primitivos;
using WalletApp.Domain.Core.Primitivos.Result;

namespace WalletApp.Api.Controllers
{
    [Route("/[controller]/[action]")]
    [ApiController]
    public class AuthController : BaseController
    {
        [HttpPost]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
            => await Result.Create(request, new Error("",""))
                        .Map(request => new LoginCommand(request))
                        .Bind(command => Mediator.Send(command))
                        .Match(Ok, BadRequest);
    }
}
