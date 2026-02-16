using System;
using System.Collections.Generic;
using System.Text;

namespace WalletApp.Infrastructure.Contexto.Repositorios
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly WalletDbContext _context;
        public GenericRepository(WalletDbContext context) => _context = context;

        public async Task AddAsync(T entity, CancellationToken ct)
        {
            await _context.Set<T>().AddAsync(entity, ct);
        }

        public async Task Update(T entity){ 
            _context.Set<T>().Update(entity);
        }
        public async Task Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }
        public async Task<T?> GetByIdAsync(object id, CancellationToken ct){ 
            return await _context.Set<T>().FindAsync(id, ct);
        }
    }
}
