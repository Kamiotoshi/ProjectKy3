using System;
using System.Collections.Generic;

namespace ProjectKy3.Entities;

public partial class Favorite
{
    public long Id { get; set; }

    public long? UserId { get; set; }

    public long? ProductId { get; set; }

    public virtual Product? Product { get; set; }

    public virtual User? User { get; set; }
}
