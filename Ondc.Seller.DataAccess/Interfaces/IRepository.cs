using Ondc.Seller.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ondc.Seller.DataAccess.Interfaces;

public interface IRepository<T>  where T : EntityBase
{
    Task<T?> ReadAsync(Guid id, CancellationToken cancellationToken = default(CancellationToken));

    T? Read(Guid id);

    Task<T?> FindAsync(Guid id, CancellationToken cancellationToken = default(CancellationToken));

    T? Find(Guid id);

    Task<T> CreateAsync(T entity, CancellationToken cancellationToken = default(CancellationToken));

    T Create(T entity);

    void Update(T entity);

    void Delete(T entity);
}
