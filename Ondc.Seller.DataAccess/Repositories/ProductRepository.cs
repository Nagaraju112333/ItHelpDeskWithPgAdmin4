using Ondc.Seller.DataAccess.Entities;
using Ondc.Seller.DataAccess.Interfaces;
using Ondc.Seller.Domain.Entities;

namespace Ondc.Seller.DataAccess.Repositories;

public class ProductRepository : RepositoryBase<Product>, IProductRepository
{
    public ProductRepository(
    AppDbContext dbContext)
    : base(dbContext)
    {
    }
}
