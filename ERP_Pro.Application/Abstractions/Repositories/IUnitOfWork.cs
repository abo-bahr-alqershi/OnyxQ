using ERP_Pro.Application.Abstractions.Base;

namespace ERP_Pro.Application.Abstractions.Repositories;

public interface IUnitOfWork : IDisposable
{
    IRepository<TEntity, TId> Repository<TEntity, TId>() where TEntity : class, IEntity<TId>;
    
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    Task BeginTransactionAsync(CancellationToken cancellationToken = default);
    Task CommitTransactionAsync(CancellationToken cancellationToken = default);
    Task RollbackTransactionAsync(CancellationToken cancellationToken = default);
} 