using MediatR;
using WalletApp.Domain.Core.Primitivos.Result;

namespace WalletApp.Application.Configuraciones.CQRSPatron.Command
{
    public interface ICommandHandler<in TCommand> : IRequestHandler<TCommand, Result> where TCommand : ICommand { }
    public interface ICommandHandler<in TCommand, TResult> : IRequestHandler<TCommand, Result<TResult>>
        where TCommand : ICommand<TResult>
    { }
}
