using System;
using System.Collections.Generic;

namespace ProjectKy3.Entities;

public partial class Brand
{
    public long BrandId { get; set; }

    public string? Name { get; set; }

    public string? Slug { get; set; }

    public string? Image { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
