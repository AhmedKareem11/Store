namespace Store.Domain.Entities.Product;

public class ProductAttributeValue
{
    public int AttributeId { get; set; }
    public ProductAttribute Attribute { get; set; } = null!;
    public int ProductInventoryId { get; set; }
    public ProductInventory ProductInventory { get; set; } = null!;
    public required string value { get; set; }
}


