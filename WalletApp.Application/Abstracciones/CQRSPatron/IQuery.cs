using MediatR;

namespace WalletApp.Application.Abstracciones.CQRSPatron
{
    public interface IQuery
    {
        public interface IQuery<out TResponse> : IRequest<TResponse> { }
        public interface IQueryHandler<in TQuery, TResponse> : IRequestHandler<TQuery, TResponse> where TQuery : IQuery<TResponse> { }
    }
}
