namespace Ondc.Seller.Domain.Entities;

public class ProductCategory : EntityBase
{
    public string? SellerId { get; set; }

    public string? Name { get; set; }

    public string? OndcCategoryId { get; set; }

    public bool? IsOnline { get; set; }
}
