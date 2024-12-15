namespace Store.Domain.Entities.Product;

public class ProductAttributeValue
{
    public int Id { get; set; }
    public int AttributeId { get; set; }
    public Attribute Attribute { get; set; } = null!;
    public int ProductInventoryId { get; set; }
    public ProductInventory ProductInventory { get; set; } = null!;
    public required string value { get; set; }
}


