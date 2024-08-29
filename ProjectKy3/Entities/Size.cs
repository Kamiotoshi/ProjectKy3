using System;
using System.Collections.Generic;

namespace ProjectKy3.Entities;

public partial class Size
{
    public long SizeId { get; set; }

    public string? SizeName { get; set; }

    public virtual ICollection<ProductVariant> ProductVariants { get; set; } = new List<ProductVariant>();
}
