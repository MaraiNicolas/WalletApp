using MediatR;
using WalletApp.Domain.Core.Primitivos.Result;

namespace WalletApp.Application.Configuraciones.CQRSPatron.Command
{
    public interface ICommand : IRequest<Result> { }
    public interface ICommand<TResult> : IRequest<Result<TResult>> { }
}
