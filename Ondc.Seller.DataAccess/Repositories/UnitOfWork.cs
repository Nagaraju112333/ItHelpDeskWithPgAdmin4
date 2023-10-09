using Ondc.Seller.DataAccess.Interfaces;
using System.Diagnostics.CodeAnalysis;

namespace APLManagement.Common.Repository;

[ExcludeFromCodeCoverage]
public class UnitOfWork : IUnitOfWork
{
    public UnitOfWork(ISellerRepository sellerRepository,
            IProductRepository productRepository,            
            IProductCategoryRepository productCategoryRepository)
    {
        this.SellerRepository = sellerRepository;
        this.ProductRepository = productRepository;
        this.ProductCategoryRepository = productCategoryRepository;
    }

    public ISellerRepository SellerRepository { get; init; }
    public IProductRepository ProductRepository { get; init; }
    public IProductCategoryRepository ProductCategoryRepository { get; init; }
}