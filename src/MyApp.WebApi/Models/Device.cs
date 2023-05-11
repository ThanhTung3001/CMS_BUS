using System;
using System.Collections.Generic;

namespace MyApp.WebApi.Models;

public partial class Device
{
    public int Id { get; set; }

    public string ValueId { get; set; } = null!;

    public string ValueName { get; set; } = null!;

    public string? Description { get; set; }
}
