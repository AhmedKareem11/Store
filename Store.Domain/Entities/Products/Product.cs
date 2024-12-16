using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain.Entities.Product;

public class Product
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
    public bool IsActive { get; set; }
    public int BrandId { get; set; }
    public Brand Brand { get; set; } = null!;
    public int CategoryId { get; set; }
    public Category Category { get; set; } = null!;
    public DateTime CreatedAt { get; private set; }
    public DateTime? UpdatedAt { get; set; }
    public ICollection<ProductInventory> Inventories { get; set; }


    public Product()
    {
        IsActive = true;
        CreatedAt = DateTime.UtcNow;
    }
}


