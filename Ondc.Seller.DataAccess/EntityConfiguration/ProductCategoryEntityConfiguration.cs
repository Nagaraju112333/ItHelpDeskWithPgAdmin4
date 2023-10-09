using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ondc.Seller.Domain.Entities;

namespace Ondc.Seller.DataAccess.EntityConfiguration;

public class ProductCategoryEntityConfiguration : EntityTypeConfiguration<ProductCategory>
{
    protected override void ConfigureEntity(EntityTypeBuilder<ProductCategory> builder)
    {
        builder.Property(e => e.SellerId).IsRequired();

        builder.Property(e => e.Name).IsRequired().HasMaxLength(500);

        builder.Property(e => e.IsOnline).IsRequired();

        builder.HasIndex("Name").IsUnique(true);
    }
}
