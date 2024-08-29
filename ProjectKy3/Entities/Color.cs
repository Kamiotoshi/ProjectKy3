using System;
using System.Collections.Generic;

namespace ProjectKy3.Entities;

public partial class Color
{
    public long ColorId { get; set; }

    public string? ColorName { get; set; }

    public virtual ICollection<ProductVariant> ProductVariants { get; set; } = new List<ProductVariant>();
}
