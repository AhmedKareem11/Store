using Store.Domain.Entities.Orders.Statuses;
using Store.Domain.Entities.Users;

namespace Store.Domain.Entities.Orders;

public class Shipping
{
    public int Id { get; set; }
    public int OderId { get; set; }
    public Order Order { get; set; } = null!;
    public int ShippingMethodId { get; set; }
    public ShippingMethod? ShippingMethod { get; set; }
    public int AddressId { get; set; }
    public Address ShippingAddress { get; set; } = null!;
    public int ShippingStatusId { get; set; }
    public ShippingStatus ShippingStatus { get; set; } = null!;
    public DateTime ShippedDate { get; set; }
    public DateTime DeliveryDate { get; set; }

    public Shipping()
    {
        ShippedDate = DateTime.UtcNow;
    }

}
