using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain.Abstractions.Repositories;

public interface IUnitOfWork : IAsyncDisposable
{
    IUserRepository Users { get; }
    Task<int> CompleteAsync();
    IRepository<TEntity> GetGenericRepository<TEntity>() where TEntity : class;
}
