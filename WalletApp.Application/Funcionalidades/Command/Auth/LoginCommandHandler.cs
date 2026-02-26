using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using WalletApp.Application.Configuraciones.CQRSPatron;
using WalletApp.Application.Configuraciones.CQRSPatron.Command;
using WalletApp.Domain.Core.Abstracciones.UnitOfWork;
using WalletApp.Domain.Core.Primitivos.Result;

namespace WalletApp.Application.Funcionalidades.Command.Auth
{
    public class LoginCommandHandler : HandlerBase, ICommandHandler<LoginCommand>
    {
        //private readonly IJWTProvider _jwtProvider;
        public LoginCommandHandler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
            //this._jwtProvider = jwtProvider;
        }

        public Task<Result> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
