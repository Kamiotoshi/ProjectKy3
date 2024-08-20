using System;
using System.Collections.Generic;

namespace ProjectKy3.Entities;

public partial class User
{
    public int Id { get; set; }

    public string Fullname { get; set; } = null!;

    public string Emaill { get; set; } = null!;

    public string? Password { get; set; }

    public string Role { get; set; } = null!;
}
