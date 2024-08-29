using System;
using System.Collections.Generic;

namespace ProjectKy3.Entities;

public partial class Product
{
    public long ProductId { get; set; }

    public string? Image { get; set; }

    public string? Name { get; set; }

    public string? Slug { get; set; }

    public string? Description { get; set; }

    public decimal? Price { get; set; }

    public long? CategoryId { get; set; }

    public long? BrandId { get; set; }

    public virtual Brand? Brand { get; set; }

    public virtual Category? Category { get; set; }

    public virtual ICollection<Favorite> Favorites { get; set; } = new List<Favorite>();

    public virtual ICollection<ProductVariant> ProductVariants { get; set; } = new List<ProductVariant>();

    public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();
}
