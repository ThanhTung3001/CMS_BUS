using System;
using System.Collections.Generic;

namespace MyApp.WebApi.Models;

public partial class TicketUsedLog
{
    public int Id { get; set; }

    public string? OrderId { get; set; }

    public int? TicketTypeId { get; set; }

    public DateTime? UsedDate { get; set; }

    public string IsUsed { get; set; } = null!;

    public DateTime? CreatedDate { get; set; }
}
