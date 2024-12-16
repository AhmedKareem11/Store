using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.Domain.Entities.Product;

namespace Store.Dal.Context.Config.Products;

internal class DataTypeConfiguration : IEntityTypeConfiguration<DataType>
{
    public void Configure(EntityTypeBuilder<DataType> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name)
            .HasMaxLength(20)
            .IsRequired();

        builder.HasIndex(x => x.Name)
            .IsUnique();

        builder.ToTable("DataTypes");

        builder.HasData(GetInitialData());
    }

    public static List<string> GetInitialData()
    {
        return new List<string>
        {
            "string",
            "bool",
            "number",
            "date"
        };
    }

}
