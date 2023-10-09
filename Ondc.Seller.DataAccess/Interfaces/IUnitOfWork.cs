namespace Ondc.Seller.DataAccess.Interfaces;

public interface IUnitOfWork
{
    ISellerRepository SellerRepository { get; }
    IProductRepository ProductRepository { get; }
    IProductCategoryRepository ProductCategoryRepository { get; }
}