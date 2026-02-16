using MediatR;


namespace WalletApp.Domain.Abstracciones.CQRSPatron
{
    public interface ICommand
    {
        public interface ICommand<out TResponse> : IRequest<TResponse> { }
        public interface ICommand : IRequest { }
        public interface ICommandHandler<in TCommand, TResponse> : IRequestHandler<TCommand, TResponse> where TCommand : ICommand<TResponse>{ }
    }
}
