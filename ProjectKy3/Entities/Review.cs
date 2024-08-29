using System;
using System.Collections.Generic;

namespace ProjectKy3.Entities;

public partial class Review
{
    public long ReviewId { get; set; }

    public long? UserId { get; set; }

    public long? ProductId { get; set; }

    public byte? Rating { get; set; }

    public string? Comment { get; set; }

    public virtual Product? Product { get; set; }

    public virtual User? User { get; set; }
}
