using Ondc.Seller.Domain.Entities;

namespace Ondc.Seller.Processor.Interfaces;

public interface ICompaniesProcessor
{
  

    Task<Companies> AddProductAsync(Companies product);
}
