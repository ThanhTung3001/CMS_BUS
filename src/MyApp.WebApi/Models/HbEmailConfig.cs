using System;
using System.Collections.Generic;

namespace MyApp.WebApi.Models;

public partial class HbEmailConfig
{
    public int Id { get; set; }

    public string DisplayName { get; set; } = null!;

    public string Content { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Host { get; set; } = null!;

    public int Port { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public string? Subject { get; set; }
}
