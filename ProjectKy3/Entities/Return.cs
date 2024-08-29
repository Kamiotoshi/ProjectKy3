using System;
using System.Collections.Generic;

namespace ProjectKy3.Entities;

public partial class Return
{
    public int ReturnId { get; set; }

    public long? OrderId { get; set; }

    public string? Reason { get; set; }

    public DateTime? RequestDate { get; set; }

    public string? Status { get; set; }

    public virtual Order? Order { get; set; }
}
