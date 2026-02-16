using MediatR;


namespace WalletApp.Application.Abstracciones.CQRSPatron
{
    public interface ICommand
    {
        public interface ICommand<out TResponse> : IRequest<TResponse> { }
        public interface ICommand : IRequest { }
        public interface ICommandHandler<in TCommand, TResponse> : IRequestHandler<TCommand, TResponse> where TCommand : ICommand<TResponse>{ }
        public interface ICommandHandler<in TCommand> : IRequestHandler<TCommand> where TCommand : ICommand { }
    }
}
