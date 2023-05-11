using System;
using System.Collections.Generic;

namespace MyApp.WebApi.Models;

public partial class TicketCounter
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public int? DisplayOrder { get; set; }

    public string IsActive { get; set; } = null!;

    public int? TicketTypeId { get; set; }
}
