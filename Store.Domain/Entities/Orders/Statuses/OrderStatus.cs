namespace Store.Domain.Entities.Orders.Statuses;

public class OrderStatus
{
    public int Id { get; set; }

    public required string Value { get; set; }
}
