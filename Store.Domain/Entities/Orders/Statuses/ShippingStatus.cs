namespace Store.Domain.Entities.Orders.Statuses;

public class ShippingStatus
{
    public int Id { get; set; }

    public required string Value { get; set; }
}
