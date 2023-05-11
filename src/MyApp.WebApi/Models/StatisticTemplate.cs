using System;
using System.Collections.Generic;

namespace MyApp.WebApi.Models;

public partial class StatisticTemplate
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int IstatisticElementId { get; set; }

    public bool? IsTrinhDien { get; set; }

    public DateTime CreatedTime { get; set; }

    public DateTime UpdateTime { get; set; }

    public int UpdateById { get; set; }

    public int CreatedById { get; set; }

    public int? BaseTemplate { get; set; }
}
