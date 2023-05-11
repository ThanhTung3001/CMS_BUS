using System;
using System.Collections.Generic;

namespace MyApp.WebApi.Models;

public partial class RequestLogger
{
    public int Id { get; set; }

    public string? IpAddress { get; set; }

    public DateTime? RequestDate { get; set; }
}
