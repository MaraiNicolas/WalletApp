using MediatR;
using WalletApp.Domain.Core.Primitivos.Maybe;

namespace WalletApp.Application.Configuraciones.CQRSPatron.Query
{
    public interface IQueryHandler<in TQuery, TResult> : IRequestHandler<TQuery, Maybe<TResult>> where TQuery : IQuery<TResult> { }
}
