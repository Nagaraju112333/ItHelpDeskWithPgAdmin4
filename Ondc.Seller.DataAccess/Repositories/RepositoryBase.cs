using Microsoft.EntityFrameworkCore;
using Ondc.Seller.DataAccess.Interfaces;
using Ondc.Seller.Domain.Entities;

namespace Ondc.Seller.DataAccess.Repositories;

public class RepositoryBase<T> : IRepository<T> where T : EntityBase
{
    protected readonly DbContext DbContext;

    public RepositoryBase(DbContext dbContext)
    {
        DbContext = dbContext;
    }

    public virtual async Task<T?> ReadAsync(Guid id, CancellationToken cancellationToken = default(CancellationToken))
    {
        return await DbContext.Set<T>().FindAsync(id, cancellationToken);
    }

    public virtual T? Read(Guid id)
    {
        return DbContext.Set<T>().Find(id);
    }

    public virtual async Task<T?> FindAsync(Guid id, CancellationToken cancellationToken = default(CancellationToken))
    {
        return await DbContext.FindAsync<T>(new object[1] { id }, cancellationToken);
    }

    public virtual T? Find(Guid id)
    {
        return DbContext.Find<T>(new object[1] { id });
    }

    public virtual T Create(T entity)
    {
        return DbContext.Set<T>().Add(entity).Entity;
    }

    public virtual void Delete(T entity)
    {
        DbContext.Set<T>().Remove(entity);
    }

    public virtual void Update(T entity)
    {
        DbContext.Set<T>().Update(entity);
    }

    public virtual async Task<T> CreateAsync(T entity, CancellationToken cancellationToken = default(CancellationToken))
    {
        return (await DbContext.Set<T>().AddAsync(entity, cancellationToken)).Entity;
    }

    public virtual void OnAfterCommit()
    {
    }
}
