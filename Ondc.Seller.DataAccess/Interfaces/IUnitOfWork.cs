namespace Ondc.Seller.DataAccess.Interfaces;

public interface IUnitOfWork
{
   
    IProductRepository ProductRepository { get; }
  
}