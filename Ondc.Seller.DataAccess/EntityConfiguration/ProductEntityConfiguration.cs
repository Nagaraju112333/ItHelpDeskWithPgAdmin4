using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ondc.Seller.Domain.Entities;

namespace Ondc.Seller.DataAccess.EntityConfiguration;

public class ProductEntityConfiguration : EntityTypeConfiguration<Product>
{
    protected override void ConfigureEntity(EntityTypeBuilder<Product> builder)
    {
        builder.Property(e => e.SellerId).IsRequired();

        builder.Property(e => e.Name).IsRequired().HasMaxLength(500);

        builder.Property(e => e.Description).IsRequired(false).HasMaxLength(1000);

        builder.Property(e => e.Mrp).IsRequired();

        builder.Property(e => e.NoOfUnit).IsRequired();

        builder.Property(e => e.CategoryId).IsRequired();

        builder.Property(e => e.IsOnline).IsRequired();

        builder.Property(e => e.Discount);

        builder.Property(e => e.CoverImageName);

        builder.Property(e => e.ImagePath);

        builder.Property(e => e.SalesPrice).IsRequired();

        builder.Property(e => e.LowStockThresholdValue);

        builder.HasIndex("Name").IsUnique(true);
    }
}
