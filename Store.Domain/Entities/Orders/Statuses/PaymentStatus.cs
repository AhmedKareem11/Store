namespace Store.Domain.Entities.Orders.Statuses;

public class PaymentStatus
{
    public int Id { get; set; }

    public required string Value { get; set; }
}
