namespace Store.Domain.Entities.Orders;

public class PaymentMethod
{
    public int Id { get; set; }
    public required string Name { get; set; }
}