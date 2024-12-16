namespace Store.Domain.Entities.Product;

public class Category
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public bool IsActive { get; set; }
    public int? ParentCategoryId { get; set; }
    public Category? ParentCategory { get; set; }
    public ICollection<Category> ChildCategories { get; set; } = null!;

    public Category()
    {
        IsActive = true;
    }
}


