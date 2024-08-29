using System;
using System.Collections.Generic;

namespace ProjectKy3.Entities;

public partial class ProductVariant
{
    public long VariantId { get; set; }

    public long? ProductId { get; set; }

    public long? ColorId { get; set; }

    public long? SizeId { get; set; }

    public int? StockQuantity { get; set; }

    public virtual ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();

    public virtual Color? Color { get; set; }

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    public virtual Product? Product { get; set; }

    public virtual Size? Size { get; set; }
}
