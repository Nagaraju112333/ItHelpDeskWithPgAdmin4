using Ondc.Seller.DataAccess.Entities;
using Ondc.Seller.DataAccess.Interfaces;

namespace Ondc.Seller.DataAccess.Repositories;

public class SellerRepository : RepositoryBase<Domain.Entities.Seller>, ISellerRepository
{
    public SellerRepository(
    AppDbContext dbContext)
    : base(dbContext)
    {
    }
}
