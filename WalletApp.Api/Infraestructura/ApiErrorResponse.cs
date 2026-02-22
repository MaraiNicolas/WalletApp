using WalletApp.Domain.Core.Primitivos;

namespace WalletApp.Api.Infraestructura
{
    public class ApiErrorResponse
    {

        /// <summary>
        /// Gets the errors.
        /// </summary>
        public IReadOnlyCollection<Error> Errors { get; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiErrorResponse"/> class.
        /// </summary>
        /// <param name="errors">The enumerable collection of errors.</param>
        public ApiErrorResponse(IReadOnlyCollection<Error> errors) => Errors = errors;
    }
}
