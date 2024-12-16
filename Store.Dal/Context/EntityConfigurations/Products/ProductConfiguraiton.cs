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

internal class ProductConfiguraiton : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name)
            .HasMaxLength(500)
            .IsRequired();

        builder.Property(x=>x.Description)
            .HasMaxLength(-1)
            .IsRequired(false);

        builder.Property(x=>x.IsActive)
            .IsRequired(true);

        builder.Property(x=>x.CreatedAt)
            .IsRequired(true);

        builder.Property(x => x.UpdatedAt)
            .IsRequired(false);

        builder.HasOne(x=>x.Brand)
            .WithMany()
            .HasForeignKey(x=>x.BrandId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(x=>x.Category)
            .WithMany()
            .HasForeignKey(x=>x.CategoryId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasIndex(x => x.BrandId);
        builder.HasIndex(x=>x.CategoryId);

        builder.ToTable("Products");
    }
}
