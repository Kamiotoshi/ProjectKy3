using System;
using System.Collections.Generic;

namespace ProjectKy3.Entities;

public partial class Payment
{
    public int PaymentId { get; set; }

    public long? OrderId { get; set; }

    public string? PaymentMethod { get; set; }

    public DateTime? PaymentDate { get; set; }

    public decimal? Amount { get; set; }

    public virtual Order? Order { get; set; }
}
