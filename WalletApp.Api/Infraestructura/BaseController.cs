using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WalletApp.Domain.Core.Primitivos;

namespace WalletApp.Api.Infraestructura
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public abstract class BaseController : ControllerBase
    {
        private IMediator _mediator;
        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetRequiredService<IMediator>();
        /// <summary>
        /// Creates an <see cref="BadRequestObjectResult"/> that produces a <see cref="StatusCodes.Status400BadRequest"/>.
        /// response based on the specified <see cref="Result"/>
        /// </summary>
        /// <param name="error"></param>
        /// <returns></returns>
        protected IActionResult BadRequest(Error error) =>  BadRequest(new ApiErrorResponse(new[] { error}));

        ///<summary>
        /// Creates an <see cref="OkObjectResult"/> that produces a <see cref="StatusCodes.Status200OK"/>.
        /// </summary>
        /// <returns>The created <see cref="OkObjectResult"/> for the response.</returns>
        ///<returns></returns>
        protected new IActionResult Ok(object value) => Ok(value);

        protected IActionResult Ok(Guid value) => base.Ok(value);


        ///<summary>
        /// Creates an <see cref="OkResult"/> that produces a <see cref="StatusCodes.Status200OK"/>.
        /// </summary>
        /// <returns> The created <see cref="NotFoundResult"/></returns>
        protected IActionResult NotFound(Error error) => base.NotFound(new ApiErrorResponse(new[] { error }));
    }
}
