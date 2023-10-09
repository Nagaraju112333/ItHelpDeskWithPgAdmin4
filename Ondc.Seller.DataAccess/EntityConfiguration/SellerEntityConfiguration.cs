using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ondc.Seller.Domain.Entities;

namespace Ondc.Seller.DataAccess.EntityConfiguration;

public class SellerEntityConfiguration : EntityTypeConfiguration<Seller.Domain.Entities.Seller>
{
    protected override void ConfigureEntity(EntityTypeBuilder<Seller.Domain.Entities.Seller> builder)
    {

        builder.Property(e => e.Name).IsRequired().HasMaxLength(500);

        builder.Property(e => e.CompanyName).IsRequired().HasMaxLength(1000);

        builder.Property(e => e.EmailAddress).IsRequired().HasMaxLength(100);

        builder.Property(e => e.PhoneNumber).IsRequired().HasMaxLength(10);

        builder.Property(e => e.Password).IsRequired().HasMaxLength(100);

        builder.Property(e => e.RegisteredDate).IsRequired();

        builder.HasIndex("CompanyName", "EmailAddress", "PhoneNumber").IsUnique(true);
    }
}
