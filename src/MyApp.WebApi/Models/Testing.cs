using System;
using System.Collections.Generic;

namespace MyApp.WebApi.Models;

public partial class Testing
{
    public long Id { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string? Fullname { get; set; }
}
