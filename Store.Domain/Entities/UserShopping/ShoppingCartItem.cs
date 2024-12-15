
using Store.Domain.Entities.Product;

namespace Store.Domain.Entities.UserShopping;

public class ShoppingCartItem
{
    public int ShoppingCartId { get; set; }
    public int ProductInventoryId { get; set; }
    public ProductInventory ProductInventory { get; set; } = null!;
    public int Quantity { get; set; }
}


