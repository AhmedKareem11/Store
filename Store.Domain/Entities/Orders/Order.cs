using Store.Domain.Entities.Orders.Statuses;
using Store.Domain.Entities.Users;

namespace Store.Domain.Entities.Orders;



/*
 * Order Statuses
    Pending
    Processing
    Shipped
    Delivered
    Cancelled
    Returned

 * Shipping Statuses
    Not Shipped
    In Transit
    Delivered
    Failed Delivery
    Returned

 * Payment Statuses
    Pending
    Completed
    Failed
    Refunded
 */
public class Order
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public User User { get; set; } = null!;
    public DateTime OrderDate { get; set; }
    public decimal TotalAmount { get; set; }
    public Shipping Shipping { get; set; } = null!;
    public int PaymentId { get; set; }
    public int OrderStatusId { get; set; }
    public OrderStatus OrderStatus { get; set; } = null!;

    public Order()
    {
        OrderDate = DateTime.UtcNow;
    }
}
