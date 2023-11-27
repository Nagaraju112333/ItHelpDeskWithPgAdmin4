using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ondc.Seller.Domain.Entities;

namespace Ondc.Seller.DataAccess.EntityConfiguration;

public class CompaniesEntityConfiguration : EntityTypeConfiguration<Companies>
{
    protected override void ConfigureEntity(EntityTypeBuilder<Companies> builder)
    {
        builder.Property(e => e.BusinessEmail).IsRequired();

        builder.Property(e => e.PhoneNumber).IsRequired().HasMaxLength(500);

        builder.Property(e => e.Country).IsRequired(false).HasMaxLength(1000);

        builder.Property(e => e.State).IsRequired();

        builder.Property(e => e.City).IsRequired();

        builder.Property(e => e.Address).IsRequired();

        builder.Property(e => e.PinCode).IsRequired();



        builder.HasIndex("BusinessEmail", "PhoneNumber").IsUnique(true);
    }
}
