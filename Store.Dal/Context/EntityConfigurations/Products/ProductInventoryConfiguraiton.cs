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

internal class ProductInventoryConfiguraiton : IEntityTypeConfiguration<ProductInventory>
{
    public void Configure(EntityTypeBuilder<ProductInventory> builder)
    {
        builder.HasIndex(x=>x.Id);

        builder.Property(x => x.IsActive)
            .IsRequired();

        builder.Property(x => x.IsDigital)
           .IsRequired();

        builder.Property(x => x.Price)
            .HasColumnType("decimal(10,2)")
            .IsRequired();

        builder.Property(x => x.Weight)
            .IsRequired();

        builder.Property(x=>x.UnitsInStock)
            .IsRequired();

        builder.Property(x=>x.CreatedAt)
            .IsRequired();

        builder.Property(x => x.UpdatedAt)
            .IsRequired(false);

        builder.HasOne(x => x.Product)
            .WithMany(x=>x.Inventories)
            .HasForeignKey(x=>x.ProductId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);

       builder.HasIndex(x=>x.ProductId);

        builder.ToTable("ProductInventories");
    }
}
