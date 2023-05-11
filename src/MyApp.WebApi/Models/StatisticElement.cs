using System;
using System.Collections.Generic;

namespace MyApp.WebApi.Models;

public partial class StatisticElement
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public DateTime CreatedTime { get; set; }

    public DateTime UpdateTime { get; set; }

    public int CreatedById { get; set; }

    public int UpdateById { get; set; }
}
