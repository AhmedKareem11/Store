using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.Domain.Entities.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Dal.Context.EntityConfigurations.Orders;

internal class ShippingConfiguration : IEntityTypeConfiguration<Shipping>
{
    public void Configure(EntityTypeBuilder<Shipping> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Method)
            .HasConversion<int>()
            .IsRequired();

        builder.Property(x => x.Status)
           .HasConversion<int>()
           .IsRequired();

        builder.Property(x => x.ShippedDate)
           .IsRequired();

        builder.Property(x => x.DeliveryDate)
           .IsRequired(false);

        builder.HasOne(x => x.Order)
            .WithOne(x => x.Shipping)
            .HasForeignKey<Shipping>(x => x.OrderId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(x=>x.Address)
            .WithMany()
            .HasForeignKey(x => x.AddressId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasIndex(x => x.OrderId)
            .IsUnique();

        builder.ToTable("Shippings");

    }
}
