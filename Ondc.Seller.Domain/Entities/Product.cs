namespace Ondc.Seller.Domain.Entities;

public class Product : EntityBase
{
    public int? CategoryId { get; set; }

    public string? Name { get; set; }

    public string? ProductId { get; set; }

    public double? Mrp { get; set; }

    public double? SalesPrice { get; set; }

    public double? Discount { get; set; }

    public string? Description { get; set; }

    public bool? IsOnline { get; set; }

    public double? LowStockThresholdValue { get; set; }

    public string? SellerId { get; set; }

    public double? NoOfUnit { get; set; }

    public string? ImagePath { get; set; }

    public string? CoverImageName { get; set; }

    public Uri? ImageSasUri { get; set; }
}
