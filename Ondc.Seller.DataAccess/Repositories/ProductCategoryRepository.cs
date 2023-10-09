using Microsoft.EntityFrameworkCore;
using Ondc.Seller.DataAccess.Entities;
using Ondc.Seller.DataAccess.Interfaces;
using Ondc.Seller.Domain.Entities;

namespace Ondc.Seller.DataAccess.Repositories;

public class ProductCategoryRepository : RepositoryBase<ProductCategory>, IProductCategoryRepository
{
    public ProductCategoryRepository(
    AppDbContext dbContext)
    : base(dbContext)
    {
    }
    public async Task<IEnumerable<ProductCategory>> GetBySellerIdAsync(string sellerId)
    {
        return await this.DbContext?.Set<ProductCategory>().Where(
            pd => pd.SellerId == sellerId)?.ToListAsync();
    }
}

