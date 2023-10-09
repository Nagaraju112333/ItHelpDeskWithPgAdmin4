using Ondc.Seller.DataAccess.Interfaces;
using Ondc.Seller.Domain.Entities;
using Ondc.Seller.Integration.Interfaces;
using Ondc.Seller.Processor.Interfaces;

namespace Ondc.Seller.Processor;

public class ProductProcessor : ProcessorBase, IProductProcessor
{
    private readonly IStorageService _storageService;
    private readonly IUnitOfWork _unitOfWork;

    public ProductProcessor(IStorageService storageService, IUnitOfWork unitOfWork)
    {
        _storageService = storageService;
        _unitOfWork = unitOfWork;
    }

    public async Task<Product> AddProductAsync(Product product)
    {
        var imageFilePath = $"{product.SellerId}/{product.Id}";
        product.ImagePath = imageFilePath;
        var productFromDb = await _unitOfWork.ProductRepository.CreateAsync(product);
        productFromDb.ImageSasUri = _storageService.GenerateSasUri(imageFilePath);
        return productFromDb;
    }

    public async Task<IEnumerable<ProductCategory>> GetProductCategoriesAsync(string sellerId)
    {
        return await _unitOfWork.ProductCategoryRepository.GetBySellerIdAsync(sellerId);
    }
}
