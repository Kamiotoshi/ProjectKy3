using System;
using System.Collections.Generic;

namespace ProjectKy3.Entities;

public partial class OrderItem
{
    public long OrderItemId { get; set; }

    public long? OrderId { get; set; }

    public long? VariantId { get; set; }

    public int? Quantity { get; set; }

    public decimal? Price { get; set; }

    public virtual Order? Order { get; set; }

    public virtual ProductVariant? Variant { get; set; }
}
