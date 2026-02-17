using System;
using System.Collections.Generic;
using System.Text;
using WalletApp.Domain.Core.Abstracciones.UnitOfWork;

namespace WalletApp.Infrastructure.Contexto.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly WalletDbContext _context;

        public UnitOfWork(WalletDbContext context)
        {
            _context = context;
        }

        public async Task SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
