using Ondc.Seller.DataAccess.Interfaces;
using System.Diagnostics.CodeAnalysis;
namespace APLManagement.Common.Repository;

[ExcludeFromCodeCoverage]
public class UnitOfWork : IUnitOfWork
{
    public UnitOfWork(
            IProductRepository productRepository            
           )
    {
       
        this.ProductRepository = productRepository;
        
    }

   
    public IProductRepository ProductRepository { get; init; }
   
}