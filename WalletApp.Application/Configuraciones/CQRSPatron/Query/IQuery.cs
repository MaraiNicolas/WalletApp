using MediatR;
using WalletApp.Domain.Core.Primitivos.Maybe;

namespace WalletApp.Application.Configuraciones.CQRSPatron.Query
{
    public interface IQuery<TResult> : IRequest<Maybe<TResult>> { }
}
