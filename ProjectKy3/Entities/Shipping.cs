using System;
using System.Collections.Generic;

namespace ProjectKy3.Entities;

public partial class Shipping
{
    public int ShippingId { get; set; }

    public long? OrderId { get; set; }

    public string? Carrier { get; set; }

    public string? TrackingNumber { get; set; }

    public DateTime? ShippingDate { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public virtual Order? Order { get; set; }
}
