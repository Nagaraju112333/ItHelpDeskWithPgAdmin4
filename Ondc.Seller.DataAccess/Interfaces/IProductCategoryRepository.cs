using Ondc.Seller.Domain.Entities;

namespace Ondc.Seller.DataAccess.Interfaces;

public interface IProductCategoryRepository : IRepository<ProductCategory>
{
    Task<IEnumerable<ProductCategory>> GetBySellerIdAsync(string sellerId);
}
