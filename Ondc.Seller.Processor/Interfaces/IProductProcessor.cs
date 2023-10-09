using Ondc.Seller.Domain.Entities;

namespace Ondc.Seller.Processor.Interfaces;

public interface IProductProcessor
{
    Task<IEnumerable<ProductCategory>> GetProductCategoriesAsync(string sellerId);

    Task<Product> AddProductAsync(Product product);
}
