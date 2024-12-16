using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.Domain.Entities.Product;

namespace Store.Dal.Context.Config.Products;

public class ProductAttributeConfiguration : IEntityTypeConfiguration<ProductAttribute>
{
    public void Configure(EntityTypeBuilder<ProductAttribute> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name)
            .HasMaxLength(30)
            .IsRequired();

        builder.HasOne(x => x.DataType)
            .WithMany()
            .HasForeignKey(x => x.DataTypeId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasIndex(x => x.Name)
            .IsUnique();

        builder.HasIndex(x => x.DataTypeId);

        builder.ToTable("ProductAttributes");
    }
}
