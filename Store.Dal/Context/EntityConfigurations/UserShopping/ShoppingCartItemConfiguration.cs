﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.Domain.Entities.UserShopping;

namespace Store.Dal.Context.Config.UserShopping;

internal class ShoppingCartItemConfiguration : IEntityTypeConfiguration<ShoppingCartItem>
{
    public void Configure(EntityTypeBuilder<ShoppingCartItem> builder)
    {
        builder.HasKey(x => new { x.ShoppingCartId, x.ProductInventoryId });

        builder.HasOne<ShoppingCart>()
            .WithMany(x => x.Items)
            .HasForeignKey(x => x.ShoppingCartId)
            .IsRequired();

        builder.HasOne(x => x.ProductInventory)
            .WithMany()
            .HasForeignKey(x => x.ProductInventoryId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasIndex(x => x.ProductInventoryId);

        builder.ToTable("ShoppingCartItems");
    }
}