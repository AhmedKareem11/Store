using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.Domain.Entities.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Dal.Context.Config.Products;

internal class ProductInventoryImageConfiguration : IEntityTypeConfiguration<ProductInventoryImage>
{
    public void Configure(EntityTypeBuilder<ProductInventoryImage> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.ImagePath)
            .HasMaxLength(255)
            .IsRequired();

        builder.Property(x => x.DisplayOreder)
            .IsRequired();

        builder.HasOne(x=>x.productInventory)
            .WithMany(x=>x.InventoryImages)
            .HasForeignKey(x=>x.ProductInventoryId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasIndex(x=>x.ProductInventoryId);

        builder.ToTable("ProductInventoryImages");
    }
}
