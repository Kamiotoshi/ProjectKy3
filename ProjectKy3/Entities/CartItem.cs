using System;
using System.Collections.Generic;

namespace ProjectKy3.Entities;

public partial class CartItem
{
    public long CartItemId { get; set; }

    public long? UserId { get; set; }

    public long? VariantId { get; set; }

    public int? Quantity { get; set; }

    public virtual User? User { get; set; }

    public virtual ProductVariant? Variant { get; set; }
}
