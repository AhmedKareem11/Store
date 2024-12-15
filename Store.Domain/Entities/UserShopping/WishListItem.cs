
using Store.Domain.Entities.Product;

namespace Store.Domain.Entities.UserShopping;

public class WishListItem
{
    public int WishListId { get; set; }
    public int ProductInventoryId { get; set; }
    public ProductInventory ProductInventory { get; set; } = null!;
}


