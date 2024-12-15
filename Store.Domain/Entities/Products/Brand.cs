namespace Store.Domain.Entities.Product;

public class Brand
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public string? Logo { get; set; }
}


