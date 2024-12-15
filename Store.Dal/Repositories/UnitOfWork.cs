using Newtonsoft.Json.Linq;
using Store.Dal.Context;
using Store.Domain.Abstractions.Repositories;
using Store.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Dal.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        private readonly Dictionary<Type, object> _genericRepositories;

        public UnitOfWork(AppDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(_context));
            _genericRepositories = new Dictionary<Type, object>();
        }

        public IUserRepository Users => field ?? new UserRepository(_context);

        public IRepository<TEntity> GetGenericRepository<TEntity>() where TEntity : class
        {
            Type entityType = typeof(TEntity);

            if (_genericRepositories.ContainsKey(entityType))
            {
                return (IRepository<TEntity>)_genericRepositories[entityType];
            }
            else
            {
                IRepository<TEntity> repository = new Repository<TEntity>(_context);
                _genericRepositories.Add(entityType, repository);
                return repository;
            }
        }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }
    }
}
