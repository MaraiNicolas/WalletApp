using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WalletApp.Api.Infraestructura;
using WalletApp.Domain.Core.Primitivos.Result;

namespace WalletApp.Api.Controllers
{
    [Route("/[controler]/[action]")]
    [ApiController]
    [Authorize]
    public class TransaccionController : BaseController
    {
        //[HttpPost]
        //public async Task<IActionResult> RealizarTransaccion()
        //  => await Result.Create(request, Domain.Core.Primitivos.Error)

    }
}
