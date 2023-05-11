using System;
using System.Collections.Generic;

namespace MyApp.WebApi.Models;

public partial class TicketPrintLog
{
    public string OrderId { get; set; } = null!;

    public string PrintedBy { get; set; } = null!;

    public DateTime PrintedDate { get; set; }

    public int PrintCount { get; set; }

    public int? TicketCounter { get; set; }
}
