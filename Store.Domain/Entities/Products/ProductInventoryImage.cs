namespace Store.Domain.Entities.Product;

public class ProductInventoryImage
{
    public int Id { get; set; }
    public int ProductInventoryId { get; set; }
    public ProductInventory productInventory { get; set; } = null!;
    public string? ImagePath { get; set; }
    public int DisplayOreder { get; set; }
}


