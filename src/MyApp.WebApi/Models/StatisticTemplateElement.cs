using System;
using System.Collections.Generic;

namespace MyApp.WebApi.Models;

public partial class StatisticTemplateElement
{
    public int Id { get; set; }

    public int TemplateId { get; set; }

    public int ElementId { get; set; }

    public string? Value { get; set; }

    public int? RoleId { get; set; }
}
