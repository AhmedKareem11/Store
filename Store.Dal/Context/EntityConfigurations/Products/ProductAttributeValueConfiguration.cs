using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.Domain.Entities.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Store.Dal.Context.Config.Products;

internal class ProductAttributeValueConfiguration : IEntityTypeConfiguration<ProductAttributeValue>
{
    public void Configure(EntityTypeBuilder<ProductAttributeValue> builder)
    {
        builder.HasKey(x => new { x.ProductInventoryId, x.AttributeId });

        builder.Property(x => x.value)
            .HasMaxLength(255)
            .IsRequired();

        builder.HasOne(x => x.Attribute)
            .WithMany()
            .HasForeignKey(x => x.AttributeId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(x => x.ProductInventory)
            .WithMany(x => x.AttributeValues)
            .HasForeignKey(x => x.ProductInventoryId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasIndex(x => x.AttributeId);

        builder.ToTable("ProductAttributeValues");
    }
}
