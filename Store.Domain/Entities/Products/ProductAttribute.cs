namespace Store.Domain.Entities.Product;

public class ProductAttribute
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public int DataTypeId { get; set; }
    public DataType DataType { get; set; } = null!;
}


