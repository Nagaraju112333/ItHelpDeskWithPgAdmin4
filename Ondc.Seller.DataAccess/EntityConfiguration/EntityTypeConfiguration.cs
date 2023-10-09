using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Ondc.Seller.Domain.Entities;

namespace Ondc.Seller.DataAccess.EntityConfiguration;

public abstract class EntityTypeConfiguration<T> : IEntityTypeConfiguration<T> where T : EntityBase
{
    protected virtual bool UseConcurrencyToken => true;

    public virtual void Configure(EntityTypeBuilder<T> builder)
    {
        builder.HasKey((T e) => e.Id);
        new ValueConverter<byte[], long>((byte[] v) => BitConverter.ToInt64(v, 0), (long v) => BitConverter.GetBytes(v));
        if (UseConcurrencyToken)
        {
            builder.UseXminAsConcurrencyToken();
        }

        builder.Property(e => e.CreatedAt).ValueGeneratedOnAdd().UsePropertyAccessMode(PropertyAccessMode.Field)
             .HasDefaultValueSql("NOW()");
        builder.Property(e => e.UpdatedAt).ValueGeneratedOnAdd().UsePropertyAccessMode(PropertyAccessMode.Field)
            .HasDefaultValueSql("NOW()");
        builder.Property(e => e.CreatedBy).IsRequired(required: false).HasMaxLength(256);
        builder.Property(e => e.UpdatedBy).IsRequired(required: false).HasMaxLength(256);


        ConfigureEntity(builder);
    }

    protected abstract void ConfigureEntity(EntityTypeBuilder<T> builder);
}
