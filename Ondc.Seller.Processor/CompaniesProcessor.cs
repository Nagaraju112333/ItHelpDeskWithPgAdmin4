using Ondc.Seller.DataAccess.Interfaces;
using Ondc.Seller.Domain.Entities;
using Ondc.Seller.Integration.Interfaces;
using Ondc.Seller.Processor.Interfaces;

namespace Ondc.Seller.Processor;

public class CompaniesProcessor : ProcessorBase, ICompaniesProcessor
{
    private readonly IStorageService _storageService;
    private readonly IUnitOfWork _unitOfWork;

    public CompaniesProcessor(IStorageService storageService, IUnitOfWork unitOfWork)
    {
        _storageService = storageService;
        _unitOfWork = unitOfWork;
    }

    public async Task<Companies> AddProductAsync(Companies product)
    {
      /*  var imageFilePath = $"{product.SellerId}/{product.Id}";
        product.ImagePath = imageFilePath;
        var productFromDb = await _unitOfWork.ProductRepository.CreateAsync(product);
        productFromDb.ImageSasUri = _storageService.GenerateSasUri(imageFilePath);*/
        return product;
    }

   
}
