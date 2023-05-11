using System;
using System.Collections.Generic;

namespace MyApp.WebApi.Models;

public partial class HbCustomerType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Note { get; set; } = null!;

    public DateTime? CreatedTime { get; set; }

    public int? UpdateById { get; set; }

    public DateTime? UpdateTime { get; set; }

    public int? CreatedById { get; set; }

    public string? ColorCode { get; set; }

    public virtual ICollection<HbTicketPrice> HbTicketPrices { get; set; } = new List<HbTicketPrice>();
}
