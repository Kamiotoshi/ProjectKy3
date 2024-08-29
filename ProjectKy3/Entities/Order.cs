using System;
using System.Collections.Generic;

namespace ProjectKy3.Entities;

public partial class Order
{
    public long OrderId { get; set; }

    public long? UserId { get; set; }

    public DateOnly? OrderDate { get; set; }

    public string? ShippingMethod { get; set; }

    public string? PaymentMethod { get; set; }

    public decimal? TotalAmount { get; set; }

    public string? Status { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? ShippingAddress { get; set; }

    public string? BillingAddress { get; set; }

    public string? State { get; set; }

    public string? City { get; set; }

    public string? OrderNote { get; set; }

    public string? Telephone { get; set; }

    public string? Email { get; set; }

    public byte? Paid { get; set; }

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    public virtual ICollection<Return> Returns { get; set; } = new List<Return>();

    public virtual ICollection<Shipping> Shippings { get; set; } = new List<Shipping>();

    public virtual User? User { get; set; }
}
