using Store.Domain.Entities.Orders.Statuses;

namespace Store.Domain.Entities.Orders;

public class Payment
{
    public int Id { get; set; }
    public int OrderId { get; set; }
    public Order Order { get; set; } = null!;
    public int PaymentMethodId { get; set; }
    public PaymentMethod PaymentMethod { get; set; } = null!;
    public int PaymentStatusId { get; set; }
    public PaymentStatus PaymentStatus { get; set; } = null!;
    public DateTime PaymentDate { get; set; }

    public Payment()
    {
        PaymentDate = DateTime.UtcNow;
    }
}
