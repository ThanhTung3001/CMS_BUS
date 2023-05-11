using System;
using System.Collections.Generic;

namespace MyApp.WebApi.Models;

public partial class RoleClaim
{
    public int Id { get; set; }

    public string RoleId { get; set; } = null!;

    public string? ClaimType { get; set; }

    public string? ClaimValue { get; set; }

    public virtual Role1 Role { get; set; } = null!;
}
